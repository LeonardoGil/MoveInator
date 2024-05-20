using MoveInatorDomain.Entities.Cadastros;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using System.Text.Json;

namespace MoveInatorDomain.Entities.Outros
{
    public class DatabaseJson
    {
        public bool Atualizado { get; set; }

        public ObservableCollection<Empresa> Empresas { get; set; } = new ObservableCollection<Empresa>();

        public ObservableCollection<Motorista> Motoristas { get; set; } = new ObservableCollection<Motorista>();

        public DatabaseJson()
        {
            AddCollectionChangeEvent();
        }

        public static string FilePath { get => Path.Combine(Directory.GetCurrentDirectory(), nameof(DatabaseJson) + ".json"); }

        public void CollectionChanged(object sender, NotifyCollectionChangedEventArgs eventArgs) => Atualizado = false;

        public void AddCollectionChangeEvent()
        {
            Empresas.CollectionChanged += CollectionChanged;
            Motoristas.CollectionChanged += CollectionChanged;
        }
    }
}
