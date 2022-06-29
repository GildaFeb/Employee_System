using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GradiantControl

{
    class GradientButton : Button
    {
        private Color rightColor = Color.FromArgb(24, 24, 24);
        private Color leftColor = Color.FromArgb(40, 40, 40);
        public Color RightColor
        {
            get
            {
                return rightColor;
            }
            set
            {
                rightColor = value;
                this.Invalidate();
            }
        }
        public Color LeftColor
        {
            get
            {
                return leftColor;
            }
            set
            {
                leftColor = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            LinearGradientBrush lgb = new LinearGradientBrush(
                this.ClientRectangle, rightColor, leftColor, 180f);
            pevent.Graphics.FillRectangle(lgb, this.ClientRectangle);
            lgb.Dispose();
            SizeF TextSize = pevent.Graphics.MeasureString(this.Text, this.Font);
            pevent.Graphics.DrawString(this.Text, this.Font,
                new SolidBrush(this.ForeColor), (Width - TextSize.Width) / 2,
                (Height - TextSize.Height) / 2);
        }
    }
}