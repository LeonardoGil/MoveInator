using MoveInatorForms.Domains.Models;

namespace MoveInatorForms.Services.Interfaces
{
    public interface IMDFeService
    {
        string Generate(List<MDFeCTeViewModel> mdfeCtes);
    }
}
