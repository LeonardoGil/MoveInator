using MoveInatorDomain.Enums;

namespace MoveInatorApplication.Models
{
    public class ViagemXmlModel
    {
        public int Numero { get; set; }

        public int Serie { get; set; }

        public int NumeroDocumento { get; set; }

        public int SerieDocumento { get; set; }

        public DateTime DataEmissao { get; set; }

        public EmpresaModel Empresa { get; set; }

        public MotoristaModel Motorista { get; set; }

        public TipoDocumentoEnum TipoDocumento { get; set; }

        public TipoVeiculoEnum TipoVeiculo { get; set; }
    }
}
