using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Produto.Pedido;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Model.Pedido
{
   public class VendaModel
    {
        
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public decimal TotalBruto { get => Produtos.Sum(x => x.PrecoVenda * x.Quantidade); }
        public decimal TotalDesconto { get => Produtos.Sum(x => x.DescontoDecimal + x.DescontoDecimal);}
        public decimal TotalLiquido { get => Produtos.Sum(x => x.PrecoLiquido + x.PrecoLiquido); }
        public decimal LucroTotal { get => Produtos.Sum(x => x.PrecoLiquido - x.PrecoCusto);}  
        public string FormaDePagamento { get; set; }

        public List<CarrinhoModel> Produtos {get; set;}
        public VendaModel()
        {
            Produtos = new List<CarrinhoModel>();
        }
    }
}
