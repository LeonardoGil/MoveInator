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
        ViewModel.ListaEmpresa = databaseJson.Empresas.Select(empresa => new EmpresaModel { RazaoSocial = empresa.RazaoSocial }).ToObservableCollection();
    }

    private async Task Add()
    {
        if (await Validate())
        {
            var empresa = mapper.Map<Empresa>(ViewModel.Empresa);

            databaseJson.Empresas.Add(empresa);

            await databaseService.Save(databaseJson);

            ViewModel.ListaEmpresa.Add(ViewModel.Empresa);

            ViewModel.Empresa = new EmpresaModel();
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

    private async void Save_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Add();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async void Delete_Clicked(object sender, EventArgs e)
    {
        await Task.Run(() =>
        {
            if (sender is View view && view.BindingContext is EmpresaModel empresa)
            {
                ViewModel.ListaEmpresa.Remove(empresa);
            }
        });
    }
}