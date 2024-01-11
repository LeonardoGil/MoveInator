namespace MoveInatorForms.Domains.Entities
{
    public class Empresa
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Cnpj { get; set; }


        public string ClientId { get; set; }

        public string ClientSecrect { get; set; }
    }
}
