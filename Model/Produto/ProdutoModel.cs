namespace CrudAugustusFashion.Model.Produto
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string NomeProduto{ get; set; }
        public decimal PrecoVenda{ get; set; }
        public decimal PrecoCusto{ get; set; }
        public string CodigoDeBarras{ get; set; }
        public string NomeFabricante { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Status StatusProduto { get; set; }

        public int Lucro { get; set; }

        public enum Status
        {
            ativo = 1,
            inativo = 0
        }
    }
}
