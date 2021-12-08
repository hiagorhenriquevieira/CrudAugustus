using System;

namespace CrudAugustusFashion.Model.Produto
{
    public class Dinheiro
    {
        private decimal _dinheiro;

        public Dinheiro(decimal dinheiro)
        {
            _dinheiro = dinheiro;
        }

        internal Dinheiro Sum(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public Dinheiro(string dinheiro)
        {

        }

        public decimal Valor { get => _dinheiro; }

        public string DinheiroFormatado { get => (_dinheiro).ToString("c"); }

        public override string ToString()
        {
            return _dinheiro.ToString("c");
        }

        public static implicit operator Dinheiro(decimal dinheiro) => new Dinheiro(dinheiro);
        public static implicit operator Dinheiro(string dinheiro) => new Dinheiro(dinheiro);
    }
}
