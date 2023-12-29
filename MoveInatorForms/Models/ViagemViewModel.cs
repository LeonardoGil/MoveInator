namespace MoveInatorForms.Models
{
    public class ViagemViewModel
    {
        public int TipoViagem { get; set; }

        public int NumeroViagem { get; set; }

        public int SerieViagem { get; set; }


        public int TipoDocumento { get; set; }

        public int NumeroDocumento { get; set; }

        public int SerieDocumento { get; set; }

        public int Quantidade { get; set; }


        public DateTime DataEmissao { get; set; }

        public string CnpjEmissor { get; set; }


        public string NomeDestinatario { get; set; }
        
        public string CpfCnpjDestinatario { get; set; }
        
        public string NomeMotorista { get; set; }
        
        public string CpfMotorista { get; set; }
    }
}
