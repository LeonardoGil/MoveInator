using AutoMapper;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorApplication.Models;
using MoveInatorApplication.Services;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorDomain.Entities.Cadastros;
using MoveInatorDomain.Entities.Outros;
using MoveInatorMaui.ViewModels.Pages;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    private readonly IEmpresaService empresaService;

    protected CadastroEmpresaViewModel ViewModel { get; set; }

    public CadastroEmpresaPage(IEmpresaService _empresaService)
    {
        empresaService = _empresaService;

        BindingContext = ViewModel = new CadastroEmpresaViewModel();

        LoadEmpresas();
        InitializeComponent();
    }

    private void LoadEmpresas()
    {
        ViewModel.ListaEmpresa = empresaService.GetModels().ToObservableCollection();
    }

    private async Task Add(EmpresaModel empresaModel)
    {
        await empresaService.Add(empresaModel);

        ViewModel.ListaEmpresa.Add(empresaModel);
        ViewModel.Empresa = new EmpresaModel();
    }

    private async Task Edit(EmpresaModel empresaModel)
    {
        await empresaService.Edit(empresaModel);

        // Gambeta do BEM
        ViewModel.ListaEmpresa.Remove(empresaModel);
        ViewModel.ListaEmpresa.Add(empresaModel);
        
        ViewModel.Empresa = new EmpresaModel();
    }

    private async Task Remove(EmpresaModel empresaModel)
    {
        await empresaService.Remove(empresaModel.Id);

        ViewModel.ListaEmpresa.Remove(empresaModel);
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

    private async void Save_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (!await Validate())
                return;

            var isNew = !ViewModel.ListaEmpresa.Contains(ViewModel.Empresa);

            if (isNew)
                await Add(ViewModel.Empresa);
            else
                await Edit(ViewModel.Empresa);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async void Delete_Clicked(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is EmpresaModel empresa)
        {
            try
            {
                await Remove(empresa);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro do Erro", ex.Message, "OK");
            }
        }
    }

    private async void Edit_Clicked(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is EmpresaModel empresa)
        {
            try
            {
                ViewModel.Empresa = empresa;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro do Erro", ex.Message, "OK");
            }
        }
    }
}