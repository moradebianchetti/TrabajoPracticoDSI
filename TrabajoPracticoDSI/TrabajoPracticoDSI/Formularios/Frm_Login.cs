using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoDSI.Objetos;
using TrabajoPracticoDSI.Backend;

namespace TrabajoPracticoDSI.Formularios
{
    public partial class Frm_Login : Form
    {
        public enum Respuesta { validacion_correcta, validacion_incorrecta };
        Conexion_DB _BD = new Conexion_DB();
        Sesion sesion = new Sesion();
        Usuario usuario = new Usuario();

        public string Usuario { get; set; }
        public string Password
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }
        
        public Frm_Login()
        {
            InitializeComponent();
        }

        public void habilitarPantalla()
        {
            this.ShowDialog();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
           
        }
        
        public Sesion SesionActual()
        {
            return sesion;
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("NO esta cargado el usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Focus();
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("NO esta cargado el password", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_password.Focus();
                return;
            }

            if (Validar_usuario(txt_usuario.Text, txt_password.Text) == Respuesta.validacion_correcta)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Este usuario y password " +
                                "no está registrado en la base de datos"
                                , "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        public Respuesta Validar_usuario(string usr, string pssw)
        {
            //    SELECT * FROM usuarios WHERE n_usuario = 'Luis' AND password = '123'
            string sql = "";
            sql = "SELECT * FROM usuario WHERE nombre = '" + usr + "' AND contraseña= '" + pssw + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 0)
            {
                //decir que no existe es usuario y passw
                return Respuesta.validacion_incorrecta;
            }
            else
            {
                string sql1 = @"INSERT INTO SESION (usuario, fechaInicio, horaInicio) values ('" + tabla.Rows[0]["nombre"].ToString()+
                    @"',convert(date, '" + DateTime.Now.ToString("dd-MM-yyyy") + "',103), convert(time, '" + DateTime.Now.ToString("hh:mm:ss") + "', 108))";
                _BD.Insertar(sql1, true);

                //se encontro el usuario y se lo validó

                usuario.nombre = tabla.Rows[0]["nombre"].ToString();
                usuario.dni_empleado = int.Parse(tabla.Rows[0]["DNIEmpleado"].ToString());
                usuario.contraseña = tabla.Rows[0]["contraseña"].ToString();

                sesion.horaInicio = DateTime.Now.ToString("hh:mm:ss tt");
                sesion.fechaInicio = DateTime.Now.ToString("dd-MM-yyyy");
                sesion.usuario = usuario;

                return Respuesta.validacion_correcta;
            }
        }
        

    }
}
