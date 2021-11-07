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
    public partial class Entrada
    {
        public string fechaVenta { get; set; }
        public string horaVenta { get; set; }
        public float monto { get; set; }
        public int numero { get; set; }
        public Sede sede { get; set; }
        public Tarifa tarifa { get; set; }
        
        Conexion_DB _DB = new Conexion_DB();

        public Entrada()
        {
        }
        public Entrada(DateTime fechaHoraActual, Sede sedeActual, Tarifa tarifa, int mayorNumero)
        {
            //TODO: ver si todas entradas es un atributo 
            string sqlEntradas = $"SELECT * FROM Entrada";
            DataTable todasEntradas = _DB.EjecutarSelect(sqlEntradas);

            string[] hoy = fechaHoraActual.ToString().Split(' ');
            this.sede = sedeActual;
            this.tarifa = tarifa;
            this.fechaVenta = hoy[0];
            this.horaVenta = hoy[1];
            this.monto = tarifa.monto;
            this.numero = mayorNumero;

            string sql = @"INSERT INTO Entrada (fechaVenta, horaVenta, monto, numero, idSede, idTipoEntrada, " +
                                @"idTipoVisita, fechaInicioVigencia) VALUES(CONVERT(date, '" + this.fechaVenta + "' ,103)" +
                            @", CONVERT(time, '" + horaVenta + "', 103), " + tarifa.monto.ToString() + ", " + mayorNumero.ToString() +
                            @", " + sede.id.ToString() + "," + tarifa.tipoEntrada.id + ", " + tarifa.tipoVisita.id +
                            @", CONVERT(datetime, '" + tarifa.fechaInicioVigencia + "',103) )";

            _DB.Insertar(sql, true);

        }
        public List<Entrada> BuscarEsFechaDelDia(DataTable datosEntrada, List<Entrada> entradas)
        {
            for (int i = 0; i < datosEntrada.Rows.Count; i++)
            {

                fechaVenta = datosEntrada.Rows[i]["fechaVenta"].ToString();
                horaVenta = datosEntrada.Rows[i]["horaVenta"].ToString();
                monto = int.Parse(datosEntrada.Rows[i]["monto"].ToString());
                numero = int.Parse(datosEntrada.Rows[i]["numero"].ToString());

                string[] hoy = DateTime.Now.ToString().Split(' ');
                string[] fechaDiaEntrada = fechaVenta.ToString().Split(' ');


                if (fechaDiaEntrada[0] == hoy[0])
                {
                    entradas.Add(this);
                }

            }
            return entradas;
        }
        public int getNroEntrada(DataTable todasEntradas)
        {
            int nro = 0;
            int mayorNumero = 0;

            for (int i = 0; i < todasEntradas.Rows.Count; i++)
            {
                nro = int.Parse(todasEntradas.Rows[i]["numero"].ToString());
                if (nro > mayorNumero)
                {
                    mayorNumero = nro;
                }
            }
            return mayorNumero;
        }

    }
}
