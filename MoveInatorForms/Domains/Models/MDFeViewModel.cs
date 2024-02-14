using MoveInatorForms.Domains.Enums;

namespace MoveInatorForms.Domains.Models
{
    public class MDFeViewModel
    {
        public int Numero { get; set; }

        public int Serie { get; set; }

        public int NumeroDocumento { get; set; }

        public int SerieDocumento { get; set; }

        public DateTime DataEmissao { get; set; }

        public string Emissor { get; set; }

        public string CnpjEmissor { get; set; }

        public string NomeMotorista { get; set; }

        public string CpfMotorista { get; set; }

        public TipoVeiculoEnum TipoVeiculo { get; set; }
    }
}
