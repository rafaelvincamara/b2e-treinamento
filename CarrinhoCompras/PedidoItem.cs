using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrinhoCompras
{
    public class PedidoItem
    {
        public int Qtde { get; set; }
        public decimal ValorUnitario { get; set; }
        public Produto Produto { get; set; }
    }
}
