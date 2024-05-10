using MoveInatorApplication.Services.Interfaces;
using System.Text;

namespace MoveInatorApplication.Services
{
    public class FileService : IFileService
    {
        public async Task GenerateFileAsync(string pathFile, string content)
        {
            using (var file = File.Create(pathFile))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(content);
                file.Write(info, 0, info.Length);
            }
        }
    }
}
