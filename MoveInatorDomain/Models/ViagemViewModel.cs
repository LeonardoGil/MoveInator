using MoveInatorDomain.Enums;

namespace MoveInatorDomain.Models
{
    public class ViagemViewModel
    {
        private TipoDocumentoViagemEnum _tipoViagem;

        public TipoDocumentoViagemEnum TipoViagem
        {
            get => _tipoViagem;
            set
            {
                _tipoViagem = value;

                if (value != TipoDocumentoViagemEnum.MDFe)
                {
                    SerieViagem = null;
                }
            }
        }

        public int NumeroViagem { get; set; }

        public int? SerieViagem { get; set; }


        public TipoDocumentoEnum TipoDocumento { get; set; }

        public int NumeroDocumento { get; set; }

        public int SerieDocumento { get; set; }

        public int Quantidade { get; set; }


        public DateTime DataEmissao { get; set; }

        public string CnpjEmissor { get; set; }


        public string NomeDestinatario { get; set; }

        public string CpfCnpjDestinatario { get; set; }

        public string NomeMotorista { get; set; }

        public string CpfMotorista { get; set; }

        public string CodigoVeiculo { get; set; }
    }
}
