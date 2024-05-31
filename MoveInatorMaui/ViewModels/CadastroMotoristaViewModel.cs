using CommunityToolkit.Mvvm.ComponentModel;
using MoveInatorApplication.Models;
using System.Collections.ObjectModel;

namespace MoveInatorMaui.ViewModels
{
    public partial class CadastroMotoristaViewModel : ObservableValidator
    {
        [ObservableProperty]
        public MotoristaModel motorista = new();

        [ObservableProperty]
        public ObservableCollection<MotoristaModel> listaMotorista = new();
    }
}
