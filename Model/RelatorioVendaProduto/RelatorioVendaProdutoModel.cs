using CrudAugustusFashion.Model.Produto;


namespace CrudAugustusFashion.Model.RelatorioVendaProduto
{
    public class RelatorioVendaProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Dinheiro TotalBruto { get; set; }
        public Dinheiro Desconto { get; set; }
        public Dinheiro TotalLiquido { get => TotalBruto.Valor - Desconto.Valor; }
        public Dinheiro TotalCusto { get; set; }
        public Dinheiro LucroReais { get => TotalLiquido.Valor - TotalCusto.Valor; }

        public string LucroPorcentagem
        {
            get
            {
                var result = LucroReais.Valor / TotalCusto.Valor * 100;
                return $"{result.ToString("F")} %";
            }
        }
    }
}

