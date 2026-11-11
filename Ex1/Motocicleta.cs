using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Cilindradas: {Cilindradas}");
        }

        public Motocicleta(string marca, string modelo, int cilindradas) : base()
        {
            Marca = marca;
            Modelo = modelo;
            Cilindradas = cilindradas;
        }

    }
}