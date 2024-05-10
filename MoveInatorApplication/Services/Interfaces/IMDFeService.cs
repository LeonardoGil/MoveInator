using MoveInatorDomain.Enums;
using MoveInatorDomain.Models;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IMDFeService
    {
        Task<string> GenerateAsync(string path, List<MDFeViewModel> mdfeViews, TipoDocumentoEnum tipoDocumento);
    }
}
