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
    public class Sede
    {
        public int cantidadMaxVisitantes { get; set; }
        public int cantidadMaxPorGuia{ get; set; }
        public string nombre { get; set; }
        public int id { get; set; }
        public int montoBase { get; set; }
        private List<Tarifa> tarifasSede { get; set; }
        private List<object[]> tarifasVigentes { get; set; }

        Conexion_DB _DB = new Conexion_DB();

        DataTable tarifas = new DataTable();
        DataTable exposiciones = new DataTable();
        DataTable datosReservas = new DataTable();
        DataTable datosEntradas = new DataTable();
        
        Reserva reserva = new Reserva();
        Entrada entrada = new Entrada();

        public Sede(int id)
        {
            string sql = $"SELECT * FROM tarifa WHERE idSede = {id}";
            tarifas = _DB.EjecutarSelect(sql);
            tarifasSede = new List<Tarifa>();
            tarifasVigentes = new List<object[]>();

            for (int i = 0; i < tarifas.Rows.Count; i++)
            {
                Tarifa tarifa = new Tarifa(tarifas.Rows[i]);
                tarifasSede.Add(tarifa);
            }
                

        }

        public void getSede(int id)
        {
            string sql = $"SELECT * FROM Sede WHERE id = {id}";
            DataTable sede = _DB.EjecutarSelect(sql);

            this.id = id;
            this.cantidadMaxPorGuia = int.Parse(sede.Rows[0]["cantidadMaxPorGuia"].ToString());
            this.cantidadMaxVisitantes = int.Parse(sede.Rows[0]["cantidadMaxVisitantes"].ToString());
            this.montoBase = int.Parse(sede.Rows[0]["montoBase"].ToString());
            this.nombre = sede.Rows[0]["nombre"].ToString();
        }

        public List<object[]> obtenerTarifa()
        {
            //Se aplica el patron experto en información, bajo acoplamiento y alta cohesión
            foreach (Tarifa item in this.tarifasSede)
            {
                if(item.esVigente())
                {
                    object[] conjunto = item.getTarifaVigente(montoBase);
                    conjunto[4] = item;
                    tarifasVigentes.Add(conjunto);
                   
                }

            }

            return tarifasVigentes;

            //for (int i = 0; i < tarifas.Rows.Count; i++)
            //{
            //    Tarifa tarifa = new Tarifa();

            //    tarifa.fechaFinVigencia = tarifas.Rows[i]["fechaFinVigencia"].ToString();
            //    tarifa.fechaInicioVigencia = tarifas.Rows[i]["fechaInicioVigencia"].ToString();
            //    tarifa.montoAdicionalGuia = int.Parse(tarifas.Rows[i]["montoAdicionalGuia"].ToString());
            //    tarifa.idSede = int.Parse(tarifas.Rows[i]["idSede"].ToString());
                
            //    if (tarifa.esVigente())
            //    {
            //        int idTipoVisita = int.Parse(tarifas.Rows[i]["idTipoVisita"].ToString());
            //        int idTipoEntrada = int.Parse(tarifas.Rows[i]["idTipoEntrada"].ToString());

            //        tarifa.getTarifaVigente(idTipoVisita, idTipoEntrada);
                    
            //        tarifa.calcularMonto(montoBase);
            //        tarifa.tipoVisita.id = idTipoVisita;
            //        tarifa.tipoEntrada.id = idTipoEntrada;

            //        tarifasSede.Add(tarifa);
            //    }
            //}

            //return tarifasSede;
        }

        public int obtenerDuracionAExposicionesVigentes()
        {

            //Se aplica el patron experto en informacion y bajo acoplamiento.
            int duracionTotal = 0;
            string sql = $"SELECT * FROM Exposicion WHERE idSede = {this.id}";
            exposiciones = _DB.EjecutarSelect(sql);

            for (int i = 0; i < exposiciones.Rows.Count; i++)
            {
                Exposicion exposicion = new Exposicion();
                exposicion.fechaFin = exposiciones.Rows[i]["fechaFin"].ToString();
                exposicion.id = int.Parse(exposiciones.Rows[i]["id"].ToString());

                if (exposicion.esVigente())
                {
                    duracionTotal += exposicion.calcularDuracionObrasExpuestas();

                }
            }
            
            return duracionTotal;

        }

        internal int obtenerCantidadVisitantesEnSede(int duracionExposicion)
        {
            int CantidadReservas = buscarReservasDelDia(duracionExposicion);
            int CantidadEntradas = buscarEntradasDelDia();
            return CantidadReservas+CantidadEntradas;
        }

        private int buscarReservasDelDia(int duracionExposicion)
        {
            //Se aplica el patron experto en información y bajo acoplamiento ...
            List<Reserva> Reservas = new List<Reserva>();
            int cantidadAlumnosConfirmada = 0;
            string sql1 = $"SELECT * FROM Reserva WHERE idSede = {this.id}";
            datosReservas = _DB.EjecutarSelect(sql1);
            Reservas = reserva.esHoraFechaDelDia(datosReservas, duracionExposicion);
            foreach (Reserva reserva in Reservas)
            {
                cantidadAlumnosConfirmada = cantidadAlumnosConfirmada + reserva.cantidadAlumnosConfirmados;
            }
            return cantidadAlumnosConfirmada;
        }

        private int buscarEntradasDelDia()
        {
            List<Entrada> Entradas = new List<Entrada>();
            string sql2 =$"SELECT * FROM Entrada WHERE idSede = {this.id}";
            datosEntradas = _DB.EjecutarSelect(sql2);
            Entradas = entrada.BuscarEsFechaDelDia(datosEntradas, Entradas);

            return Entradas.Count();
        }
        public int obtenerUltimoNroEntrada()
        {
            int mayorNumero = entrada.getNroEntrada(datosEntradas);
            return mayorNumero;
        }


    }
}
