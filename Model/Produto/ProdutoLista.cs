namespace CrudAugustusFashion.Model.Produto
{
   public class ProdutoLista
    {
        public int IdProduto { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Nome { get; set; }
        public string Fabricante{ get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal QuantidadeEstoque { get; set; }

    }
}
