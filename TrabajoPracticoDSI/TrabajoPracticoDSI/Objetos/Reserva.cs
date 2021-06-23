using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDSI.Objetos
{
    class Reserva
    {
        public int cantidadAlumnos { get; set; }
        public int cantidadAlumnosConfirmados { get; set; }
        public int duracionEstimada { get; set; }
        public DateTime fechaHoraCreacion { get; set; }
        public DateTime fechaHoraReserva { get; set; }
        public DateTime horaFinReal { get; set; }
        public DateTime horaInicioReal { get; set; }
        public int dnumeroReserva { get; set; }


        public List<Reserva> esHoraFechaDelDia(DataTable datosReserva, int duracionEstimada)
        {
            List<Reserva> Reservas = new List<Reserva>();
            for (int i = 0; i < datosReserva.Rows.Count; i++)
            {
                cantidadAlumnosConfirmados = int.Parse(datosReserva.Rows[i]["cantidadAlumnosConfirmados"].ToString());
                this.duracionEstimada = int.Parse(datosReserva.Rows[i]["duracionEstimada"].ToString());
                this.fechaHoraReserva = Convert.ToDateTime(datosReserva.Rows[i]["fechaHoraReserva"].ToString());
                string[] fechaHora = datosReserva.Rows[i]["fechaHoraReserva"].ToString().Split(' ');

                DateTime horaInicioReserva = Convert.ToDateTime(fechaHora[1]);
                DateTime horaFinReserva = horaInicioReserva.AddMinutes(this.duracionEstimada);
                DateTime horaInicioEntrada = DateTime.Now;
                DateTime horaFinEntrada = horaInicioEntrada.AddMinutes(duracionEstimada);
                

                if((horaFinEntrada > horaInicioReserva) ||(horaInicioEntrada < horaFinReserva))
                {
                    Reservas.Add(this);
                }
                
            }
            return Reservas;
           
        }
    }
}
