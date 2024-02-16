using MoveInatorForms.Domains.Enums;

namespace MoveInatorForms.Utilities.Extensions
{
    public static class ControlValidateExtensions
    {
        public static void ValidateNotNullOrEmpty(this TextBox textBox, string message)
        {
            if (string.IsNullOrEmpty(textBox.Text)) throw new Exception(message);
        }
        public static void ValidateNotNullOrEmpty(this ComboBox comboBox, string message)
        {
            if (string.IsNullOrEmpty(comboBox.Text)) throw new Exception(message);
        }
        public static void ValidateNumber(this TextBox textBox, string message)
        {
            if (!int.TryParse(textBox.Text, out _)) throw new Exception(message);
        }
        public static void ValidateNumberGreaterThan(this NumericUpDown numericUpDown, string message, int number = 0)
        {
            if (numericUpDown.Value <= number) throw new Exception(message);
        }
        public static void ValidateOnlyDate(this MaskedTextBox maskedTextBox, string message)
        {
            if (!DateTime.TryParse(maskedTextBox.Text, out _)) throw new Exception(message);
        }
        public static void ValidateCPF(this MaskedTextBox maskedText, string message)
        {
            var cpf = maskedText.Text.OnlyNumber();

            if (string.IsNullOrEmpty(cpf)) throw new Exception(message);

            if (cpf.Length != 11) throw new Exception("CPF precisa conter 11 digitos!");
        }
        public static void ValidateCNPJ(this MaskedTextBox maskedText, string message)
        {
            var cnpj = maskedText.Text.OnlyNumber();

            if (string.IsNullOrEmpty(cnpj)) throw new Exception(message);

            if (cnpj.Length != 14) throw new Exception("CNPJ precisa conter 14 digitos!");
        }
        public static void ValidateOneChecked(this CheckedListBox checkedListBox, string message)
        {
            if (!checkedListBox.CheckedIndices.OfType<int>().Any())
                throw new Exception(message);
        }
    }
}
