using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoDSI.Backend;
using System.Windows.Forms;

namespace TrabajoPracticoDSI.Objetos
{
    class Exposicion
    {
        public string fechaFin { get; set; }
        public string fechaInicio { get; set; }
        public int id { get; set; }
        public int idTipo { get; set; }
        public int idPublicoDestino { get; set; }
        public int idSede { get; set; }

        Conexion_DB _DB = new Conexion_DB();
        DataTable detalles = new DataTable();
        DetalleExposicion detalle = new DetalleExposicion();

        public bool esVigente()
        {
            if (Convert.ToDateTime(fechaFin) < DateTime.Now)
                return false;
            
            else
                return true;
        }

        public int calcularDuracionObrasExpuestas()
        {
          
            int duracionTotal = 0;
            string sql = $"SELECT * FROM Detalle_Exposicion WHERE idExposicion = {this.id}";
            detalles = _DB.EjecutarSelect(sql);

            for (int i = 0; i < detalles.Rows.Count; i++)
            {
                detalle.idObra = int.Parse(detalles.Rows[0]["idObra"].ToString());
                duracionTotal += detalle.buscarDuracionResumidaObra();
            }
      
            return duracionTotal;
        }
    }
}
