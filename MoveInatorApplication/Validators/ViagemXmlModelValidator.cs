using FluentValidation;
using MoveInatorApplication.Models;

namespace MoveInatorApplication.Validators
{
    public class ViagemXmlModelValidator : AbstractValidator<ViagemXmlModel>
    {
        public ViagemXmlModelValidator()
        {
            RuleFor(viagem => viagem.Numero)
                .NotEqual(0)
                .WithMessage("Numero é Obrigatório!");

            RuleFor(viagem => viagem.Serie)
                .NotEqual(0)
                .WithMessage("Serie é Obrigatório!");

            RuleFor(viagem => viagem.NumeroDocumento)
                .NotEqual(0)
                .WithMessage("Numero Documento é Obrigatório!");

            RuleFor(viagem => viagem.SerieDocumento)
                .NotEqual(0)
                .WithMessage("Serie Documento é Obrigatório!");

            RuleFor(viagem => viagem.DataEmissao)
                .Must(viagem => viagem != default)
                .WithMessage("Data Emissão é Obrigatório!");

            RuleFor(viagem => viagem.Empresa)
                .NotNull()
                .WithMessage("Empresa é Obrigatório!");

            RuleFor(viagem => viagem.Motorista)
                .NotNull()
                .WithMessage("Motorista é Obrigatório!");
        }
    }
}
