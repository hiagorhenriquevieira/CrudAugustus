﻿using CrudAugustusFashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model.RelatorioVendaProduto
{
    public class RelatorioVendaProdutoModel
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public Dinheiro TotalBruto { get; set; }
        public Dinheiro Desconto  { get; set; }
        public Dinheiro TotalLiquido { get; set; }
        public Dinheiro TotalCusto { get; set; }
        public Dinheiro LucroReais { get; set; }
        public decimal LucroPorcentagem { get; set; }
        
    }
}