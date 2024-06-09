using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorApplication.Validators;
using MoveInatorMaui.ViewModels;
using System.Collections.Specialized;

namespace MoveInatorMaui.Pages.Importacoes;

public partial class ImportacaoXmlPage : ContentPage
{
    private readonly IMotoristaService _motoristaService;
    private readonly IEmpresaService _empresaService;
    private readonly IXmlService _xmlService;


    protected ImportacaoXmlViewModel ViewModel { get; set; } = new ImportacaoXmlViewModel();

    public ImportacaoXmlPage(IMotoristaService motoristaService,
                             IEmpresaService empresaService,
                             IXmlService xmlService)
    {
        _motoristaService = motoristaService;
        _empresaService = empresaService;
        _xmlService = xmlService;

        Initialize();
        InitializeComponent();
    }

    private void Initialize()
    {
        ViewModel.ListaViagem.CollectionChanged += ListaViagem_Changed;

        BindingContext = ViewModel;

        Loaded += Page_Loaded;
    }

    private void LoadPickers()
    {
        ViewModel.ListaMotorista = _motoristaService.GetModels().ToObservableCollection();
        ViewModel.ListaEmpresa = _empresaService.GetModels().ToObservableCollection();
    }

    private void EnabledFields(bool enabled = true)
    {
        numeroMDFeEntry.IsEnabled =
        serieMDFeEntry.IsEnabled =
        emissorPicker.IsEnabled =
        motoristaPicker.IsEnabled =
        dataEmissaoEntry.IsEnabled =

            enabled;
    }

    private async Task<bool> Validate(ViagemXmlModel viagem)
    {
        var validator = new ViagemXmlModelValidator().Validate(viagem);

        var message = string.Join(Environment.NewLine, validator.Errors);

        await Toast.Make(message, ToastDuration.Short).Show();

        return validator.IsValid;
    }

    private async void Page_Loaded(object sender, EventArgs e)
    {
        LoadPickers();
    }

    private async void RemoveViagem_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (sender is ViagemXmlModel viagem)
                ViewModel.ListaViagem.Remove(viagem);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        try
        {
            var viagem = ViewModel.Viagem;

            if (!await Validate(viagem))
                return;

            ViewModel.ListaViagem.Add(viagem);
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

    private async void ListaViagem_Changed(object sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems is not null && e.NewItems.Count > 0)
        {
            EnabledFields(false);
        }
        else
        {
            EnabledFields();
        }
    }
}