using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AngryHammer
{
    public partial class Form1 : Form
    {
        string applicationlanguage = "en";

        static string GenerateRandomHex(int length)
        {
            // 16 possible hex characters (0-9 and A-F)
            const string hexChars = "0123456789ABCDEF";
            StringBuilder result = new StringBuilder(length);
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                // Select a character from the hexChars string
                int index = random.Next(hexChars.Length);
                result.Append(hexChars[index]);
            }

            return result.ToString();
        }

        public Form1(string lang)
        {
            InitializeComponent();

            // Language
            if (lang == "en")
            {
                applicationlanguage = "en";
            }
            if (lang == "ru")
            {
                applicationlanguage = "ru";

                label1.Text = "Когда готово, нажмите 'Развернуть'.";
                deployButton.Text = "Развернуть";
                deployRussiaButton.Text = "Развернуть (Россия)";
                AdvancedCheckBox.Text = "Расширенный режим";
                label2.Text = "Аргумент числа";
                label3.Text = "fake-gen Номер";
            }
        }

        private void deployButton_Click(object sender, EventArgs e)
        {
            Enabled = false;

            deployButton.Enabled = false;
            deployRussiaButton.Enabled = false;
            progressBar.Visible = true;

            try
            {
                bool is64BitOS = Environment.Is64BitOperatingSystem;

                string arch = "x86";

                if (is64BitOS)
                {
                    arch = "x86_64";
                }
                string randomHex = GenerateRandomHex(116);
                string russiablacklistpath = Application.StartupPath + "\\GoodbyeDPI\\russia-blacklist.txt";
                string youtubeblacklistpath = Application.StartupPath + "\\GoodbyeDPI\\russia-youtube.txt";
                if (AdvancedCheckBox.Checked == false)
                {
                    Process.Start(Application.StartupPath + "\\GoodbyeDPI\\"+arch+"\\goodbyedpi.exe", "-9 --fake-gen 29 --fake-from-hex " + randomHex + " --blacklist " + russiablacklistpath + " --blacklist " + youtubeblacklistpath);
                }
                else
                {
                    Process.Start(Application.StartupPath + "\\GoodbyeDPI\\"+arch+"\\goodbyedpi.exe", "-"+ numericArgUpDown.Value +" --fake-gen "+numericFakeGenUpDown.Value+" --fake-from-hex " + randomHex + " --blacklist " + russiablacklistpath + " --blacklist " + youtubeblacklistpath);
                }
                if (applicationlanguage == "en")
                {
                    label1.Text = "You can now close the application and restart browser.";
                }
                if (applicationlanguage == "ru")
                {
                    label1.Text = "Теперь вы можете закрыть приложение и перезапустить браузер.";
                }
            }
            catch (Exception expection)
            {
                File.WriteAllText(Application.StartupPath+"\\AngryHammerError.log",expection.Source+" | "+expection.Message);
                MessageBox.Show("Deployment Error! Fail Reasons: Some blacklists don't exist, GoodbyeDPI doesn't exist entirely, Declined Permission. ", expection.Message+" | The deployment has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar.Visible = false;
            deployRussiaButton.Enabled = true;
            deployButton.Enabled = true;

            Enabled = true;
        }

        private void AdvancedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvancedCheckBox.Checked == true)
            {
                AdvancedGroupBox.Visible = true;
            }
            else
            {
                AdvancedGroupBox.Visible = false;
            }
        }

        private void deployRussiaButton_Click(object sender, EventArgs e)
        {
            Enabled = false;

            deployButton.Enabled = false;
            deployRussiaButton.Enabled = false;
            progressBar.Visible = true;

            try
            {
                bool is64BitOS = Environment.Is64BitOperatingSystem;

                string arch = "x86";

                if (is64BitOS)
                {
                    arch = "x86_64";
                }
                string randomHex = GenerateRandomHex(116);
                string russiablacklistpath = Application.StartupPath + "\\GoodbyeDPI\\russia-blacklist.txt";
                if (AdvancedCheckBox.Checked == false)
                {
                    Process.Start(Application.StartupPath + "\\GoodbyeDPI\\" + arch + "\\goodbyedpi.exe", "-9 --fake-gen 29 --fake-from-hex " + randomHex + " --blacklist " + russiablacklistpath);
                }
                else
                {
                    Process.Start(Application.StartupPath + "\\GoodbyeDPI\\" + arch + "\\goodbyedpi.exe", "-" + numericArgUpDown.Value + " --fake-gen " + numericFakeGenUpDown.Value + " --fake-from-hex " + randomHex + " --blacklist " + russiablacklistpath);
                }
            }
            catch (Exception expection)
            {
                File.WriteAllText(Application.StartupPath + "\\AngryHammerError.log", expection.Source + " | " + expection.Message);
                MessageBox.Show("Deployment Error! Fail Reasons: Some blacklists don't exist, GoodbyeDPI doesn't exist entirely, Declined Permission. ", expection.Message + " | The deployment has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar.Visible = false;
            deployRussiaButton.Enabled = true;
            deployButton.Enabled = true;

            Enabled = true;
        }
    }
}
