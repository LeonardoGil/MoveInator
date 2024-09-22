using MoveInatorApplication.Models;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IEmpresaService
    {
        Task Add(EmpresaModel model);

        Task Edit(EmpresaModel model);

        Task Remove(Guid empresaId);

        List<EmpresaModel> GetModels();
    }
}
