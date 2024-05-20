using MoveInatorDomain.Entities.Outros;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IDatabaseService
    {
        Task Save(DatabaseJson database);

        Task<DatabaseJson> Load();
    }
}
