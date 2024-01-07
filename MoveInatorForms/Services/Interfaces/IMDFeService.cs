using MoveInatorForms.Domains.Models;

namespace MoveInatorForms.Services.Interfaces
{
    public interface IMDFeService
    {
        Task<string> GenerateAsync(string path, List<MDFeCTeViewModel> mdfeCtes);
    }
}
