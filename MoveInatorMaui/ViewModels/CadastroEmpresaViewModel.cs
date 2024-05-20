using CommunityToolkit.Mvvm.ComponentModel;
using FluentValidation;
using MoveInatorApplication.Models;
using System.Collections.ObjectModel;

namespace MoveInatorMaui.ViewModels.Pages
{
    public partial class CadastroEmpresaViewModel : ObservableValidator
    {
        [ObservableProperty]
        public EmpresaModel empresa = new();

        [ObservableProperty]
        public ObservableCollection<EmpresaModel> listaEmpresa = new();
    }

    public class CadastroEmpresaModelValidator : AbstractValidator<EmpresaModel>
    {
        public CadastroEmpresaModelValidator()
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
