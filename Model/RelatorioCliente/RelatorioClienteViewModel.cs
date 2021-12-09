using CrudAugustusFashion.Model.Produto;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Model.RelatorioCliente
{
    class RelatorioClienteViewModel
    {
        public RelatorioClienteViewModel()
        {
            Relatorio = new List<RelatorioClienteModel>();
        }
        public List<RelatorioClienteModel> Relatorio { get; set; }
        public int QuantidadeVendas { get => Relatorio.Sum(x => x.QuantidadeVendas); }
        public Dinheiro TotalBruto { get => Relatorio.Sum(x => x.TotalBruto.Valor); }
        public Dinheiro TotalDesconto { get => Relatorio.Sum(x => x.TotalDesconto.Valor); }
        public Dinheiro TotalLiquido { get => Relatorio.Sum(x => x.TotalLiquido.Valor); }
    }
}
