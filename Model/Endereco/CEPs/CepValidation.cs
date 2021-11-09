using FluentValidation;

namespace CrudAugustusFashion.Model.Endereco.CEPs
{
    public class CepValidation : AbstractValidator<Cep>
    {
        public CepValidation()
        {
            RuleFor(x => x.ToString()).NotNull().NotEmpty().WithMessage("CEP não pode ser nulo ou vazio!");
            RuleFor(x => x.ToString()).Length(9).WithMessage("Cep deve ter 8 números!");
            //RuleFor(x => x.ToString()).Matches(@"^[0-9]$").WithMessage("Cep deve conter apenas números!");
        }
    }

}
