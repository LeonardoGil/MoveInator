using MoveInatorForms.Domains.Models;

namespace MoveInatorForms.Services.Interfaces
{
    public interface IMDFeService
    {
        string Generate(string path, List<MDFeCTeViewModel> mdfeCtes);
    }
}
