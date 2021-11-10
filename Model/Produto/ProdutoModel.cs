namespace CrudAugustusFashion.Model.Produto
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome{ get; set; }
        public decimal PrecoVenda{ get; set; }
        public decimal PrecoCusto{ get; set; }
        public string CodigodeBarras{ get; set; }
        public string Fabricante { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Status StatusProduto { get; set; }


        public enum Status
        {
            ativo = 1,
            inativo = 0
        }
    }
}
