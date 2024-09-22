using MoveInatorApplication.Models;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IXmlService
    {
        Task<string> GenerateAsync(string path, List<ViagemXmlModel> mdfeViews);
    }
}
