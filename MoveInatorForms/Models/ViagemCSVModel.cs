namespace MoveInatorForms.Models
{
    public class ViagemCSVModel
    {
        public int TipoDocumento { get; set; }

        public string OrdemViagem { get; set; }

        public string NumeroDocumento { get; set; }

        public string SerieDocumento { get; set; }
        
        public DateTime DataEmissao { get; set; }

        public string ChaveAcesso { get; set; }

        public string CNPJEmissor { get; set; }

        public decimal ValorDaMercadoria { get; set; }

        public string UnidadeDeMedida { get; set; }

        public int QuantidadeDaCarga { get; set; }

        public int QuantidadeCTe { get; set; }

        public int QuantidadeNFe { get; set; }

        public string NomeDoMotorista { get; set; }

        public string CPFMotorista { get; set; }

        public string PlacaDoVeiculo { get; set; }

        public int NumerodaNFe { get; set; }

        public int SerieDaNFe { get; set; }

        public string ChaveDeAcessoDaNFe { get; set; }

        public int NumeroDoCTe { get; set; }

        public int SerieDoCTe { get; set; }

        public string ChaveDeAcessoDoCTe { get; set; }

        public string NomeDestinatario { get; set; }

        public string CNPJCPFDestinatario { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string CEP { get; set; }

        public string UF { get; set; }
    }
}
