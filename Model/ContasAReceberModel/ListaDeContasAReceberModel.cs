using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.Usuario;
using System;

namespace CrudAugustusFashion.Model.ContasAReceberModel
{
    public class ListaDeContasAReceberModel
    {
        public int IdVenda { get; set; }
        public string NomeCompleto { get; set; }
        
        public Dinheiro ValorAPagar { get; set; }
        public string FormaDePagamento { get; set; }
        public DateTime DataEmissao { get; set; }
        public bool Ativo { get; set; }

    }
}
