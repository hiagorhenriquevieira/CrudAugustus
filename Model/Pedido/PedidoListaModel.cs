using CrudAugustusFashion.Enums;

namespace CrudAugustusFashion.Model.Produto.Pedido
{
    public class PedidoListaModel
    {
        public int IdVenda { get; set; }
        public string NomeCliente { get; set; }
        public string NomeColaborador { get; set; }
        public EFormaDePagamento FormaDePagamento { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalLiquido { get; set; }
        public decimal Lucro { get; set; }
    }
}
