using CommunityToolkit.Maui.Behaviors;
using MoveInatorMaui.ViewModels;
using MoveInatorMaui.ViewModels.Pages;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroEmpresaPage : ContentPage
{
    protected CadastroEmpresaViewModel ViewModel { get; set; }

    public CadastroEmpresaPage()
    {
        InitializeComponent();

        var validStyle = new Style(typeof(Entry));
        validStyle.Setters.Add(new Setter
        {
            Property = Entry.TextColorProperty,
            Value = Colors.Green
        });

        var invalidStyle = new Style(typeof(Entry));
        invalidStyle.Setters.Add(new Setter
        {
            Property = Entry.TextColorProperty,
            Value = Colors.Red
        });

        var atLeastEightCharacters = new CharactersValidationBehavior
        {
            Flags = ValidationFlags.ValidateOnValueChanged,
            CharacterType = CharacterType.Any,
            MinimumLength = 8
        };

        MultiValidationBehavior.SetError(atLeastEightCharacters, "8 characters");

        var multiValidationBehavior = new MultiValidationBehavior
        {
            InvalidStyle = invalidStyle,
            ValidStyle = validStyle,
            Flags = ValidationFlags.ValidateOnValueChanged,

            Children =
            {
                atLeastEightCharacters
            }
        };

        razaoSocialEntry.Behaviors.Add(multiValidationBehavior);

        BindingContext = ViewModel = new CadastroEmpresaViewModel();
    }

    private async void Salvar_Clicked(object sender, EventArgs e)
    {

        ViewModel.ListaEmpresa.Add(ViewModel.Empresa);
        ViewModel.Empresa = new EmpresaViewModel();
    }
}