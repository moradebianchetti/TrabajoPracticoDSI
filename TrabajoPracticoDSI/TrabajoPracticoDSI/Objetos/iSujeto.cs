using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDSI.Objetos
{
    public interface iSujeto
    {
        void Notificar();

        void Suscribir(iObservadorActualizarPantalla observer);

        void Quitar(iObservadorActualizarPantalla observer);

    }
}
