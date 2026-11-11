using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class JogoFisico : Jogo
    {
        public int QuantidadeCD { get; set; }
        public JogoFisico(string nome, string plataforma, int quantidadeCD)
        {
            Nome = nome;
            Plataforma = plataforma;
            QuantidadeCD = quantidadeCD;
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}, Quantidade de CDs: {QuantidadeCD}");
        }
    }
}