using MoveInatorDomain.Entities.Cadastros;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.Text.Json;

namespace MoveInatorDomain.Entities.Outros
{
    public class DatabaseJson
    {
        public bool Atualizado { get; private set; }

        public ObservableCollection<Empresa> Empresas { get; set; } = new ObservableCollection<Empresa>();

        public ObservableCollection<Motorista> Motoristas { get; set; } = new ObservableCollection<Motorista>();

        public ObservableCollection<Uri> Urls { get; set; } = new ObservableCollection<Uri>();

        public DatabaseJson()
        {
            AddCollectionChangeEvent();
        }

        private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs eventArgs) => Atualizado = false;

        [NonSerialized]
        private string _filePath = Path.Combine(Directory.GetCurrentDirectory(), nameof(DatabaseJson) + ".json");

        private string FilePath { get => _filePath; }

        public async Task Save(DatabaseJson database)
        {
            try
            {
                if (File.Exists(FilePath))
                    File.Delete(FilePath);

                var content = JsonSerializer.Serialize(database);

                using (var file = File.Create(FilePath))
                {
                    var info = new UTF8Encoding(true).GetBytes(content);
                    await file.WriteAsync(info);
                }

                Atualizado = true;
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
                if (!File.Exists(FilePath))
                    throw new FileNotFoundException($"Arquivo {FilePath} não encontrado!");

                var database = JsonSerializer.Deserialize<DatabaseJson>(File.ReadAllText(FilePath));

                Empresas = database.Empresas;
                Motoristas = database.Motoristas;
                Urls = database.Urls;

                AddCollectionChangeEvent();

                Atualizado = true;
            }
            catch (FileNotFoundException)
            {
                await Save(new DatabaseJson());
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

        private void AddCollectionChangeEvent()
        {
            Empresas.CollectionChanged += CollectionChanged;
            Motoristas.CollectionChanged += CollectionChanged;
            Urls.CollectionChanged += CollectionChanged;
        }
    }
}
