﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
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

            }
            if (lang == "ru")
            {
                applicationlanguage = "ru";

                label1.Text = "Когда готово, нажмите 'Развернуть'.";
                deployButton.Text = "Развернуть";
                AdvancedCheckBox.Text = "Расширенный режим";
                label2.Text = "Аргумент числа";
                label3.Text = "fake-gen Номер";
            }
        }

        private void deployButton_Click(object sender, EventArgs e)
        {
            deployButton.Enabled = false;
            progressBar.Visible = true;

            try
            {
                string randomHex = GenerateRandomHex(116);
                string russiablacklistpath = Application.StartupPath + "\\GoodbyeDPI\\russia-blacklist.txt";
                string youtubeblacklistpath = Application.StartupPath + "\\GoodbyeDPI\\russia-youtube.txt";
                if (AdvancedCheckBox.Checked == false)
                {
                    Process.Start(Application.StartupPath + "\\GoodbyeDPI\\x86_64\\goodbyedpi.exe", "-9 --fake-gen 29 --fake-from-hex " + randomHex + " --blacklist " + russiablacklistpath + " --blacklist " + youtubeblacklistpath);
                }
                else
                {
                    Process.Start(Application.StartupPath + "\\GoodbyeDPI\\x86_64\\goodbyedpi.exe", "-"+ numericArgUpDown.Value +" --fake-gen "+numericFakeGenUpDown.Value+" --fake-from-hex " + randomHex + " --blacklist " + russiablacklistpath + " --blacklist " + youtubeblacklistpath);
                }
            }
            catch (Exception expection)
            {
                File.WriteAllText(Application.StartupPath+"\\AngryHammerError.log",expection.Source+" | "+expection.Message);
                MessageBox.Show("Deployment Error! Fail Reasons: Some blacklists don't exist, GoodbyeDPI doesn't exist entirely, Declined Permission. ", expection.Message+" | The deployment has failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar.Visible = false;
            deployButton.Enabled = true;
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
    }
}
