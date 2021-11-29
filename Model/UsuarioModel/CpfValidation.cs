using FluentValidation;
using System.Linq;

namespace CrudAugustusFashion.Model.Usuario
{
    public class CpfValidation : AbstractValidator<Cpf>
    {

        public CpfValidation()
        {
            RuleFor(x => x.ToString()).Length(14).WithMessage("Cpf deve ter 11 números.");
            RuleFor(x => x.RemoverFormatacao()).Must(ValidarSeNumerosNaoSaoIguais).WithMessage("Cpf não pode ser tudo igual.");
            
        }

        private bool ValidarSeNumerosNaoSaoIguais(string cpf)
        {
             return !cpf.All(x => x.Equals(cpf.First()));
        }
    }
}
