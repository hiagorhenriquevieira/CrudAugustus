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

        //public override string ToString()
        //{
        //    return $"IdProduto:{IdVenda} Nome:{Nome} Quantidade:{Quantidade} Preço Venda:{PrecoVenda.DinheiroFormatado}" +
        //        $"Desconto:{Desconto.DinheiroFormatado} Preço Custo:{PrecoCusto.DinheiroFormatado} " +
        //        $"Preço Liquido:{PrecoLiquido.DinheiroFormatado} Total:{Total.DinheiroFormatado}"; 
        //}
    }
}
