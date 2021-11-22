using CrudAugustusFashion.Model.Carinho;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Model.Venda
{
    public class VendaConsulta
    {
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public int IdColaborador { get; set; }
        public string NomeColaborador { get; set; }
        public decimal TotalBruto { get => Produtos.Sum(x => x.PrecoVenda * x.Quantidade); }
        public decimal TotalDesconto { get => Produtos.Sum(x => x.Quantidade * x.DescontoDecimal); }
        public decimal TotalLiquido { get => Produtos.Sum(x => x.PrecoLiquido * x.Quantidade); }
        public decimal LucroTotal { get => Produtos.Sum(x => x.Total - (x.Quantidade * x.PrecoCusto)); }
        public string FormaDePagamento { get; set; }

        public List<CarrinhoModel> Produtos { get; set; }
        public VendaConsulta()
        {
            Produtos = new List<CarrinhoModel>();
        }
    }
}
