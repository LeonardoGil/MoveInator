using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using FluentValidation;
using MoveInatorApplication.Models;
using MoveInatorApplication.Services.Interfaces;
using MoveInatorApplication.Validators;
using MoveInatorMaui.ViewModels;

namespace MoveInatorMaui.Pages.Cadastros;

public partial class CadastroMotoristaPage : ContentPage
{
	private readonly IMotoristaService _motoristaServices;

    protected CadastroMotoristaViewModel ViewModel { get; set; }

    public CadastroMotoristaPage(IMotoristaService motoristaServices)
    {
        _motoristaServices = motoristaServices;

        BindingContext = ViewModel = new CadastroMotoristaViewModel();

        InitializeComponent();
    }
    
    private async Task Add(MotoristaModel motoristaModel)
    {
        await _motoristaServices.Add(motoristaModel);

        ViewModel.ListaMotorista.Add(motoristaModel);
        ViewModel.Motorista = new MotoristaModel();
    }

    private async Task Edit(MotoristaModel motoristaModel)
    {
        await _motoristaServices.Edit(motoristaModel);

        // Gambeta do BEM
        ViewModel.ListaMotorista.Remove(motoristaModel);
        ViewModel.ListaMotorista.Add(motoristaModel);

        ViewModel.Motorista = new MotoristaModel();
    }

    private async Task Remove(MotoristaModel motoristaModel)
    {
        await _motoristaServices.Remove(motoristaModel.Id);

        ViewModel.ListaMotorista.Remove(motoristaModel);
    }

    private async Task<bool> Validate()
    {
        var validator = new MotoristaModelValidator().Validate(ViewModel.Motorista);

        foreach (var erro in validator.Errors)
            await Toast.Make(erro.ErrorMessage, ToastDuration.Short).Show();

        return validator.IsValid;
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (!await Validate())
                return;

            var isNew = !ViewModel.ListaMotorista.Contains(ViewModel.Motorista);

            if (isNew)
                await Add(ViewModel.Motorista);
            else
                await Edit(ViewModel.Motorista);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro do Erro", ex.Message, "OK");
        }
    }

    private async void Delete_Clicked(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is MotoristaModel motorista)
        {
            try
            {
                await Remove(motorista);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro do Erro", ex.Message, "OK");
            }
        }
    }

    private async void Edit_Clicked(object sender, EventArgs e)
    {
        if (sender is View view && view.BindingContext is MotoristaModel motorista)
        {
            try
            {
                ViewModel.Motorista = motorista;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro do Erro", ex.Message, "OK");
            }
        }
    }
}