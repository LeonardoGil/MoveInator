using MoveInatorApplication.Models;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface ICSVService
    {
        Task<string> GenerateAsync(string path, List<ViagemCsvModel> viagens);
    }
}
