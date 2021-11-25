namespace CrudAugustusFashion.Model.Produto
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string CodigoDeBarras{ get; set; }
        public string Nome{ get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Fabricante { get; set; }
        public decimal PrecoVenda{ get; set; }
        public decimal PrecoCusto{ get; set; }
        public int Lucro { get; set; }
        public bool Ativo { get; set; }
    }
}
