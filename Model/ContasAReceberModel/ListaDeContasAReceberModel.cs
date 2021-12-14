using CrudAugustusFashion.Enums;
using CrudAugustusFashion.Model.Produto;
using System;
using System.ComponentModel;

namespace CrudAugustusFashion.Model.ContasAReceberModel
{
    public class ListaDeContasAReceberModel
    {
        public int IdVenda { get; set; }
        public string NomeCompleto { get; set; }
        
        public Dinheiro ValorAPagar { get; set; }
        public EFormaDePagamento FormaDePagamento { get; set; }
        [Browsable (false)]
        public string FormaPagamento { get; set; }
        public DateTime DataEmissao { get; set; }
        public bool Ativo { get; set; }

    }
}
