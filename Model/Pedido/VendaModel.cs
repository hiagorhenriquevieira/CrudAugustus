using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Model.Pedido
{
    public class VendaModel
    {
        
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }  
        public int IdColaborador { get; set; }
        public Dinheiro TotalBruto { get => Produtos.Sum(x => x.PrecoVenda.Valor * x.Quantidade);}
        public Dinheiro TotalDesconto { get => Produtos.Sum(x => x.Quantidade * x.Desconto.Valor);}
        public Dinheiro TotalLiquido { get => Produtos.Sum(x => x.PrecoLiquido.Valor * x.Quantidade);}
        public Dinheiro LucroTotal { get => Produtos.Sum(x => x.Total.Valor - (x.Quantidade * x.PrecoCusto.Valor));}  
        public string FormaDePagamento { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataEmissao { get; set; }

        public List<CarrinhoModel> Produtos {get; set;}

        public VendaModel()
        {
            Produtos = new List<CarrinhoModel>();
        }
        
        public decimal QuantidadeGasta { get; set; }

       
    }
}
