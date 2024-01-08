using MoveInatorForms.Domains.Models;

namespace MoveInatorForms.Services.Interfaces
{
    public interface ICSVService
    {
        Task<string> GenerateAsync(string path, List<ViagemViewModel> viagens);
    }
}
