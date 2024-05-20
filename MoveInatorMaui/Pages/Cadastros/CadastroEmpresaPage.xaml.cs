using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorApplication.Models;
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

    private async Task Add(EmpresaModel view)
    {
        if (await Validate())
        {
            ViewModel.ListaEmpresa.Add(view);
            ViewModel.Empresa = new EmpresaModel();
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
            await Toast.Make("Raz�o Social inv�lido!", ToastDuration.Short).Show();
            result = false;
        }

        cnpjEntry.Behaviors.OfType<ValidationBehavior>().ToList().ForEach(x => x.ForceValidate());
        if (cnpjEntry.Behaviors.OfType<ValidationBehavior>().Any(x => x.IsNotValid))
        {
            await Toast.Make("Cnpj inv�lido!", ToastDuration.Short).Show();
            result = false;
        }

        return result;
    }

    private void LoadEmpresas()
    {
        var empresas = MauiProgram.DatabaseJson.Empresas;

        ViewModel.ListaEmpresa = empresas.Select(empresa => new EmpresaModel
        {
            RazaoSocial = empresa.RazaoSocial
        })
        .ToObservableCollection();
    }

    private void Excluir_Clicked(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is EmpresaModel empresa)
        {
            ViewModel.ListaEmpresa.Remove(empresa);
        }
    }
}