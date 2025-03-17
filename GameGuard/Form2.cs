using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GameGuard
{
    public partial class Form2 : Form
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

        Color darkModeMain;
        public Form1 mainWin;
        public Form2()
        {
            darkModeMain = new Color();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mainWin.setDarkMode(checkBox1.Checked);
            SetDarkMode(checkBox1.Checked);
            SaveSettings();
        }

        public void SetDarkMode(bool darkMode)
        {
            checkBox1.ForeColor = darkMode ? Color.White : Color.Black;
            checkBox2.ForeColor = darkMode ? Color.White : Color.Black;
            BackColor = darkMode ? ColorTranslator.FromHtml("#191919") : ColorTranslator.FromHtml("#fef9f3");
            if (darkMode)
                EnableDarkTitleBar(this.Handle);
            else
                DisableDarkTitleBar(this.Handle);
            label1.ForeColor = darkMode ? Color.White : Color.Black;
            label2.ForeColor = darkMode ? Color.White : Color.Black;
            button1.ForeColor = darkMode ? Color.White : Color.Black;
            button1.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
            button2.ForeColor = darkMode ? Color.White : Color.Black;
            button2.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
            label3.ForeColor = darkMode ? Color.White : Color.Black;
            label4.ForeColor = darkMode ? Color.White : Color.Black;
            button3.ForeColor = darkMode ? Color.White : Color.Black;
            button3.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
            button4.ForeColor = darkMode ? Color.White : Color.Black;
            button4.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
            label5.ForeColor = darkMode ? Color.White : Color.Black;
            label6.ForeColor = darkMode ? Color.White : Color.Black;
            button5.ForeColor = darkMode ? Color.White : Color.Black;
            button5.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
            button6.ForeColor = darkMode ? Color.White : Color.Black;
            button6.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
            DefaultsButton.ForeColor = darkMode ? Color.White : Color.Black;
            DefaultsButton.BackColor = darkMode ? ColorTranslator.FromHtml("#202020") : Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainWin.minutesMaxDrink--;
            label1.Text = mainWin.minutesMaxDrink.ToString();
            SaveSettings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainWin.minutesMaxDrink++;
            label1.Text = mainWin.minutesMaxDrink.ToString();
            SaveSettings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainWin.minutesMaxEat++;
            label4.Text = mainWin.minutesMaxEat.ToString();
            SaveSettings();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainWin.minutesMaxEat--;
            label4.Text = mainWin.minutesMaxEat.ToString();
            SaveSettings();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainWin.minutesMaxBreak++;
            label6.Text = mainWin.minutesMaxBreak.ToString();
            SaveSettings();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainWin.minutesMaxBreak--;
            label6.Text = mainWin.minutesMaxBreak.ToString();
            SaveSettings();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox2.Checked;
            if (checkBox2.Checked)
            {
                SetDarkMode(IsDarkModeEnabled());
                mainWin.setDarkMode(IsDarkModeEnabled());
            }
            else
            {
                SetDarkMode(checkBox1.Checked);
                mainWin.setDarkMode(checkBox1.Checked);
            }
            SaveSettings();
        }

        void SaveSettings()
        {
            Properties.Settings.Default.AutoMode = checkBox2.Checked;
            Properties.Settings.Default.DarkMode = checkBox1.Checked;
            Properties.Settings.Default.MinutesDrink = mainWin.minutesMaxDrink;
            Properties.Settings.Default.MinutesEat = mainWin.minutesMaxEat;
            Properties.Settings.Default.MinutesBreak = mainWin.minutesMaxBreak;
            Properties.Settings.Default.Save();
        }

        public void LoadSettings()
        {
            checkBox2.Checked = Properties.Settings.Default.AutoMode;
            checkBox1.Checked = Properties.Settings.Default.DarkMode;
            label1.Text = mainWin.minutesMaxDrink.ToString();
            label4.Text = mainWin.minutesMaxEat.ToString();
            label6.Text = mainWin.minutesMaxBreak.ToString();
        }

        private void DefaultsButton_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            mainWin.minutesMaxDrink = 30;
            mainWin.minutesMaxEat = 45;
            mainWin.minutesMaxBreak = 60;
            SaveSettings();
            LoadSettings();
        }
    }
}
