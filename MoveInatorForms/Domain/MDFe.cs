namespace MoveInatorForms.Domain
{
    namespace MoveInatorForms.Domain
    {
        public class MDFe
        {
            public MDFe(int uf, int mes, int ano, long cnpj, int serie, int numero)
            {
                cUF = uf;
                cMes = mes;
                cAno = ano;
                cCnpj = cnpj;
                cSerie = serie;
                cNumero = numero;

                SetDigitoVerificador();
            }

            private int cUF;
            private int cMes;
            private int cAno;
            private long cCnpj;
            private int cModelo = 58;
            private int cSerie;
            private int cNumero;
            private int cTipoEmissao = 1;
            private int cCodigoNumerico = 12345678;
            private int cDigitoVerificador;

            public string ChaveDeAcesso { get => string.Concat(UF, DataEmissao, CNPJ, Modelo, Serie, Numero, TipoEmissao, CodigoNumerico, DigitoVerificador); }

            public string UF { get => cUF.ToString("D2"); }

            public string Mes { get => cMes.ToString("D2"); }

            public string Ano { get => cAno.ToString("D2"); }

            public string DataEmissao { get => string.Concat(Mes, Ano); }

            public string CNPJ { get => cCnpj.ToString("D14"); }

            public string Modelo { get => cModelo.ToString(); }

            public string Serie { get => cSerie.ToString("D3"); }

            public string Numero { get => cNumero.ToString("D9"); }

            public string TipoEmissao { get => cTipoEmissao.ToString(); }

            public string CodigoNumerico { get => cCodigoNumerico.ToString(); }

            public string DigitoVerificador { get => cDigitoVerificador.ToString(); }

            private void SetDigitoVerificador()
            {
                var chaveSemDigito = string.Concat(UF, DataEmissao, CNPJ, Modelo, Serie, Numero, TipoEmissao, CodigoNumerico);
                var multiplicador = 2;
                var soma = 0;

                for (int i = 42; i >= 0; i--)
                {
                    var number = int.Parse(chaveSemDigito[i].ToString());

                    soma += number * multiplicador;

                    multiplicador = multiplicador >= 9 ? 2 : (multiplicador + 1);
                }

                var resto = soma % 11;

                cDigitoVerificador = resto == 1 ? 0 : resto;
            }
        }
    }
}
