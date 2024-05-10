namespace MoveInatorApplication.Services.Interfaces
{
    public interface IFileService
    {
        Task GenerateFileAsync(string pathFile, string content);
    }
}
