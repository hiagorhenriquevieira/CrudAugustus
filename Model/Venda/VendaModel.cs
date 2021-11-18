using CrudAugustusFashion.Model.Produto.Pedido;
using System.Collections.Generic;

namespace CrudAugustusFashion.Model.Venda
{
    class VendaModel
    {
        public VendaModel()
        {
            new List<FormaPagamentoModel>();
        }
        public int IdVenda { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public decimal PrecoBruto { get; set; }
        public decimal PrecoCusto { get; set; }
        public int QuantidadeProduto { get; set; }
        public decimal Desconto { get; set; }
        public decimal PrecoLiquido { get; set; }
        public decimal Total { get; set; }

        public List<FormaPagamentoModel> ListaPagamentos { get; set; }
    }
}
