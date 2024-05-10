using MoveInatorDomain.Models;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
	public CadastroEmpresaViewModel ViewModel { get; set; } = new CadastroEmpresaViewModel();

    public CadastroEmpresaPage()
	{
		InitializeComponent();
		BindingContext = ViewModel;
	}
}