using FluentValidation;

namespace CrudAugustusFashion.Model.Produto
{
    internal class DinheiroValidation : AbstractValidator<Dinheiro>
    {
        public DinheiroValidation()
        {
            RuleFor(x => x.ToString()).Length(10).WithMessage("Valor é superior ao limite");
        }
    }
}