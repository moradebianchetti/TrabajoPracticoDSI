using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoDSI.Backend;

namespace TrabajoPracticoDSI.Objetos
{
    class DetalleExposicion
    {
        public int idObra { get; set; }
        public string lugarAsignado { get; set; }
        public int idExposicion { get; set; }

        Conexion_DB _DB = new Conexion_DB();
        DataTable obras = new DataTable();

        public int buscarDuracionResumidaObra()
        {
            string sql = $"SELECT duracionResumida FROM Obra WHERE idObra = {this.idObra}";
            obras = _DB.EjecutarSelect(sql);
            return int.Parse(obras.Rows[0]["duracionResumida"].ToString());
        }
    }
}
