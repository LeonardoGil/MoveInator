using FluentValidation;

namespace MoveInatorDomain.Models
{
    public class CadastroEmpresaViewModel
    {
        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }

        public string ClientId { get; set; }

        public string ClientSecrect { get; set; }

        public Guid? AmbienteId { get; set; }
    }

    public class CadastroEmpresaViewModelValidator : AbstractValidator<CadastroEmpresaViewModel>
    {
        public CadastroEmpresaViewModelValidator()
        {
            RuleFor(x => x.RazaoSocial)
                .NotEmpty()
                .WithMessage("Razão Social é Obrigatório!");

            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .WithMessage("CNPJ é Obrigatório!")
                .Length(11)
                .WithMessage("CNPJ precisa conter 11 digitos!");
        }
    }
}
