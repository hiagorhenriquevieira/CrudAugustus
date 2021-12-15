using CrudAugustusFashion.Enums;
using CrudAugustusFashion.Model.Produto;
using System;
using System.ComponentModel;

namespace CrudAugustusFashion.Model.ContasAReceberModel
{
    public class ListaDeContasAReceberModel
    {
        [DisplayName ("Código venda")]
        public int IdVenda { get; set; }

        [DisplayName ("Nome")]
        public string NomeCompleto { get; set; }
        
        [DisplayName ("Valor a ser pago")]
        public Dinheiro ValorAPagar { get; set; }
        [DisplayName ("Forma de pagamento")]
        public EFormaDePagamento FormaDePagamento { get; set; }
        [Browsable (false)]
        public string FormaPagamento { get; set; }
        [DisplayName ("Data de emissão")]
        public DateTime DataEmissao { get; set; }
        [DisplayName ("Data de pagamento")]
        public DateTime DataPagamento { get; set; }
        
        [Browsable (false)]
        public bool Ativo { get; set; }


        
    }
}
