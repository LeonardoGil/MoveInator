using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using MoveInatorMaui.ViewModels;
using MoveInatorMaui.ViewModels.Pages;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    protected CadastroEmpresaViewModel ViewModel { get; set; }

    public CadastroEmpresaPage()
    {
        BindingContext = ViewModel = new CadastroEmpresaViewModel();
        
        InitializeComponent();
    }

    /// <summary>
    /// Testes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Salvar_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (await Validate())
            {
                ViewModel.ListaEmpresa.Add(ViewModel.Empresa);
                ViewModel.Empresa = new EmpresaViewModel();
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async Task<bool> Validate()
    {
        var result = true;

        if (razaoSocialEntry.Behaviors.OfType<ValidationBehavior>().Any(x => x.IsNotValid))
        {
            await Toast.Make("Razão Social inválido!", ToastDuration.Short).Show();
            result = false;
        }

        if (cnpjEntry.Behaviors.OfType<ValidationBehavior>().Any(x => x.IsNotValid))
        {
            await Toast.Make("Cnpj inválido!", ToastDuration.Short).Show();
            result = false;
        }

        return result;
    }
}