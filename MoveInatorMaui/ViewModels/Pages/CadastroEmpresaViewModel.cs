using CommunityToolkit.Mvvm.ComponentModel;
using FluentValidation;
using System.Collections.ObjectModel;

namespace MoveInatorMaui.ViewModels.Pages
{
    public partial class CadastroEmpresaViewModel : ObservableValidator
    {
        [ObservableProperty]
        public EmpresaViewModel empresa = new();

        [ObservableProperty]
        public ObservableCollection<EmpresaViewModel> listaEmpresa = new ObservableCollection<EmpresaViewModel>();
    }

    public class CadastroEmpresaViewModelValidator : AbstractValidator<EmpresaViewModel>
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
