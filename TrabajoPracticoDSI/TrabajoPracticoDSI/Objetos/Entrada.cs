using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDSI.Objetos
{
    class Entrada
    {
        public string fechaVenta { get; set; }
        public string horaVenta { get; set; }
        public int monto { get; set; }
        public int numero { get; set; }
        public Sede sede { get; set; }
        public Tarifa tarifa { get; set; }

        public List<Entrada> BuscarEsFechaDelDia(DataTable datosEntrada, List<Entrada> entradas)
        {
            
            for (int i = 0; i < datosEntrada.Rows.Count; i++)
            {
                fechaVenta = datosEntrada.Rows[i]["fechaVenta"].ToString();
                horaVenta = datosEntrada.Rows[i]["horaVenta"].ToString();
                monto = int.Parse(datosEntrada.Rows[i]["monto"].ToString());
                numero = int.Parse(datosEntrada.Rows[i]["numero"].ToString());

                if (fechaVenta == DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    entradas.Add(this);
                }

            }
            return entradas;
        }

       
    }
}
