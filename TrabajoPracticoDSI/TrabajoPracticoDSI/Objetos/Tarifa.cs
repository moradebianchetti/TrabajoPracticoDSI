using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TrabajoPracticoDSI.Objetos
{
    public class Tarifa
    {
        public string fechaInicioVigencia { get; set; }
        public string fechaFinVigencia { get; set; }
        public TipoEntrada tipoEntrada { get; set; }
        public TipoVisita tipoVisita { get; set; }
        public int montoAdicionalGuia { get; set; }
        public float monto { get; set; }
        public int idSede { get; set; }
       
        public Tarifa()
        {

        }
        public Tarifa(DataRow tarifa_f)
        {
            fechaFinVigencia = tarifa_f["fechaFinVigencia"].ToString();
            fechaInicioVigencia = tarifa_f["fechaInicioVigencia"].ToString();
            montoAdicionalGuia = int.Parse(tarifa_f["montoAdicionalGuia"].ToString());
            idSede = int.Parse(tarifa_f["idSede"].ToString());
            tipoVisita = new TipoVisita(int.Parse(tarifa_f["idTipoVisita"].ToString()));
            tipoEntrada = new TipoEntrada(int.Parse(tarifa_f["idTipoEntrada"].ToString()));

        }
        public bool esVigente()
        {
            if (this.fechaFinVigencia != "" || this.fechaFinVigencia != null)
            {
                return true;
            }
            return false;

        }

        public object[] getTarifaVigente(int montoBase)
        {
            //TipoVisita visita = new TipoVisita();
            //TipoEntrada entrada = new TipoEntrada();

            //visita.getTipoVisita(idTipoVisita);
            //entrada.getNombreTipoEntrada(idTipoEntrada);

            //this.tipoVisita = visita;
            //this.tipoEntrada = entrada;
            calcularMonto(montoBase);

            object[] conjunto = new object[5];
            conjunto[0] = tipoVisita.nombre;
            conjunto[1] = tipoEntrada.nombre;
            conjunto[2] = this.monto;
            conjunto[3] = this.montoAdicionalGuia;

            return conjunto;
            
        }

        internal void calcularMonto(int montoBase)
        {
            
            this.monto = montoBase * (1 + (this.tipoVisita.porcentaje/100 + this.tipoEntrada.porcentaje/100));

        }
    }
}
