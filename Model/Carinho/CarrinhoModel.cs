namespace CrudAugustusFashion.Model.Carinho
{
    class CarrinhoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal DescontoDecimal { get; set; }
        public decimal PrecoLiquido { get; set; }
        public decimal Total { get; set; }
    }
}
