using CrudAugustusFashion.Model.Endereco.CEPs;
using FluentValidation;

namespace CrudAugustusFashion.Model.Endereco
{
    class EnderecoValidation : AbstractValidator<EnderecoModel>
    {
        public EnderecoValidation()
        {
            RuleFor(x => x.Cep).SetValidator(new CepValidation());
        }
    }
}
