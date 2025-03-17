namespace GameGuard
{
    using System;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.Media;

    public partial class Form3 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );


        public Form3()
        {
            InitializeComponent();
            SystemSounds.Exclamation.Play();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            TopMost = true;
            Opacity = 0;
            this.MouseDown += Form1_MouseDown;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TransparencyFade();
        }



        private void TransparencyFade()
        {
            Opacity = Opacity + 0.1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Close();
        }

        public void DarkMode()
        {
            BackColor = ColorTranslator.FromHtml("#202020");
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }
    }
}
