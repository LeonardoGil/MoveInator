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
    }
}
