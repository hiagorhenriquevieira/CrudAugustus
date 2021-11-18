namespace CrudAugustusFashion.Model.Produto.Pedido
{
    class PedidoLista
    {
        public int IdColaborador { get; set; }
        public int IdCliente { get; set; }
        public int IdProduto { get; set; }
        public string CodigoDeBarras { get; set; }
        public string NomeCliente { get; set; }
        public string NomeColaborador { get; set; }
        public int FormaDePagamento { get; set; }
        public int TotalBruto { get; set; }
        public int TotalDesconto { get; set; }
        public int TotalLiquido { get; set; }

        
    }
}
