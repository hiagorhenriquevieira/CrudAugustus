using CrudAugustusFashion.Model.Produto;
using System.ComponentModel;

namespace CrudAugustusFashion.Model.Carinho
{
    public class CarrinhoModel
    {
        
        [DisplayName ("Código Venda")]
        public int IdVenda { get; set; }
        
        [DisplayName ("Código Produto")]
        public int IdProduto { get; set; }
        
        [DisplayName ("Nome")]
        public string Nome { get; set; }
        
        [DisplayName ("Quantidade")]
        public int Quantidade { get; set; }
        
        [DisplayName ("Preço Venda")]
        public Dinheiro PrecoVenda { get; set; }
        
        [DisplayName ("Desconto")]
        public Dinheiro Desconto { get; set; }
        
        [DisplayName ("Preço Liquído")]
        public Dinheiro PrecoLiquido { get => PrecoVenda.Valor - Desconto.Valor; }
        
        [DisplayName ("Total")]
        public Dinheiro Total { get => Quantidade * PrecoLiquido.Valor; }
        
        [DisplayName ("Preço Custo")]
        public Dinheiro PrecoCusto { get; set; }
    }
}
