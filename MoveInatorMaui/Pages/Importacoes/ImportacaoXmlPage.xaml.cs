using CommunityToolkit.Maui.Core.Extensions;
using MoveInatorApplication.Services.Interfaces;
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

        InitializeComponent();
        InitializePickers();
    }

    private void InitializePickers()
    {
        ViewModel.ListaMotorista = _motoristaService.GetModels().ToObservableCollection();
        ViewModel.ListaEmpresa = _empresaService.GetModels().ToObservableCollection();
    }

    private void GenerateFile_Clicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}