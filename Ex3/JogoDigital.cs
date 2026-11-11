using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class JogoDigital : Jogo
    {
        public int mb { get; set; }
        public JogoDigital(string nome, string plataforma, int mb)
        {
            Nome = nome;
            Plataforma = plataforma;
            this.mb = mb;
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}, Tamanho: {mb} MB");
        }
    }
}