using MoveInatorDomain.Entities.Outros;

namespace MoveInatorApplication.Services.Interfaces
{
    public interface IDatabaseService
    {
        DatabaseJson Database { get; set; }

        Task Save();

        Task<DatabaseJson> Load();
    }
}
