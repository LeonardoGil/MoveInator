using FluentValidation;
using MoveInatorApplication.Models;

namespace MoveInatorApplication.Validators
{
    public class EmpresaModelValidator : AbstractValidator<EmpresaModel>
    {
        public EmpresaModelValidator()
        {
            RuleFor(x => x.RazaoSocial)
                .NotEmpty()
                .WithMessage("Razão Social é Obrigatório!");

            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .WithMessage("CNPJ é Obrigatório!")
                .Length(11)
                .WithMessage("CNPJ precisa conter 14 digitos!");
        }
    }
}
