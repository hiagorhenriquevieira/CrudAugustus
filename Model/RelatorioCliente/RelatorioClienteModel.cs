using CrudAugustusFashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model.RelatorioCliente
{
    public class RelatorioClienteModel
    {
        //public int IdCliente { get; set; }
        public string Nome { get; set; }
        public int QuantidadeVendas { get; set; }
        public Dinheiro TotalBruto { get; set; }
        public Dinheiro Desconto { get; set; }
        public Dinheiro TotalLiquido { get; set; }
    }
}
