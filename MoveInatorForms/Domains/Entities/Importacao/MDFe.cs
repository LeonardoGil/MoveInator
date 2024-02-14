using MoveInatorForms.Domains.Enums;
using UtilityLib.Domains.Entities.DocumentosFiscais;

namespace MoveInatorForms.Domains.Entities.Importacao
{
    public class MDFe
    {
        public ChaveAcesso ChaveAcesso { get; set; }

        public DateTime DataEmissao { get; set; }

        public string Emissor { get; set; }

        public string CnpjEmissor { get; set; }

        public string Motorista { get; set; }

        public string CpfMotorista { get; set; }

        public int QuantidadeCTes { get => CTes.Count; }

        public int QuantidadeNFes { get => NFes.Count; }

        public TipoDocumentoEnum TipoDocumento { get; set; }

        public TipoVeiculoEnum TipoVeiculo { get; set; }

        public List<CTe> CTes { get; set; } = new List<CTe>();

        public List<NFe> NFes { get; set; } = new List<NFe>();
    }
}
