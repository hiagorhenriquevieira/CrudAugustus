using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model.Produto.Pedido
{
    class ProdutoPedidoModel
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int QuantidadeProduto{ get; set; }
        public decimal Desconto { get; set; }
        public decimal PrecoLiquido { get; set; }
        public decimal Total { get; set; }
    }
}
