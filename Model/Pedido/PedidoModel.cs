namespace CrudAugustusFashion.Model.Pedido
{
    class PedidoModel
    {
        public int IdPedido { get; set; }
        public int IdCliente{ get; set; }
        public int IdColaborador { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalLiquido { get; set; }
    }
}
