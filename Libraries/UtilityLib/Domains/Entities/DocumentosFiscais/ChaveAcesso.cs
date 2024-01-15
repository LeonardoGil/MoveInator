namespace UtilityLib.Domains.Entities.DocumentosFiscais
{
    public class ChaveAcesso
    {
        public ChaveAcesso(int modelo, int uf, DateTime date, long cnpj, int serie, int numero)
        {
            this.uf = uf;
            mes = int.Parse(date.ToString("MM"));
            ano = int.Parse(date.ToString("yy"));
            this.cnpj = cnpj;
            this.modelo = modelo;
            this.serie = serie;
            this.numero = numero;

            SetDigitoVerificador();
        }

        public ChaveAcesso(int modelo, int uf, int mes, int ano, long cnpj, int serie, int numero)
        {
            this.uf = uf;
            this.mes = mes;
            this.ano = ano;
            this.cnpj = cnpj;
            this.modelo = modelo;
            this.serie = serie;
            this.numero = numero;

            SetDigitoVerificador();
        }

        private readonly int uf;
        private readonly int mes;
        private readonly int ano;
        private readonly long cnpj;
        private readonly int modelo;
        private readonly int serie;
        private readonly int numero;
        private readonly int tipoEmissao = 1;
        private readonly int codigoNumerico = 12345678;
        private int cDigitoVerificador;

        public string ChaveDeAcesso { get => string.Concat(UF, DataEmissao, CNPJ, Modelo, Serie, Numero, TipoEmissao, CodigoNumerico, DigitoVerificador); }

        public string UF { get => uf.ToString("D2"); }

        public string Mes { get => mes.ToString("D2"); }

        public string Ano { get => ano.ToString("D2"); }

        public string DataEmissao { get => string.Concat(Mes, Ano); }

        public string CNPJ { get => cnpj.ToString("D14"); }

        public string Modelo { get => modelo.ToString(); }

        public string Serie { get => serie.ToString("D3"); }

        public string Numero { get => numero.ToString("D9"); }

        public string TipoEmissao { get => tipoEmissao.ToString(); }

        public string CodigoNumerico { get => codigoNumerico.ToString(); }

        public string DigitoVerificador { get => cDigitoVerificador.ToString(); }

        private void SetDigitoVerificador()
        {
            var chaveSemDigito = string.Concat(UF, DataEmissao, CNPJ, Modelo, Serie, Numero, TipoEmissao, CodigoNumerico);

            if (chaveSemDigito.Length != 43)
                throw new Exception("Não foi possível calcular o digito Verificador. Motivo: Chave de acesso não contem 43 digitos.");

            var multiplicador = 2;
            var soma = 0;

            for (int i = 42; i >= 0; i--)
            {
                var number = int.Parse(chaveSemDigito[i].ToString());

                soma += number * multiplicador;

                multiplicador = multiplicador >= 9 ? 2 : multiplicador + 1;
            }

            var resto = soma % 11;

            cDigitoVerificador = resto <= 1 ? 0 : 11 - resto;
        }

        public override string ToString()
        {
            return ChaveDeAcesso;
        }
    }
}
