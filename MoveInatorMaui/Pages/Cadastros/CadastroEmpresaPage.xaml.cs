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
        InitializeComponent();

        BindingContext = ViewModel = new CadastroEmpresaViewModel();
    }

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

        var razaoSocialTextValidation = razaoSocialEntry.Behaviors.OfType<TextValidationBehavior>().FirstOrDefault();

        if (razaoSocialTextValidation is not default(TextValidationBehavior) && razaoSocialTextValidation.IsNotValid)
        {
            var cancellationToken = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            var toast = Toast.Make("Razão Social inválido!", ToastDuration.Short);

            await toast.Show(cancellationToken.Token);

            result = false;
        }

        return result;
    }
}