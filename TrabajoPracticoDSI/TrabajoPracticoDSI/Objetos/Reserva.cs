﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                //DateTime horaInicioReserva = DateTime.ParseExact(fechaHora[1], "hh:mm:ss", System.Globalization.CultureInfo.CurrentCulture);
                DateTime horaInicioReserva = Convert.ToDateTime(fechaHora[1]);
                DateTime fechaDelDia = Convert.ToDateTime(fechaHora[0]);
                DateTime horaFinReserva = horaInicioReserva.AddMinutes(this.duracionEstimada);
                //DateTime horaInicioEntrada = DateTime.ParseExact(DateTime.Now, "hh:mm:ss", System.Globalization.CultureInfo.CurrentCulture);

                DateTime horaInicioEntrada = DateTime.Now;
                DateTime horaFinEntrada = horaInicioEntrada.AddMinutes(duracionEstimada);
                //DateTime horaFinEntrada = DateTime.ParseExact(fechaHora[1], "hh:mm:ss", System.Globalization.CultureInfo.CurrentCulture);


                if (((horaFinEntrada > horaInicioReserva) || (horaInicioEntrada < horaFinReserva)) && (fechaDelDia == DateTime.Now))
                {
                    MessageBox.Show("entro");
                    Reservas.Add(this);
                }
                //MessageBox.Show("d " + horaFinEntrada.ToString()+" , " + horaInicioReserva.ToString()+" , " + horaInicioEntrada.ToString()+ " , " + horaFinReserva.ToString());
            }
            return Reservas;
           
        }
    }
}
