using MoveInatorApplication.Models;
using MoveInatorDomain.Enums;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IMDFeService
    {
        Task<string> GenerateAsync(string path, List<ViagemXmlModel> mdfeViews, TipoDocumentoEnum tipoDocumento);
    }
}
