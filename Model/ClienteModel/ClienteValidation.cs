using CrudAugustusFashion.Model.Usuario;
using FluentValidation;

namespace CrudAugustusFashion.Model.Cliente
{
    public class ClienteValidation : AbstractValidator<ClienteModel>
    {
        public ClienteValidation()
        {
            RuleFor(x => x).SetValidator(new UsuarioValidation());
            
        }
    }
}
