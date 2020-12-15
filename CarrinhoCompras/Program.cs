using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(codigo: "123", nome: "Fralda Pampers", qtdeEstoque: 10, preco: 10));
            produtos.Add(new Produto(codigo: "321", nome: "Creme dental", qtdeEstoque: 5, preco: 5));

            Pedido pedido = new Pedido(numeroPedido: "123456");
            Cliente cliente = new Cliente();
            cliente.Cpf = "99999999";
            cliente.Nome = "Rafael Camara";
            pedido.Cliente = cliente;

            pedido.AdicionarItem(qtde: 1, new Produto(codigo: "123", nome: "Fralda Pampers", qtdeEstoque: 10, preco: 10), produtos);
            pedido.AdicionarItem(qtde: 1, new Produto(codigo: "321", nome: "Creme dental", qtdeEstoque: 5, preco: 5), produtos);

            Produto p1 = new Produto() { Nome = "p1" };
            Produto p2 = new Produto() { Nome = "p2" };
          
            Console.WriteLine(pedido.GerarNotaFiscal());

            foreach (var produto in produtos)
            {
                Console.WriteLine($"Produto {produto.Nome} | Qtde estoque {produto.QtdeEstoque}");
            }
            
            Console.ReadKey();
        }
    }
}


