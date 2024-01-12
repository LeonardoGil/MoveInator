using MoveInatorForms.Domains.Entities.Cadastros;
using System.Text;
using System.Text.Json;

namespace MoveInatorForms.Domains.Entities.Outros
{
    public class DatabaseJson
    {
        public List<Empresa> Empresas { get; set; } = new List<Empresa>();

        public List<Motorista> Motoristas { get; set; } = new List<Motorista>();

        public async Task Save()
        {
            try
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), nameof(DatabaseJson) + ".json");

                if (File.Exists(filePath))
                    File.Delete(filePath);

                var content = JsonSerializer.Serialize(Program.DatabaseJson);

                using (var file = File.Create(filePath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(content);
                    file.Write(info, 0, info.Length);
                }
            }
            catch (UnauthorizedAccessException)
            {
                throw;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task Load()
        {
            try
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), nameof(DatabaseJson) + ".json");

                if (!File.Exists(filePath))
                    throw new Exception();

                var database = JsonSerializer.Deserialize<DatabaseJson>(File.ReadAllText(filePath));

                Empresas = database.Empresas;
                Motoristas = database.Motoristas;
            }
            catch (UnauthorizedAccessException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
