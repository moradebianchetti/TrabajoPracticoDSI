using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoDSI.Backend;

namespace TrabajoPracticoDSI.Objetos
{
    public class TipoVisita
    {
        Conexion_DB _DB = new Conexion_DB();
        public int id { get; set; }
        public float porcentaje { get; set; }
        public string nombre { get; set; }
        public TipoVisita(int idTipoVisita)
        {
            string sql = $"SELECT * FROM Tipo_Visita WHERE id = {idTipoVisita}";
            DataTable tipoVisita = _DB.EjecutarSelect(sql);
            this.nombre = tipoVisita.Rows[0]["nombre"].ToString();
            this.porcentaje = float.Parse(tipoVisita.Rows[0]["porcentaje"].ToString());
        }

        //public void getTipoVisita(int idTipoVisita)
        //{

        //}
    }
}
