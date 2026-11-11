using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class Contrato : IImprimivel
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimindo contrato...");
        }
    }
}