namespace CrudAugustusFashion.Model.Carinho
{
    public class CarrinhoModel
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal Desconto { get; set; }
        public decimal PrecoLiquido { get; set; }
        public decimal Total { get; set; }
        public decimal PrecoCusto { get; set; }

    }
}
