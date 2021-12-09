using CrudAugustusFashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model.RelatorioVendaProduto
{
    public class RelatorioVendaProdutoViewModel
    {
        public RelatorioVendaProdutoViewModel()
        {
            Relatorio = new List<RelatorioVendaProdutoModel>();
        }
        public List<RelatorioVendaProdutoModel> Relatorio { get; set; }
        
        public Dinheiro TotalBruto { get => Relatorio.Sum(x => x.TotalBruto.Valor); }
        public Dinheiro TotalCusto { get => Relatorio.Sum(x => x.TotalCusto.Valor); }
        public Dinheiro TotalDesconto { get => Relatorio.Sum(x => x.Desconto.Valor); }
        public Dinheiro TotalLiquido { get => Relatorio.Sum(x => x.TotalLiquido.Valor); }
        public Dinheiro LucroReais { get => Relatorio.Sum(x => x.LucroReais.Valor); }
    }
}
