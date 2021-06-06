using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class UserControl1 : UserControl
    {
        public Font font;

        public UserControl1()
        {
            InitializeComponent();
            this.font = new Font("Aerial", 12);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
