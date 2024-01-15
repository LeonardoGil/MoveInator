namespace UtilityLib.Domains.Entities.DocumentosFiscais
{
    public class DigitoVerificadorCalc
    {
        public static string AddDigitos(string input, int peso, int digitos = 1)
        {
            var count = 1;
            do
            {
                input += Mod11(input, peso).ToString();
                count++;
            } 
            while (count <= digitos);

            return input;
        }

        public static int Mod11(string input, int peso)
        {
            var multiplicador = 2;
            var soma = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                var number = int.Parse(input[i].ToString());

                soma += number * multiplicador;

                multiplicador = multiplicador >= peso ? 2 : multiplicador + 1;
            }

            var resto = soma % 11;

            return resto <= 1 ? 0 : 11 - resto;
        }
    }
}
