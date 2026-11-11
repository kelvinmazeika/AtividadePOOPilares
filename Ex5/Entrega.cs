using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public abstract class Entrega
    {
        public int Distancia { get; set; }

        public abstract void CalcularFrete();
    }
}