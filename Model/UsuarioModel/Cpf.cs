using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model.Usuario
{
    public class Cpf
    {
        private string _valor;

        public string RetornarValor { get => _valor; }
        public string RetornarComFormatacao { get => Convert.ToInt64(_valor).ToString(@"000.000.000-00");  }

        public Cpf(string valor)
        {
            _valor = valor;
        }

        public ValidationResult Validar()
        {
            return new CpfValidation().Validate(this);
        }

        public override string ToString()
        {
            return _valor;
        }

        public static implicit operator Cpf(string valor) => new Cpf(valor);


        public string RemoverFormatacao()
        {
            string cpfSemFormatacao = _valor;

            cpfSemFormatacao = new string((from c in cpfSemFormatacao
                                           where char.IsDigit(c)
                                           select c).ToArray());

            return cpfSemFormatacao;
        }
    }
}
