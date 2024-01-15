using UtilityLib.Extensions;

namespace UtilityLib.Domains.Entities.DocumentosFiscais
{
    public class CNPJ
    {
        public string cnpj { get; set; }

        public CNPJ(string cnpj)
        {
            if (cnpj.AllCharsAreEqual())
                throw new Exception("CNPJ não pode ter todos digitos iguais!");

            switch (cnpj.Length)
            {
                // Calcular o digito Verificador
                case 12:
                    cnpj = DigitoVerificadorCalc.AddDigitos(cnpj, 9, 2);
                    break;

                // Validar o Digito Verificador
                case 14:
                    if (!IsValid(cnpj))
                        throw new Exception("CPF Inválido!");
                    break;

                default:
                    throw new Exception($"Tamanho CPF inválido! Value: {cnpj}");
            }

            this.cnpj = cnpj;
        }

        public static string Random()
        {
            var numbers = StringExtensions.RandomNumbers(8) + 1.ToString("D4");

            return new CNPJ(numbers).ToString();
        }

        public static bool IsValid(string cnpj)
        {
            return cnpj.Length == 14 && !cnpj.AllCharsAreEqual() && cnpj.Equals(DigitoVerificadorCalc.AddDigitos(cnpj[0..11], 9, 2));
        }

        public override string ToString() => cnpj;
    }
}
