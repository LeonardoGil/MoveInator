using AutoMapper;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorDomain.Entities.Cadastros;
using MoveInatorDomain.Entities.Outros;
using MoveInatorMaui.ViewModels.Pages;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    private readonly IMapper mapper;
    private readonly IDatabaseService databaseService;
    private readonly DatabaseJson databaseJson;

    protected CadastroEmpresaViewModel ViewModel { get; set; }

    public CadastroEmpresaPage(IDatabaseService _databaseService, IMapper _mapper)
    {
        mapper = _mapper;
        databaseService = _databaseService;
        databaseJson = databaseService.Load().Result;

        BindingContext = ViewModel = new CadastroEmpresaViewModel();

        LoadEmpresas();
        InitializeComponent();
    }

    private void LoadEmpresas()
    {
        ViewModel.ListaEmpresa = databaseJson.Empresas.Select(empresa => mapper.Map<EmpresaModel>(empresa)).ToObservableCollection();
    }

    private async Task Add(EmpresaModel empresaModel)
    {
        if (await Validate())
        {
            var empresa = mapper.Map<Empresa>(empresaModel);

            databaseJson.Empresas.Add(empresa);

            await databaseService.Save(databaseJson);

            ViewModel.ListaEmpresa.Add(empresaModel);

            ViewModel.Empresa = new EmpresaModel();
        }
    }

    private async Task Remove(EmpresaModel empresaModel)
    {
        var empresa = databaseJson.Empresas.First(x => x.Id == empresaModel.Id);

        databaseJson.Empresas.Remove(empresa);

        await databaseService.Save(databaseJson);

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
            await Add(ViewModel.Empresa);
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
}