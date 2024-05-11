using CommunityToolkit.Mvvm.ComponentModel;

namespace MoveInatorMaui.ViewModels
{
    public partial class EmpresaViewModel : BaseViewModel
    {
        [ObservableProperty]
        public string razaoSocial;

        [ObservableProperty]
        public string cnpj;

        [ObservableProperty]
        public string clientId;
        
        [ObservableProperty]
        public string clientSecrect;

        [ObservableProperty]
        public Guid? ambienteId;
    }
}
