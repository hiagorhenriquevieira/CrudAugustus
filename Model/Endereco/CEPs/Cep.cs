using FluentValidation.Results;
using System;
using System.Linq;

namespace CrudAugustusFashion.Model.Endereco.CEPs
{
    public class Cep
    {
        private string _valor;

        public string RetornarComFormatacao
        {
            get => Convert.ToUInt32(_valor).ToString(@"00000-000");
        }

        public Cep(string valor)
        {
            _valor = valor;
        }

        public ValidationResult Validar()
        {
            return new CepValidation().Validate(this);
        }

        public string RemoverFormatacao()
        {
            string cepSemFormatacao = _valor;

            cepSemFormatacao = new string((from c in cepSemFormatacao
                                                   where char.IsDigit(c)
                                                   select c).ToArray());

            return cepSemFormatacao;
        }

        public override string ToString()
        {
            return _valor;
        }

        public static implicit operator Cep(string valor) => new Cep(valor);
    }
}
