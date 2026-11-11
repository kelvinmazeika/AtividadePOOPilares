using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class EntregaEconomica : Entrega
    {
        public override void CalcularFrete()
        {
            decimal Frete = Distancia * 0.2m;
            Console.WriteLine($"O valor do frete para entrega econômica é: {Frete}");
        }
        
    }
}