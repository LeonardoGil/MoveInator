using MoveInatorForms.Domains.Entities.DocumentosFiscais;

namespace MoveInatorForms.Domains.Entities.Importacao
{
    public class MDFe
    {
        public ChaveAcesso ChaveAcesso { get; set; }

        public DateTime DataEmissao { get; set; }

        public string CnpjEmissor { get; set; }

        public string Motorista { get; set; }

        public string CpfMotorista { get; set; }

        public int QuantidadeCTes { get => CTes.Count; }

        public List<CTe> CTes { get; set; } = new List<CTe>();
    }
}
