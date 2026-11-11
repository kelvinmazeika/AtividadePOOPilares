using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadePilares
{
    public class CursoOnline : ProdutoDigital
    {
        public int DuracaoHoras { get; set; }
        
        public CursoOnline(string nome, decimal preco, int duracaoHoras) : base(nome, preco)
        {
            DuracaoHoras = duracaoHoras;
        }
        
    }
}