using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoveInatorMaui.ViewModels
{
    public partial class EmpresaViewModel : ObservableValidator
    {
        [MinLength(5, ErrorMessage = "Text length is minimum 5!")]
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
