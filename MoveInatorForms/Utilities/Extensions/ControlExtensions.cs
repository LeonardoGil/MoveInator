namespace MoveInatorForms.Utilities.Extensions
{
    public static class ControlExtensions
    {
        public static void OnlyNumber_KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
