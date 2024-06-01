using CommunityToolkit.Mvvm.ComponentModel;
using MoveInatorApplication.Models;
using System.Collections.ObjectModel;

namespace MoveInatorMaui.ViewModels
{
    public partial class CadastroEmpresaViewModel : ObservableValidator
    {
        [ObservableProperty]
        public EmpresaModel empresa = new();

        [ObservableProperty]
        public ObservableCollection<EmpresaModel> listaEmpresa = new();
    }
}
