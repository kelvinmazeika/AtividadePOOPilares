using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class RetiradaLocal : Entrega
    {
        public override void CalcularFrete()
        {
            decimal Frete = 0;
            Console.WriteLine($"O valor do frete para retirada local é: {Frete}");
        }
    }
}