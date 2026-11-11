using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class Veiculo
    {
        public string? Marca { get; set;}

        public string? Modelo { get; set;}
        
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
        
    }
}