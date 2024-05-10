using MoveInatorDomain.Entities.Cadastros;
using MoveInatorDomain.Models;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    public CadastroEmpresaViewModel ViewModel { get; set; } = new CadastroEmpresaViewModel();

    public List<CadastroEmpresaViewModel> Empresas { get; set; } = new List<CadastroEmpresaViewModel>();

    public CadastroEmpresaPage()
    {
        InitializeComponent();
        BindingContext = new
        {
            ViewModel,
            Empresas
        };
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

        Empresas.Add(ViewModel);
        ViewModel = new CadastroEmpresaViewModel();
    }
}