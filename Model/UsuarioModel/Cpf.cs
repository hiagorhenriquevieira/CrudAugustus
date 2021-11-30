using FluentValidation.Results;
using System.Linq;

namespace CrudAugustusFashion.Model.Usuario
{
    public class Cpf
    {
        private string _valor;
       
        public Cpf(string valor)
        {
            _valor = valor;
        }

        public ValidationResult Validar()
        {
            return new CpfValidation().Validate(this);
        }

        public string RemoverFormatacao()
        {
            string cpfSemFormatacao = _valor;

            cpfSemFormatacao = new string((from c in cpfSemFormatacao
                                           where char.IsDigit(c)
                                           select c).ToArray());

            return cpfSemFormatacao;
        }

        public override string ToString()
        {
            return _valor;
        }

        public static implicit operator Cpf(string valor) => new Cpf(valor);
    }
}
