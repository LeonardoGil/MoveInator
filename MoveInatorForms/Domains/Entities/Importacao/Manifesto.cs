namespace MoveInatorForms.Domains.Entities.Importacao
{
    public class Manifesto
    {
        public int TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string SerieDocumento { get; set; }

        public DateTime DataEmissao { get; set; }

        public string ChaveAcesso { get; set; }

        public string CNPJEmissor { get; set; }

        public decimal? ValorDaMercadoria { get; set; }

        public string UnidadeDeMedida { get; set; }

        public int? QuantidadeDaCarga { get; set; }

        public int? QuantidadeCTe { get; set; }

        public int? QuantidadeNFe { get; set; }

        public string NomeDoMotorista { get; set; }

        public string CPFMotorista { get; set; }

        public string PlacaDoVeiculo { get; set; }

        public int NumerodaNFe { get; set; }

        public int SerieDaNFe { get; set; }

        public string ChaveDeAcessoDaNFe { get; set; }

        public int? NumeroDoCTe { get; set; }

        public int? SerieDoCTe { get; set; }

        public string ChaveDeAcessoDoCTe { get; set; }

        public string NomeDestinatario { get; set; }

        public string CNPJCPFDestinatario { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Municipio { get; set; }

        public string CEP { get; set; }

        public string UF { get; set; }

        public static string Header()
        {
            var fields = new string[]
            {
                nameof(TipoDocumento),
                nameof(NumeroDocumento),
                nameof(SerieDocumento),
                nameof(DataEmissao),
                nameof(ChaveAcesso),
                nameof(CNPJEmissor),
                nameof(ValorDaMercadoria),
                nameof(UnidadeDeMedida),
                nameof(QuantidadeDaCarga),
                nameof(QuantidadeCTe),
                nameof(QuantidadeNFe),
                nameof(NomeDoMotorista),
                nameof(CPFMotorista),
                nameof(PlacaDoVeiculo),
                nameof(NumerodaNFe),
                nameof(SerieDaNFe),
                nameof(ChaveDeAcessoDaNFe),
                nameof(NumeroDoCTe),
                nameof(SerieDoCTe),
                nameof(ChaveDeAcessoDoCTe),
                nameof(NomeDestinatario),
                nameof(CNPJCPFDestinatario),
                nameof(Logradouro),
                nameof(Numero),
                nameof(Bairro),
                nameof(Municipio),
                nameof(CEP),
                nameof(UF)
            };

            return string.Join(';', fields);
        }

        public string Row()
        {
            var fields = new string[]
            {
                TipoDocumento.ToString(),
                NumeroDocumento,
                SerieDocumento,
                DataEmissao.ToString("d"),
                ChaveAcesso,
                CNPJEmissor,
                ValorDaMercadoria?.ToString() ?? string.Empty,
                UnidadeDeMedida,
                QuantidadeDaCarga?.ToString() ?? string.Empty,
                QuantidadeCTe?.ToString() ?? string.Empty,
                QuantidadeNFe?.ToString() ?? string.Empty,
                NomeDoMotorista,
                CPFMotorista,
                PlacaDoVeiculo,
                NumerodaNFe.ToString(),
                SerieDaNFe.ToString(),
                ChaveDeAcessoDaNFe,
                NumeroDoCTe?.ToString() ?? string.Empty,
                SerieDoCTe?.ToString() ?? string.Empty,
                ChaveDeAcessoDoCTe,
                NomeDestinatario,
                CNPJCPFDestinatario,
                Logradouro,
                Numero,
                Bairro,
                Municipio,
                CEP,
                UF
            };

            return string.Join(';', fields);
        }
    }
}
