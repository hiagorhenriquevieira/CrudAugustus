using CrudAugustusFashion.Model.Produto;

namespace CrudAugustusFashion.Model.RelatorioCliente
{
    public class RelatorioClienteModel
    {
        //public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int QuantidadeVendas { get; set; }
        public Dinheiro TotalBruto { get; set; }
        public Dinheiro TotalDesconto { get; set; }
        public Dinheiro TotalLiquido { get; set; }

    }
}
