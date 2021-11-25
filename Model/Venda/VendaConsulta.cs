using CrudAugustusFashion.Model.Carinho;
using System.Collections.Generic;
using static CrudAugustusFashion.Model.Pedido.VendaModel;

namespace CrudAugustusFashion.Model.Venda
{
    public class VendaConsulta
    {
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public int IdColaborador { get; set; }
        public string NomeColaborador { get; set; }
        public decimal TotalBruto { get; }
        public decimal TotalDesconto { get; }
        public decimal TotalLiquido { get; }
        public decimal Lucro { get; }
        public string FormaDePagamento { get; set; }
        public bool Ativo { get; set; }
       

        public List<CarrinhoModel> Produtos { get; set; }
        public VendaConsulta()
        {
            Produtos = new List<CarrinhoModel>();
        }
    }
}
