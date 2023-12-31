using MoveInatorForms.Models;

namespace MoveInatorForms.Services.Interfaces
{
    public interface ICSVService
    {
        string Generate(List<ViagemViewModel> viagens);
    }
}
