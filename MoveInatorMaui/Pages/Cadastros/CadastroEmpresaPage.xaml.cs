using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorMaui.ViewModels;
using MoveInatorMaui.ViewModels.Pages;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    protected CadastroEmpresaViewModel ViewModel { get; set; }

    public CadastroEmpresaPage()
    {
        BindingContext = ViewModel = new CadastroEmpresaViewModel();

        LoadEmpresas();
        InitializeComponent();
    }

    private async Task Add(EmpresaViewModel view)
    {
        if (await Validate())
        {
            ViewModel.ListaEmpresa.Add(view);
            ViewModel.Empresa = new EmpresaViewModel();
        }
    }

    private async void Salvar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Add(ViewModel.Empresa);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async Task<bool> Validate()
    {
        var result = true;

        razaoSocialEntry.Behaviors.OfType<ValidationBehavior>().ToList().ForEach(x => x.ForceValidate());
        if (razaoSocialEntry.Behaviors.OfType<ValidationBehavior>().Any(x => x.IsNotValid))
        {
            await Toast.Make("Razão Social inválido!", ToastDuration.Short).Show();
            result = false;
        }

        cnpjEntry.Behaviors.OfType<ValidationBehavior>().ToList().ForEach(x => x.ForceValidate());
        if (cnpjEntry.Behaviors.OfType<ValidationBehavior>().Any(x => x.IsNotValid))
        {
            await Toast.Make("Cnpj inválido!", ToastDuration.Short).Show();
            result = false;
        }

        return result;
    }

    private void LoadEmpresas()
    {
        var empresas = MauiProgram.DatabaseJson.Empresas;

        ViewModel.ListaEmpresa = empresas.Select(empresa => new EmpresaViewModel
        {
            RazaoSocial = empresa.RazaoSocial
        })
        .ToObservableCollection();
    }

    private void Excluir_Clicked(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is EmpresaViewModel empresa)
        {
            ViewModel.ListaEmpresa.Remove(empresa);
        }
    }
}