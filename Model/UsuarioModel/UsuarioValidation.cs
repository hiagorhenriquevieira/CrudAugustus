using CrudAugustusFashion.Model.Endereco;
using FluentValidation;

namespace CrudAugustusFashion.Model.Usuario
{
   public class UsuarioValidation : AbstractValidator<UsuarioModel>
    {
        public UsuarioValidation()
        {
            RuleFor(x => x.Endereco).SetValidator(new EnderecoValidation());
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email é invalido");
        }
    }
}
