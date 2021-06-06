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
    internal class DigitalWatchRenderer
    {
        private readonly Rectangle ClientRectangle;
        private readonly Font Font;
        private DateTime StopWatch;

        public DigitalWatchRenderer(Rectangle clientRectangle, Font font)
        {
            this.ClientRectangle = clientRectangle;
            this.Font = font;

            this.StopWatch = new DateTime();
        }

        public void Draw(CustomClock customClock, Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
  
            switch (customClock.FunctionType)
            {
                case FunctionType.Clock:
                    this.drawClock(customClock, drawBrush, drawFormat, graphics);
                    break;
                case FunctionType.Stopwatch:
                    this.drawStopWatch(customClock, drawBrush, drawFormat, graphics);
                    break;
                default:
                    break;
            }
                       
        }

        private void drawClock(CustomClock customClock, SolidBrush drawBrush, StringFormat drawFormat, Graphics graphics)
        {
            DateTime d = DateTime.Now;
            var label = string.Format("{0:00}:{1:00}:{2:00}", d.Hour, d.Minute, d.Second);
            graphics.DrawString(label, customClock.Font, drawBrush, 100, 100, drawFormat);
        }

        private void drawStopWatch(CustomClock customClock, SolidBrush drawBrush, StringFormat drawFormat, Graphics graphics)
        {

            if (customClock.Start())
            {

            }

            var label = string.Format("{0:00}:{1:00}:{2:00}", StopWatch.Hour, StopWatch.Minute, StopWatch.Second);
            graphics.DrawString(label, customClock.Font, drawBrush, 100, 100, drawFormat);
        }
    }
}