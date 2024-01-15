namespace UtilityLib.Domains.Entities.DocumentosFiscais
{
    public class DigitoVerificadorCalc
    {
        public static int Mod11(string chave)
        {
            var multiplicador = 2;
            var soma = 0;

            for (int i = chave.Length - 1; i >= 0; i--)
            {
                var number = int.Parse(chave[i].ToString());

                soma += number * multiplicador;

                multiplicador = multiplicador >= 9 ? 2 : multiplicador + 1;
            }

            var resto = soma % 11;

            return resto <= 1 ? 0 : 11 - resto;
        }
    }
}
