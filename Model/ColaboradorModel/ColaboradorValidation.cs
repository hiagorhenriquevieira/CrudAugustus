using CrudAugustusFashion.Model.Usuario;
using FluentValidation;

namespace CrudAugustusFashion.Model
{
    internal class ColaboradorValidation : AbstractValidator<ColaboradorModel>
    {
        public ColaboradorValidation()
        {
            RuleFor(x => x).SetValidator(new UsuarioValidation());
        }
    }
}