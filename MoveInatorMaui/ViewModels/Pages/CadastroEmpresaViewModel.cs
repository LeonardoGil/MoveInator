using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MoveInatorMaui.ViewModels.Pages
{
    public partial class CadastroEmpresaViewModel : BaseViewModel
    {
        [ObservableProperty]
        public EmpresaViewModel empresa = new EmpresaViewModel();

        [ObservableProperty]
        public ObservableCollection<EmpresaViewModel> listaEmpresa = new ObservableCollection<EmpresaViewModel>();
    }

    //public class CadastroEmpresaViewModelValidator : AbstractValidator<CadastroEmpresaViewModel>
    //{
    //    public CadastroEmpresaViewModelValidator()
    //    {
    //        RuleFor(x => x.RazaoSocial)
    //            .NotEmpty()
    //            .WithMessage("Razão Social é Obrigatório!");

    //        RuleFor(x => x.Cnpj)
    //            .NotEmpty()
    //            .WithMessage("CNPJ é Obrigatório!")
    //            .Length(11)
    //            .WithMessage("CNPJ precisa conter 11 digitos!");
    //    }
    //}
}
