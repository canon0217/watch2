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
    public partial class Form1 : Form
    {
        Rectangle clientRectangle = new Rectangle();
        

        CustomClock customClock = new CustomClock();
        private AnalogWatchRenderer analogWatchRender;
        private DigitalWatchRenderer digitalWatchRenderer;
        private SandGlassRenderer sandGlassRenderer;

        public Form1()
        {
            InitializeComponent();
            this.analogWatchRender = new AnalogWatchRenderer(this.clientRectangle, this.customClock.font);
            this.digitalWatchRenderer = new DigitalWatchRenderer(this.clientRectangle, this.customClock.font);
            this.sandGlassRenderer = new SandGlassRenderer(this.clientRectangle, this.customClock.font);
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawClocks(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            this.setBackground();

            switch (customClock.clockType)
            {
                case ClockType.Analog:
                    
                    analogWatchRender.Draw(this.customClock, e.Graphics);
                    break;
                case ClockType.Digital:
                    
                    digitalWatchRenderer.Draw(this.customClock, e.Graphics);
                    break;
                case ClockType.Sandglass:
                    
                    sandGlassRenderer.Draw(this.customClock, e.Graphics);
                    break;
                default:
                    break;
            }


            Invalidate();
            System.Threading.Thread.Sleep(1000);
        }

        private void setBackground()
        {
            this.BackColor = this.customClock.BackColor;
        }

        private void アナログ時計ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customClock.clockType = ClockType.Analog;
        }

        private void デジタル時計ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customClock.clockType = ClockType.Digital;
        }

        private void 砂時計ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customClock.clockType = ClockType.Sandglass;        }

        private void 時計ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customClock.functionType = FunctionType.Clock;
        }

        private void ストップウォッチToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customClock.functionType = FunctionType.Stopwatch;
        }

        private void タイマーToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            customClock.functionType = FunctionType.CountdownTimer;
        }
    }
}
