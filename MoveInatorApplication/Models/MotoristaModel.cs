namespace MoveInatorApplication.Models
{
    public class MotoristaModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
