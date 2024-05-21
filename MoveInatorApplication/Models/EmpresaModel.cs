namespace MoveInatorApplication.Models
{
    public class EmpresaModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }

        public string ClientId { get; set; }

        public string ClientSecrect { get; set; }

        public Guid? AmbienteId { get; set; }
    }
}
