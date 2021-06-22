using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Backend;
//using TrabajoPracticoDSI.Formularios;

namespace TrabajoPracticoDSI.Clase
{
    class Tratamientos_Especiales
    {
        public enum Resultado { correcto, error }

        public string ConstructorSelect(Control.ControlCollection controles, string join, string nombreTabla)
        {
            string sql = "SELECT ";
            string condiciones = "";
            string atributosTabla = "";
            bool todos = false;

            foreach (var control in controles)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.Panel")
                {
                    ConstructorSelect(((Panel)control).Controls, join, nombreTabla);
                }
                //SELECT ATRIBUTOS FROM TABLA
                if (control.GetType().ToString() == "TrabajoPracticoDSI.Clase.DataGridView_Museo")
                {
                    DataGridView_Museo grid = ((DataGridView_Museo)control);
                    atributosTabla += $"{ExtraerColumnasGrid(grid)} FROM {nombreTabla}";
                }

                //Evaluación Checkbox
                if (control.GetType().ToString() == "System.Windows.Forms.CheckBox")
                {
                    if (((CheckBox)control).Checked)
                        todos = true;
                }

                //Evaluación TEXTBOX
                if (control.GetType().ToString() == "TrabajoPracticoDSI.Clase.TextBox_Museo")
                {
                    TextBox_Museo txt = (TextBox_Museo)control;

                    //Crea la condición que se va a asignar
                    string condicion = $"{txt.Pp_NombreTabla}.{txt.Pp_NombreCampo} LIKE {FormatearDato(txt.Text, true)}";

                    if (txt.Text != "")
                    {
                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;
                        else
                            condiciones += " AND " + condicion;
                    }
                }

                //Evaluación MASKEDTEXTBOX
                if (control.GetType().ToString() == "TrabajoPracticoDSI.Clase.MaskedTextBox_Museo")
                {
                    MaskedTextBox_Museo txt = (MaskedTextBox_Museo)control;

                    if (txt.Text != "")
                    {
                        //Crea la condición que se va a asignar
                        string condicion = $"{txt.Pp_NombreTabla}.{txt.Pp_NombreCampo}={FormatearDato(txt.Text, true)}";


                        //Asigna la primer condición
                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;

                        //Asigna condiciones subsiguientes
                        else
                            condiciones += " AND " + condicion;
                    }
                }

                //Evaluación COMBOBOX
                if (control.GetType().ToString() == "TrabajoPracticoDSI.Clase.ComboBox_Museo")
                {
                    ComboBox_Museo cmb = (ComboBox_Museo)control;
                    if (cmb.SelectedIndex != -1)
                    {
                        //En caso de que la tabla donde se encuentra la información de este combobox
                        //sea distinta de la tabla con la que estamos tratando en el ABM se hace la condición
                        //teniendo en cuenta el nombreCampoInsert, el cual es una referencia al nombre del atributo 
                        //buscado pero en la tabla principal del ABM
                        string condicion = "";
                        if (cmb.Pp_NombreTabla != nombreTabla)
                            condicion = $"{nombreTabla}.{cmb.Pp_NombreCampoInsert} = " +
                                $"{FormatearDato(cmb.SelectedValue.ToString(), false)}";
                        else
                            condicion = $"{cmb.Pp_NombreTabla}.{cmb.Pp_PkTabla}=" +
                                $"{FormatearDato(cmb.SelectedValue.ToString(), false)}";

                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;
                        else
                            condiciones += " AND " + condicion;
                    }
                }
            }
            if (atributosTabla == "")
                atributosTabla = $" * FROM {nombreTabla} ";
            if (todos)
                condiciones = "";

            sql += atributosTabla + join + condiciones;
            return sql;
        }

        public object FormatearDato(string dato, bool llevaLike)
        {
            try
            {
                int entero = int.Parse(dato);
                return entero;
            }
            catch (Exception)
            {
                if (llevaLike)
                    return $"'%{dato}%'";
                else
                    return $"'{dato}'";
            }
        }

        private string ExtraerColumnasGrid(DataGridView_Museo grid)
        {
            string nombresColumnas = "";
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (nombresColumnas == "")
                {
                    nombresColumnas += grid.Pp_NombreTabla + "." + grid.Columns[i].Name.ToString();
                }
                else
                    nombresColumnas += ", " + grid.Pp_NombreTabla + "." + grid.Columns[i].Name.ToString();
            }
            return nombresColumnas;
        }

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {

                if (item.GetType().Name == "TextBox_Museo")
                {
                    TextBox_Museo txt = (TextBox_Museo)item;
                    if (txt.Text == "")
                    {
                        MessageBox.Show(txt.Pp_MensajeError);
                        txt.Focus();
                        return Resultado.error;
                    }
                }

                if (item.GetType().Name == "ComboBox_Museo")
                {
                    ComboBox_Museo cmb = (ComboBox_Museo)item;
                    if (cmb.SelectedIndex == -1)
                    {
                        MessageBox.Show(cmb.Pp_MensajeError);
                        cmb.Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "DataGridView_Museo")
                {
                    DataGridView_Museo grid = (DataGridView_Museo)item;
                    if (grid.Rows.Count > 0 && grid.Name.ToString() == "Grid_Telefonos")
                    {
                        if (ValidarTelefonos(grid) == Resultado.error)
                        {
                            MessageBox.Show("Telefono mal carrgado");
                            return Resultado.error;
                        }
                    }

                }
                if (item.GetType().Name == "MaskedTextBox_Museo")
                {
                    MaskedTextBox_Museo msk = (MaskedTextBox_Museo)item;
                    if (msk.Text == "")
                    {
                        MessageBox.Show(msk.Pp_MensajeError);
                        msk.Focus();
                        return Resultado.error;
                    }
                }

                // Si se le pasa un panel, ejecutar de forma recursiva hasta encontrar un control válido
                if (item.GetType().Name == "Panel")
                {
                    this.Validar(((Panel)item).Controls);
                }
            }
            return Resultado.correcto;
        }

        public Resultado ValidarFecha(string fecha)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            try
            {
                DateTime.ParseExact(fecha, "d", provider);
                return Resultado.correcto;
            }
            catch (Exception)
            {
                MessageBox.Show("La fecha ingresada no es correcta. Por favor ingrese la fecha en el formato DD/MM/AAAA.");
                return Resultado.error;
            }
        }

        private Resultado ValidarTelefonos(DataGridView_Museo grid)
        {
            for (int i = 0; i < grid.Rows.Count - 1; i++)
            {
                try
                {
                    int.Parse(grid.Rows[i].Cells[0].Value.ToString().Replace(" ", ""));
                }
                catch (Exception)
                {
                    MessageBox.Show("El teléfono ingresado no es correcto");
                    grid.Rows[i].Selected = true;
                    return Resultado.error;
                }
            }
            return Resultado.correcto;
        }

        public string CostructorInsert(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);

                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }

            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            //MessageBox.Show(sql);
            return sql;
        }

        //Dependiendo de la variable esUpdate va a generar una consulta de actualización o de borrado
        //MUY IMPORTANTE: En el diseño completar la propiedad Pp_EsPk de los controles
        public string CostructorUpdateDelete(string NombreTabla, Control.ControlCollection controles, bool esUpdate)
        {
            string sql = "";
            if (esUpdate)
                sql = $"UPDATE {NombreTabla}";
            else
                sql = $"DELETE FROM {NombreTabla}";
            string condiciones = "";
            string cambios = "";
            string tipoDatoColumna = "";
            string columna = "";
            string valorColumna = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            if (esUpdate)
                for (int i = 0; i < Estructura.Columns.Count; i++)
                {
                    valorColumna = "";
                    columna = Estructura.Columns[i].Caption;
                    valorColumna = BuscarColumnaEnControlesSegunPk(columna, controles, false);
                    tipoDatoColumna = Estructura.Columns[i].DataType.ToString();

                    if (valorColumna != "")
                    {
                        valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                        if (cambios == "")
                            cambios += $" SET {columna} = {valorColumna}";
                        else
                            cambios += $", {columna} = {valorColumna}";
                    }
                }
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                valorColumna = "";
                columna = Estructura.Columns[i].Caption;
                valorColumna = BuscarColumnaEnControlesSegunPk(columna, controles, true);
                tipoDatoColumna = Estructura.Columns[i].DataType.ToString();

                if (valorColumna != "")
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (condiciones == "")
                        condiciones += $" WHERE {columna} = {valorColumna}";
                    else
                        condiciones += $" AND {columna} = {valorColumna}";
                }
            }
            return $"{sql}{cambios}{condiciones}";
        }

        public DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            Conexion_DB _BD = new Conexion_DB();
            return _BD.EjecutarSelect("SELECT TOP 1 * FROM " + NombreTabla);
        }

        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox_Museo")
                {
                    TextBox_Museo txt = (TextBox_Museo)item;

                    if (txt.Pp_NombreCampo == campo)
                        return txt.Text;
                }
                if (item.GetType().Name == "ComboBox_Museo")
                {
                    ComboBox_Museo cmb = (ComboBox_Museo)item;

                    if (cmb.Pp_NombreCampoInsert == campo && cmb.SelectedIndex != -1)
                        return cmb.SelectedValue.ToString();
                }
                if (item.GetType().Name == "MaskedTextBox_Museo")
                {
                    MaskedTextBox_Museo txt = (MaskedTextBox_Museo)item;
                    if (txt.Pp_NombreCampo == campo)
                        return txt.Text;
                }
            }
            return "";

        }
        private string BuscarColumnaEnControlesSegunPk(string campo, Control.ControlCollection controles, bool BuscaPk)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox_Museo")
                {
                    TextBox_Museo txt = (TextBox_Museo)item;


                    if (txt.Pp_NombreCampo == campo)
                        if (txt.Pp_EsPk == BuscaPk)
                            return txt.Text;
                }
                if (item.GetType().Name == "ComboBox_Museo")
                {
                    ComboBox_Museo cmb = (ComboBox_Museo)item;
                    if (cmb.Pp_NombreCampoInsert == campo)
                    {
                        if (cmb.Pp_EsPk == BuscaPk)
                            return cmb.SelectedValue.ToString();
                    }
                }
                if (item.GetType().Name == "MaskedTextBox_Museo")
                {
                    MaskedTextBox_Museo txt = (MaskedTextBox_Museo)item;

                    if (txt.Pp_NombreCampo == campo)
                        if (txt.Pp_EsPk == BuscaPk)
                            return txt.Text;
                }
            }
            return "";

        }

        public void InsertarDatosEnControles(DataTable tabla, Control.ControlCollection controles)
        {
            for (int i = 0; i < tabla.Columns.Count; i++)
            {
                string nombreColumna = tabla.Columns[i].Caption;

                foreach (var item in controles)
                {
                    if (item.GetType().ToString() == "TrabajoPracticoDSI.Clase.ComboBox_Museo")
                    {
                        ComboBox_Museo cmb = (ComboBox_Museo)item;
                        cmb.SelectedValue = tabla.Rows[0][cmb.Pp_NombreCampoInsert].ToString();
                    }
                    if (item.GetType().ToString() == "TrabajoPracticoDSI.Clase.TextBox_Museo")
                    {
                        TextBox_Museo txt = (TextBox_Museo)item;
                        txt.Text = tabla.Rows[0][txt.Pp_NombreCampo].ToString();
                    }
                    if (item.GetType().ToString() == "TrabajoPracticoDSI.Clase.MaskedTextBox_Museo")
                    {
                        MaskedTextBox_Museo txt = (MaskedTextBox_Museo)item;
                        txt.Text = tabla.Rows[0][txt.Pp_NombreCampo].ToString();
                    }
                }
            }
        }

        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                case "System.String":
                    return "'" + valorColumna + "'";
                case "System.DateTime":
                case "DateTime":
                    return $" CONVERT(DATE, '{valorColumna}', 110)";
                case "Int16":
                case "Int32":
                case "Int64":
                    return valorColumna;
                default:
                    return valorColumna;
            }
        }
    }
}
