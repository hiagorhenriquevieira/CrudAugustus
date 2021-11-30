using CrudAugustusFashion.Model.Produto;

namespace CrudAugustusFashion.Model.Carinho
{
    public class CarrinhoModel
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Dinheiro PrecoVenda { get; set; }
        public Dinheiro Desconto { get; set; }
        public Dinheiro PrecoLiquido { get; set; }
        public Dinheiro Total { get; set; }
        public Dinheiro PrecoCusto { get; set; }
    }
}
