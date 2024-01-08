namespace MoveInatorForms.Services.Interfaces
{
    public interface IFileService
    {
        Task GenerateFileAsync(string pathFile, string content);
    }
}
