using MoveInatorDomain.Models;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface ICSVService
    {
        Task<string> GenerateAsync(string path, List<ViagemViewModel> viagens);
    }
}
