using MoveInatorApplication.Models;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IMotoristaService
    {
        Task Add(MotoristaModel model);

        Task Edit(MotoristaModel model);

        Task Remove(Guid motoristaId);

        List<MotoristaModel> GetModels();
    }
}
