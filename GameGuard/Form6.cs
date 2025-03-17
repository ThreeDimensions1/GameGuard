using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGuard
{
    public partial class Form6 : Form
    {
        public Form1 mainWin;
        double transparency;
        bool fadeIn;
        public Form6()
        {
            InitializeComponent();
            fadeIn = true;
            transparency = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                transparency = transparency + 0.05;
                Opacity = transparency;
                if (transparency == 1)
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                transparency = transparency - 0.05;
                Opacity = transparency;
                if (transparency <= 0.1)
                {
                    Close();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fadeIn = false;
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Location = new Point(mainWin.Location.X + mainWin.Width / 2 - Width / 2, mainWin.Location.Y + mainWin.Height / 2 - Height / 2);
        }
    }
}
