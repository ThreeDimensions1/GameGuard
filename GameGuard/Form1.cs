using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications; // Namespace for ToastContentBuilder
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;
using static System.Windows.Forms.DataFormats;

namespace GameGuard
{
    public partial class Form1 : Form
    {
        public bool IsDarkModeEnabled()
        {
            const string registryKey = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string valueName = "AppsUseLightTheme";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey))
            {
                if (key != null)
                {
                    object registryValue = key.GetValue(valueName);
                    if (registryValue != null)
                    {
                        // If value is 0, dark mode is enabled
                        return (int)registryValue == 0;
                    }
                }
            }

            // Default to light mode if not found
            return false;
        }
        // DWM API to set the dark mode for the title bar
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        private void EnableDarkTitleBar(IntPtr handle)
        {
            if (IsWindows10OrGreater())
            {
                int useDarkMode = 1;
                DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int));
            }
        }

        private void DisableDarkTitleBar(IntPtr handle)
        {
            if (IsWindows10OrGreater())
            {
                int useDarkMode = 0;
                DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int));
            }
        }

        private bool IsWindows10OrGreater()
        {
            return Environment.OSVersion.Version.Major >= 10;
        }

        Form2 form2;

        bool darkMode;
        bool countDrink, countDrinkEnd;

        int secondsDrink, minutesDrink;

        //settings
        public int minutesMaxDrink, minutesMaxEat, minutesMaxBreak;

        //copied settings during count to prevent breaking
        int minutesMaxDrinkCopy, minutesMaxEatCopy, minutesMaxBreakCopy;

        int panelSizeDelta;

        bool countEat, countEatEnd;

        int secondsEat, minutesEat;

        bool countBreak, countBreakEnd;

        int secondsBreak, minutesBreak;

        Image play, pause;
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            timer1.Tick += countTime;
            panelSizeDelta = panel1.Size.Height - Size.Height;
            panel2.Hide();
            countDrinkEnd = true;
            countEatEnd = true;
            countBreakEnd = true;

            Form6 banner = new Form6();
            banner.Show();
            banner.mainWin = this;
            banner.TopMost = true;

            play = Properties.Resources.play;
            pause = Properties.Resources.pause;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            countDrink = true;
            countDrinkEnd = false;
            minutesDrink = 0;
            secondsDrink = 0;
            minutesMaxDrinkCopy = minutesMaxDrink;

            button2.Text = "Stop Counting";
        }

        public void setDarkMode(bool darkMode)
        {
            this.darkMode = darkMode;
            BackColor = darkMode ? ColorTranslator.FromHtml("#191919") : ColorTranslator.FromHtml("#fef9f3");
            //side panel
            button3.ForeColor = darkMode ? Color.White : Color.Black;
            button4.ForeColor = darkMode ? Color.White : Color.Black;
            button5.ForeColor = darkMode ? Color.White : Color.Black;
            button6.ForeColor = darkMode ? Color.White : Color.Black;
            button11.ForeColor = darkMode ? Color.White : Color.Black;
            panel1.BackColor = darkMode ? Color.FromArgb(60, 0, 0, 0) : Color.FromArgb(15, 0, 0, 0);
            //drink section
            //label1.ForeColor = darkMode ? Color.White : Color.Black;
            label2.ForeColor = darkMode ? Color.White : Color.Black;
            button1.ForeColor = darkMode ? Color.White : Color.Black;
            button1.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            button2.ForeColor = darkMode ? Color.White : Color.Black;
            button2.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            //eat section
            //label3.ForeColor = darkMode ? Color.White : Color.Black;
            label4.ForeColor = darkMode ? Color.White : Color.Black;
            button8.ForeColor = darkMode ? Color.White : Color.Black;
            button8.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            button7.ForeColor = darkMode ? Color.White : Color.Black;
            button7.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            //break section
            //label5.ForeColor = darkMode ? Color.White : Color.Black;
            label6.ForeColor = darkMode ? Color.White : Color.Black;
            button9.ForeColor = darkMode ? Color.White : Color.Black;
            button9.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            button10.ForeColor = darkMode ? Color.White : Color.Black;
            button10.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            //about section
            label9.ForeColor = darkMode ? Color.White : Color.Black;
            button12.ForeColor = darkMode ? Color.White : Color.Black;
            button12.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.Bisque;
            button12.Image = darkMode ? Properties.Resources.github_mark_white : Properties.Resources.github_mark;

            //title bar
            if (darkMode)
                EnableDarkTitleBar(this.Handle);
            else
                DisableDarkTitleBar(this.Handle);
        }

        void countTime(object sender, EventArgs e)
        {
            if (countDrink)
            {
                secondsDrink++;
                if (secondsDrink == 60)
                {
                    if (minutesMaxDrinkCopy - 1 - minutesDrink == 0 && 60 - secondsDrink == 0)
                    {
                        countDrink = false;
                        countDrinkEnd = true;
                        button2.Text = "Counting Ended";
                        Form3 form3 = new Form3();
                        form3.Show();
                        if (darkMode)
                        {
                            form3.DarkMode();
                        }
                        form3.Location = new Point(Screen.PrimaryScreen.Bounds.Width - form3.Width - 40, Screen.PrimaryScreen.Bounds.Height - form3.Height - 80);

                        return;
                    }
                    secondsDrink = 0;
                    minutesDrink++;
                }

                if (secondsDrink > 0)
                {
                    progressPanelDrink.Size = new Size((int)(((minutesDrink * 1f + secondsDrink * 1f / 60) / minutesMaxDrinkCopy) * 334), 40);
                }
                else if (countDrinkEnd)
                {
                    progressPanelDrink.Size = new Size(0, 40);
                }

                label2.Text = (minutesMaxDrinkCopy - 1 - minutesDrink).ToString() + ":" + (60 - secondsDrink).ToString();
                button4.Text = "Drink " + (minutesMaxDrinkCopy - 1 - minutesDrink).ToString() + ":" + (60 - secondsDrink).ToString();
            }
            else if (!countDrink && countDrinkEnd)
            {
                progressPanelDrink.Size = new Size(334, 40);
                label2.Text = minutesMaxDrink + ":00";
                button4.Text = "Drink";
            }

            if (countEat)
            {
                secondsEat++;
                if (secondsEat == 60)
                {
                    if (minutesMaxEatCopy - 1 - minutesEat == 0 && 60 - secondsEat == 0)
                    {
                        countEat = false;
                        countEatEnd = true;
                        button8.Text = "Counting Ended";
                        Form4 form4 = new Form4();
                        form4.Show();
                        if (darkMode)
                        {
                            form4.DarkMode();
                        }
                        form4.Location = new Point(Screen.PrimaryScreen.Bounds.Width - form4.Width - 40, Screen.PrimaryScreen.Bounds.Height - form4.Height - 80);
                    }
                    else
                    {
                        secondsEat = 0;
                        minutesEat++;
                    }
                }

                if (secondsEat > 0)
                {
                    progressPanelEat.Size = new Size((int)(((minutesEat * 1f + secondsEat * 1f / 60) / minutesMaxEatCopy) * 334), 40);
                }
                else if (countEatEnd)
                {
                    progressPanelEat.Size = new Size(0, 40);
                }

                label4.Text = (minutesMaxEatCopy - 1 - minutesEat).ToString() + ":" + (60 - secondsEat).ToString();
                button5.Text = "Eat " + (minutesMaxEatCopy - 1 - minutesEat).ToString() + ":" + (60 - secondsEat).ToString();
            }
            else if (!countEat && countEatEnd)
            {
                progressPanelEat.Size = new Size(334, 40);
                label4.Text = minutesMaxEat + ":00";
                button5.Text = "Eat";
            }

            if (countBreak)
            {
                secondsBreak++;
                if (secondsBreak == 60)
                {
                    if (minutesMaxBreakCopy - 1 - minutesBreak == 0 && 60 - secondsBreak == 0)
                    {
                        countBreak = false;
                        countBreakEnd = true;
                        button10.Text = "Counting Ended";
                        Form5 form5 = new Form5();
                        form5.Show();
                        if (darkMode)
                        {
                            form5.DarkMode();
                        }
                        form5.Location = new Point(Screen.PrimaryScreen.Bounds.Width - form5.Width - 40, Screen.PrimaryScreen.Bounds.Height - form5.Height - 80);

                        return;
                    }
                    secondsBreak = 0;
                    minutesBreak++;
                }

                if (secondsBreak > 0)
                {
                    progressPanelBreak.Size = new Size((int)(((minutesBreak * 1f + secondsBreak * 1f / 60) / minutesMaxBreakCopy) * 334), 40);
                }
                else if (countBreakEnd)
                {
                    progressPanelBreak.Size = new Size(0, 40);
                }

                label6.Text = (minutesMaxBreakCopy - 1 - minutesBreak).ToString() + ":" + (60 - secondsBreak).ToString();
                button6.Text = "Break " + (minutesMaxBreakCopy - 1 - minutesBreak).ToString() + ":" + (60 - secondsBreak).ToString();
            }
            else if (!countBreak && countBreakEnd)
            {
                progressPanelBreak.Size = new Size(334, 40);
                label6.Text = minutesMaxBreak + ":00";
                button6.Text = "Break";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!countDrinkEnd)
            {
                countDrink = !countDrink;
                button2.Text = countDrink ? "Stop Counting" : "Start Counting";
                button2.Image = countDrink ? pause : play;
            }
            else
            {
                countDrink = true;
                countDrinkEnd = false;
                minutesDrink = 0;
                secondsDrink = 0;
                minutesMaxDrinkCopy = minutesMaxDrink;

                button2.Text = "Stop Counting";
                button2.Image = pause;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.mainWin = this;
                form2.Show();
                form2.FormClosed += SettingsCLose;
                form2.SetDarkMode(darkMode);
                form2.LoadSettings();
            }
            else
            {
                form2.BringToFront();
            }
        }

        void SettingsCLose(object sender, EventArgs e)
        {
            form2 = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void LoadSettings()
        {
            setDarkMode(Properties.Settings.Default.AutoMode ? IsDarkModeEnabled() : Properties.Settings.Default.DarkMode);
            if (Properties.Settings.Default.MinutesDrink == 0)
            {
                Properties.Settings.Default.MinutesDrink = 30;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.MinutesEat == 0)
            {
                Properties.Settings.Default.MinutesEat = 45;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.MinutesBreak == 0)
            {
                Properties.Settings.Default.MinutesBreak = 60;
                Properties.Settings.Default.Save();
            }

            minutesMaxDrink = Properties.Settings.Default.MinutesDrink;
            minutesMaxEat = Properties.Settings.Default.MinutesEat;
            minutesMaxBreak = Properties.Settings.Default.MinutesBreak;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Size = new Size(panel1.Size.Width, Size.Height + panelSizeDelta);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Text = "Game Guard - Drink";
            panel2.Show();
            panel3.Hide();
            panel4.Hide();
            About.Hide();
            button4.BackColor = Color.FromArgb(60, 90, 214, 252);
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button11.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Text = "Game Guard - Eat";
            panel2.Hide();
            panel3.Show();
            panel4.Hide();
            About.Hide();
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.FromArgb(60, 90, 214, 252);
            button6.BackColor = Color.Transparent;
            button11.BackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Text = "Game Guard - Break";
            panel2.Hide();
            panel3.Hide();
            panel4.Show();
            About.Hide();
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.FromArgb(60, 90, 214, 252);
            button11.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            countEat = true;
            countEatEnd = false;
            minutesEat = 0;
            secondsEat = 0;

            button8.Text = "Stop Counting";
            button8.Image = pause;
            minutesMaxEatCopy = minutesMaxEat;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!countEatEnd)
            {
                countEat = !countEat;
                button8.Text = countEat ? "Stop Counting" : "Start Counting";
                button8.Image = countEat ? pause : play;
            }
            else
            {
                countEat = true;
                countEatEnd = false;
                minutesEat = 0;
                secondsEat = 0;

                button8.Text = "Stop Counting";
                button8.Image = pause;
                minutesMaxEatCopy = minutesMaxEat;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            countBreak = true;
            countBreakEnd = false;
            minutesBreak = 0;
            secondsBreak = 0;

            button10.Text = "Stop Counting";
            button10.Image = pause;
            minutesMaxBreakCopy = minutesMaxBreak;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!countBreakEnd)
            {
                countBreak = !countBreak;
                button10.Text = countBreak ? "Stop Counting" : "Start Counting";
                button10.Image = countBreak ? pause : play;
            }
            else
            {
                countBreak = true;
                countBreakEnd = false;
                minutesBreak = 0;
                secondsBreak = 0;

                button10.Text = "Stop Counting";
                button10.Image = pause;
                minutesMaxBreakCopy = minutesMaxBreak;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Text = "Game Guard - About";
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            About.Show();
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button11.BackColor = Color.FromArgb(60, 90, 214, 252);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenLink("github.com/ThreeDimensions1/GameGuard");
        }

        private void OpenLink(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "https://" + url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}");
            }
        }
    }
}
