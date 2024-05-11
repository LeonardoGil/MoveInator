using MoveInatorMaui.ViewModels;
using MoveInatorMaui.ViewModels.Pages;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    protected CadastroEmpresaViewModel ViewModel { get; set; }

    public CadastroEmpresaPage()
    {
        InitializeComponent();

        BindingContext = ViewModel = new CadastroEmpresaViewModel();
    }

    private async void Salvar_Clicked(object sender, EventArgs e)
    {
        //var empresa = new Empresa
        //{
        //    RazaoSocial = ViewModel.RazaoSocial,
        //    Cnpj = ViewModel.Cnpj,
        //    ClientId = ViewModel.ClientId,
        //    ClientSecrect = ViewModel.ClientSecrect
        //};

        ViewModel.ListaEmpresa.Add(ViewModel.Empresa);
        ViewModel.Empresa = new EmpresaViewModel();
    }
}