using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MoveInatorForms.Forms.Controls
{
    public class ToggleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        
        public override string Text { get => base.Text; set { } }
        
        [Category("Toggle")]
        public Color OnBackColor
        {
            get => onBackColor;
            set
            {
                onBackColor = value;
                Invalidate();
            }
        }

        [Category("Toggle")]
        public Color OnToggleColor
        {
            get => onToggleColor;
            set
            {
                onToggleColor = value;
                Invalidate();
            }
        }

        [Category("Toggle")]
        public Color OffBackColor 
        { 
            get => offBackColor;
            set
            {
                offBackColor = value;
                Invalidate();
            }
        }
        
        [Category("Toggle")]
        public Color OffToggleColor 
        { 
            get => offToggleColor; 
            set {
                offToggleColor = value;
                Invalidate();
            } 
        }

        public ToggleButton()
        {
            MinimumSize = new Size(45, 22);
            AutoSize = false;
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;

            var leftArc = new Rectangle(0, 0, arcSize, arcSize);
            var rightArc = new Rectangle(Width - arcSize - 2, 0, arcSize, arcSize);

            var path = new GraphicsPath();
            
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var toggleSize = Height - 5;

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(Parent.BackColor);

            if (Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
