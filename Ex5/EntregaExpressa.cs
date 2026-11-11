using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class EntregaExpressa : Entrega
    {
        public override void CalcularFrete()
        {
            decimal Frete = Distancia * 0.5m;
            Console.WriteLine($"O valor do frete para entrega expressa é: {Frete}");
        }
    }
}