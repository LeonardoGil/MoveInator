using System.ComponentModel;
using UtilityLib.Extensions;

namespace MoveInatorForms.Forms.Controls
{
    public class Input : TextBox
    {
        private float weight = 0.25F;

        private readonly Font defaultFont;

        public override Color BackColor { get => Parent?.BackColor ?? Color.White; set => base.BackColor = value; }

        public override Color ForeColor { get => Parent?.ForeColor ?? Color.Black; set => base.ForeColor = value; }

        [Category(nameof(Input))]
        public float Weight 
        { 
            get => weight; 
            set => weight = value; 
        }

        public Input()
        {
            defaultFont = Font;
            BorderStyle = BorderStyle.FixedSingle;
        }

        public void ResizeFont(float percentage)
        {
            var size = (defaultFont.Size + (defaultFont.Size * percentage)).Around(weight);
            Font = new Font(defaultFont.FontFamily, size, defaultFont.Style, defaultFont.Unit);
        }
    }
}
