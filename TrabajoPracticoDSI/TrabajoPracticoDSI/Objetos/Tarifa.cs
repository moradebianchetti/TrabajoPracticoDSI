using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDSI.Objetos
{
    public class Tarifa
    {
        public string fechaInicioVigencia { get; set; }
        public string fechaFinVigencia { get; set; }
        public TipoEntrada tipoEntrada { get; set; }
        public TipoVisita tipoVisita { get; set; }
        public int montoAdicionalGuia { get; set; }
        public int monto { get; set; }
        public int idSede { get; set; }

        public bool esVigente()
        {
            if(this.fechaFinVigencia != "" || this.fechaFinVigencia != null)
            {
                return true;
            }
            return false;

        }

        public void getTarifaVigente(int idTipoVisita, int idTipoEntrada)
        {
            TipoVisita visita = new TipoVisita();
            TipoEntrada entrada = new TipoEntrada();

            visita.getTipoVisita(idTipoVisita);
            entrada.getNombreTipoEntrada(idTipoEntrada);

            this.tipoVisita = visita;
            this.tipoEntrada = entrada;
        }

        internal void calcularMonto(int montoBase)
        {
            this.monto = montoBase * (1 + (this.tipoVisita.porcentaje + this.tipoEntrada.porcentaje));

        }
    }
}
