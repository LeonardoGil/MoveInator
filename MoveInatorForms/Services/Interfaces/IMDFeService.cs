using MoveInatorForms.Domains.Enums;
using MoveInatorForms.Domains.Models;

namespace MoveInatorForms.Services.Interfaces
{
    public interface IMDFeService
    {
        Task<string> GenerateAsync(string path, List<MDFeViewModel> mdfeViews, TipoDocumentoEnum tipoDocumento);
    }
}
