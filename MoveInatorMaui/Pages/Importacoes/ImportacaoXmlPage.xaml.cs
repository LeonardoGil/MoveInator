using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorApplication.Validators;
using MoveInatorMaui.ViewModels;

namespace MoveInatorMaui.Pages.Importacoes;

public partial class ImportacaoXmlPage : ContentPage
{
    private readonly IMotoristaService _motoristaService;
    private readonly IEmpresaService _empresaService;

    protected ImportacaoXmlViewModel ViewModel { get; set; } = new ImportacaoXmlViewModel();

    public ImportacaoXmlPage(IMotoristaService motoristaService, 
                             IEmpresaService empresaService)
    {
        _motoristaService = motoristaService;
        _empresaService = empresaService;

        BindingContext = ViewModel;

        Loaded += Page_Loaded;

        InitializeComponent();
    }

    private void InitializePickers()
    {
        ViewModel.ListaMotorista = _motoristaService.GetModels().ToObservableCollection();
        ViewModel.ListaEmpresa = _empresaService.GetModels().ToObservableCollection();
    }

    private async Task<bool> Validate()
    {
        var validator = new ViagemXmlModelValidator().Validate(ViewModel.Viagem);

        foreach (var erro in validator.Errors)
            await Toast.Make(erro.ErrorMessage, ToastDuration.Short).Show();

        return validator.IsValid;
    }

    private async void Page_Loaded(object sender, EventArgs e)
    {
        InitializePickers();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (!await Validate())
                return;


        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async void GenerateFile_Clicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}