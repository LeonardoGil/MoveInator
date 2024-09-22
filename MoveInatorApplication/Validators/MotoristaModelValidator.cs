using FluentValidation;
using MoveInatorApplication.Models;

namespace MoveInatorApplication.Validators
{
    public class MotoristaModelValidator : AbstractValidator<MotoristaModel>
    {
        public MotoristaModelValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Nome é Obrigatório!");

            RuleFor(x => x.Cpf)
                .NotEmpty()
                .WithMessage("CPF é Obrigatório!")
                .Length(11)
                .WithMessage("CPF precisa conter 11 digitos!");
        }
    }
}
