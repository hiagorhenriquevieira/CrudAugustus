using FluentValidation;
using System.Linq;

namespace CrudAugustusFashion.Model.Usuario
{
    public class CpfValidation : AbstractValidator<Cpf>
    {
        public CpfValidation()
        {
            RuleFor(x => x.ToString()).NotNull().NotEmpty().WithMessage("Cpf não pode ser nulo ou vazio.");
            RuleFor(x => x.ToString()).Length(11).WithMessage("Cpf deve ter 11 números.");
            RuleFor(x => x.ToString()).Must(ValidarSeNumerosNaoSaoIguais).WithMessage("Cpf não pode ser tudo igual.");
        }

        private bool ValidarSeNumerosNaoSaoIguais(string cpf) =>
            !cpf.All(x => x.Equals(cpf.First()));    
    }
}
