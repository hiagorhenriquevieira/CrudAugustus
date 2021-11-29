using System;
using System.Linq;

using FluentValidation.Results;

namespace CrudAugustusFashion.Model.Produto
{
    public class Dinheiro
    {
        private decimal _dinheiro;

        public Dinheiro(decimal dinheiro)
        {
            _dinheiro = dinheiro;
        }

        public Dinheiro(string dinheiro)
        {

        }

        public decimal Valor { get => _dinheiro; }

        public string DinheiroFormatado { get => (_dinheiro).ToString(@"c"); }

        public override string ToString()
        {
            return _dinheiro.ToString();
        }

        public static implicit operator Dinheiro(decimal dinheiro) => new Dinheiro(dinheiro);
        public static implicit operator Dinheiro(string dinheiro) => new Dinheiro(dinheiro);
    }
}
