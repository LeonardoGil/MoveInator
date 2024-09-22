using CommunityToolkit.Mvvm.ComponentModel;
using MoveInatorApplication.Models;
using System.Collections.ObjectModel;

namespace MoveInatorMaui.ViewModels
{
    public partial class ImportacaoXmlViewModel : ObservableValidator
    {
        [ObservableProperty]
        public ObservableCollection<EmpresaModel> listaEmpresa = new();

        [ObservableProperty]
        public ObservableCollection<MotoristaModel> listaMotorista = new();

        [ObservableProperty]
        public ObservableCollection<ViagemXmlModel> listaViagem= new();

        [ObservableProperty]
        public ViagemXmlModel viagem = new();

        [ObservableProperty]
        public string diretorio = @"C:\Temp";
    }
}
