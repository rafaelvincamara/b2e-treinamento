using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras
{
    public class Produto
    {        
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QtdeEstoque { get; set; }
        public decimal Preco { get; set; }

        public Produto() { }

        public Produto(string codigo, string nome, int qtdeEstoque, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            QtdeEstoque = qtdeEstoque;
            Preco = preco;
        }
    }
}
