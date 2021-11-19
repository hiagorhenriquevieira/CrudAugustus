using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Produto.Pedido;
using System.Collections.Generic;

namespace CrudAugustusFashion.Model.Pedido
{
   public class VendaModel
    {
        
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalDesconto { get; set; }
        public decimal TotalLiquido { get; set; }
        public decimal Lucro { get; set; }  
        public FormaPagamentoModel FormaDePagamento { get; set; }

        public List<CarrinhoModel> Produtos {get; set;}
        public VendaModel()
        {
            Produtos = new List<CarrinhoModel>();
        }
    }
}
