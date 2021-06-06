using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DigitalClock
{
    internal class SandGlassRenderer
    {
        private readonly Rectangle ClientRectangle;
        private readonly Font Font;

        public SandGlassRenderer(Rectangle clientRectangle, Font font)
        {
            this.ClientRectangle = clientRectangle;
            this.Font = font;
        }

        public void Draw(CustomClock customClock, Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush brush = new SolidBrush(Color.Purple);
            var rect1 = new Rectangle(0, 50, 25, 100);
            var rect2 = new Rectangle(25, 100, 50, 50);

            GraphicsPath myPath = new GraphicsPath();

            
            myPath.StartFigure();
            myPath.AddEllipse(0, 50, 25, 25);
            //myPath.AddArc(rect1, 0, 90);
            //myPath.AddArc(rect2, 90, 180);
            myPath.CloseFigure();
            graphics.DrawPath(new Pen(Color.Red, 3), myPath);

            
        }
    }
}