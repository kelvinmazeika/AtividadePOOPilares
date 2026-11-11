using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set;}

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Quantidade Portas: {QuantidadePortas}");
        }

        public Carro(string marca, string modelo, int quantidadePortas) : base()
        {
            Marca = marca;
            Modelo = modelo;
            QuantidadePortas = quantidadePortas;
        }
    }
}