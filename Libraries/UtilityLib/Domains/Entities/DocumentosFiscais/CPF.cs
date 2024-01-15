using UtilityLib.Extensions;

namespace UtilityLib.Domains.Entities.DocumentosFiscais
{
    public class CPF
    {
        private readonly string cpf;

        public CPF(string cpf)
        {
            if (cpf.AllCharsAreEqual())
                throw new Exception("CPF não pode ter todos digitos iguais!");

            switch (cpf.Length)
            {
                // Calcular o digito Verificador
                case 9:
                    cpf = DigitoVerificadorCalc.AddDigitos(cpf, 11, 2);
                    break;
                  
                // Validar o Digito Verificador
                case 11:
                    if (!IsValid(cpf))
                        throw new Exception("CPF Inválido!");
                    break;
                
                default:
                    throw new Exception($"Tamanho CPF inválido! Value: {cpf}");
            }

            this.cpf = cpf;
        }

        public static string Random()
        {
            var numbers = StringExtensions.RandomNumbers(9);

            return new CPF(numbers).ToString();
        }

        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11 && !cpf.AllCharsAreEqual() && cpf == DigitoVerificadorCalc.AddDigitos(cpf[0..8], 11, 2);
        }

        public override string ToString() => cpf;
    }
}
