using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoDSI.Objetos
{
    public interface iObservadorActualizarPantalla
    {
        void actualizarCantidadVisitantes(int visitantes, int cantidadMaxima);
    }
}
