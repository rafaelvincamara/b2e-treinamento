using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras
{
    public class Pedido
    {
        public string NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        private List<PedidoItem> Itens { get; set; }

        public decimal Valor
        {
            get
            {
                return (Itens?.Any() ?? false) ? Itens.Sum(item => item.ValorUnitario * item.Qtde) : 0;
            }
        }

        public Pedido(string numeroPedido)
        {
            Itens = new List<PedidoItem>();
            DataPedido = DateTime.Now;
            NumeroPedido = numeroPedido;
        }

        public void AdicionarItem(PedidoItem pedidoItem)
        {
            if (pedidoItem.Qtde <= 3)
            {
                Itens.Add(pedidoItem);
            }
        }

        public void AdicionarItem(int qtde, decimal valorUnitario, string codigoProduto, string nomeProduto, decimal precoProduto)
        {
            AdicionarItem(new PedidoItem()
            {
                Qtde = qtde,
                ValorUnitario = valorUnitario,
                Produto = new Produto()
                {
                    Codigo = codigoProduto,
                    Nome = nomeProduto,
                    Preco = precoProduto
                }
            });
        }

        public void AdicionarItem(int qtde, Produto produto)
        {
            AdicionarItem(new PedidoItem()
            {
                Qtde = qtde,
                ValorUnitario = produto.Preco,
                Produto = produto
            });

            produto.QtdeEstoque -= qtde;
        }

        public void AdicionarItem(int qtde, Produto produto, List<Produto> produtos)
        {
            AdicionarItem(new PedidoItem()
            {
                Qtde = qtde,
                ValorUnitario = produto.Preco,
                Produto = produto
            });

            Produto produtoCadastro = produtos.Find(p => p.Codigo.Equals(produto.Codigo));
            produtoCadastro.QtdeEstoque -= qtde;
        }

        public List<PedidoItem> ObterItens()
        {
            List<PedidoItem> pedidoItems = new List<PedidoItem>();

            Itens.ForEach(item => pedidoItems.Add(item));

            return pedidoItems;
        }

        public void RemoverItem(PedidoItem pedidoItem)
        {
            Itens.Remove(pedidoItem);
        }

        public string GerarNotaFiscal()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {Cliente.Nome}");
            sb.AppendLine($"Número do Pedido: {NumeroPedido}");
            sb.AppendLine($"Data do Pedido: {DataPedido.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Valor do Pedido: {Valor.ToString("C2")}");
            sb.AppendLine($"Itens");

            foreach (var item in Itens)
            {
                sb.AppendLine($"Produto: {item.Produto.Nome} | Qtde: {item.Qtde} | Vl unitário: {item.ValorUnitario} | Total: {item.Qtde*item.ValorUnitario} ");
            }

            return sb.ToString();
        }
    }
}
