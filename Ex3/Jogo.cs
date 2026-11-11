using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }

        protected string? Plataforma { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Plataforma: {Plataforma}");
        }
    }
}