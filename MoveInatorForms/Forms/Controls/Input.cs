using System.ComponentModel;
using UtilityLib.Extensions;

namespace MoveInatorForms.Forms.Controls
{
    public class Input : TextBox
    {
        private float weight = 0.25F;

        private readonly Font defaultFont;

        [Category(nameof(Input))]
        public float Weight 
        { 
            get => weight;
            set
            {
                weight = value;
                Invalidate();
            }
        }

        public Input()
        {
            BackColor = Color.FromArgb(31, 31, 31);
            ForeColor = Color.Gray;

            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            BorderStyle = BorderStyle.FixedSingle;
            
            defaultFont = Font;
        }

        public void ResizeFont(float percentage)
        {
            var size = (defaultFont.Size + (defaultFont.Size * percentage)).Around(weight);
            Font = new Font(defaultFont.FontFamily, size, defaultFont.Style, defaultFont.Unit);
        }
    }
}
