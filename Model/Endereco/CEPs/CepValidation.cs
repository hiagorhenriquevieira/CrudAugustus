using FluentValidation;
using System;
using System.Linq;

namespace CrudAugustusFashion.Model.Endereco.CEPs
{
    public class CepValidation : AbstractValidator<Cep>
    {
        public CepValidation()
        {
            RuleFor(x => x.ToString()).NotNull().NotEmpty().WithMessage("CEP não pode ser nulo ou vazio!");
            RuleFor(x => x.ToString()).Length(9).WithMessage("CEP deve ter 8 números!");
            RuleFor(x => x.RemoverFormatacao()).Must(
                ValidarSeNaoContemNumerosIguais).WithMessage("CEP não pode conter todos numeros iguais");
            //RuleFor(x => x.ToString()).Matches(@"^[0-9]$").WithMessage("Cep deve conter apenas números!");
        }

        private bool ValidarSeNaoContemNumerosIguais(string cep)
        {
            return !cep.All(x => x.Equals(cep.First()));
        }
    }

}
