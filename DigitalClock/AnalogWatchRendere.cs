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
    internal class AnalogWatchRenderer
    {
        private readonly Rectangle ClientRectangle;
        Point formSize, startPos, endPos;
        Form form = new Form();
        Pen hourP = new Pen(Color.Red, 8);
        Pen minP = new Pen(Color.Green, 8);
        Pen secP = new Pen(Color.Blue, 1);

        public AnalogWatchRenderer(Rectangle clientRectangle, Font font)
        {
            this.ClientRectangle = clientRectangle;
        }

        public void Draw(CustomClock customClock, Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.RotateTransform(30.0F);

            SolidBrush brush = new SolidBrush(Color.Purple);

            int adjustLength = 300;
            graphics.FillEllipse(brush, 0, 0, adjustLength, adjustLength);

            float fontSize = (float)adjustLength / 30;
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            float centerPos = (float)adjustLength / 2;
            float x, y;
            for (int i = 1; i <= 12; i++)
            {
                x = centerPos + (float)(0.9 * centerPos * (float)Math.Sin(30 * i * (Math.PI / 180))) - fontSize;
                y = centerPos - (float)(0.9 * centerPos * (float)Math.Cos(30 * i * (Math.PI / 180))) - fontSize;
                graphics.DrawString(i.ToString(), customClock.font, drawBrush, x, y, drawFormat);
            }

            startPos.X = (int)centerPos;
            startPos.Y = (int)centerPos;

            int sec = DateTime.Now.Second;

            endPos.X = (int)(centerPos + 0.7 * centerPos * Math.Sin(360 * sec / 60 * (Math.PI / 180)));
            endPos.Y = (int)(centerPos - 0.7 * centerPos * Math.Cos(360 * sec / 60 * (Math.PI / 180)));
            graphics.DrawLine(secP, startPos.X, startPos.Y, endPos.X, endPos.Y);

            int min = DateTime.Now.Minute;
            endPos.X = (int)(centerPos + 0.8 * centerPos * Math.Sin(360 * (min + sec / 60) / 60 * (Math.PI / 180)));
            endPos.Y = (int)(centerPos - 0.8 * centerPos * Math.Cos(360 * (min + sec / 60) / 60 * (Math.PI / 180)));
            graphics.DrawLine(minP, startPos.X, startPos.Y, endPos.X, endPos.Y);

            int hour = DateTime.Now.Hour;
            if (12 <= hour)
            {
                hour -= 12;
            }
            endPos.X = (int)(centerPos + 0.4 * centerPos * Math.Sin(360 * ((float)hour + (float)min / 60) / 12 * (Math.PI / 180)));
            endPos.Y = (int)(centerPos - 0.4 * centerPos * Math.Cos(360 * ((float)hour + (float)min / 60) / 12 * (Math.PI / 180)));
            graphics.DrawLine(hourP, startPos.X, startPos.Y, endPos.X, endPos.Y);

        }

    }
}