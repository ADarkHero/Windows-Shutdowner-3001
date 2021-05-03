using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsShutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime lastShutdownDateTime = Properties.Settings.Default.lastShutdownDateTime;
            TimeSpan result = lastShutdownDateTime - DateTime.Now;

            //If shutdown was already planned, show in gui
            //This doesn't consider planned shutdowns from other programs (like natively via cmd)
            if (result.TotalSeconds > 0)
            {
                shutdownPlanned.Text = "Shutting down on " + lastShutdownDateTime.ToString("dd.MM.yyyy - HH:mm") + "!";
                shutdownPlanned.BackColor = Color.DarkRed;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pickShutdownHourTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void shutdownPlanned_Click(object sender, EventArgs e)
        {

        }

        private void shutdownOneHour_Click(object sender, EventArgs e)
        {
            shutdownWindowsHours(1);
        }

        private void shutdownThreeHours_Click(object sender, EventArgs e)
        {
            shutdownWindowsHours(3);
        }

        private void shutdownSixHours_Click(object sender, EventArgs e)
        {
            shutdownWindowsHours(6);
        }

        private void shutdownTwelveHours_Click(object sender, EventArgs e)
        {
            shutdownWindowsHours(12);
        }

        private void shutdownSpecificTime_Click(object sender, EventArgs e)
        {
            shutdownWindowsTimeCalc(pickShutdownTime.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancelShutdownWindows();
        }

        private void shutdownXHours_Click(object sender, EventArgs e)
        {
            shutdownWindowsHours(Convert.ToDouble(pickShutdownHourTime.Value));
        }

        /*
         * Shutdown windows in X Hours
         */
        private void shutdownWindowsHours(double v)
        {
            shutdownWindows(Convert.ToInt32(v * 3600));
        }

        /*
         * Shutdown windows in X Hours
         */
        private void shutdownWindowsTimeCalc(DateTime dt)
        {
            TimeSpan result = dt - DateTime.Now;
            shutdownWindows(Convert.ToInt32(result.TotalSeconds));
        }

        /*
         * Shutdown windows in X seconds
         */
        private void shutdownWindows(int v)
        {
            cancelShutdownWindows();

            string strCmdText;
            strCmdText = "/K shutdown -s -t " + v.ToString() + " & exit";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //Write date to setting
            DateTime shutdownDateTime = DateTime.Now.AddSeconds(v);
            Properties.Settings.Default.lastShutdownDateTime = shutdownDateTime;
            Properties.Settings.Default.Save();

            //Write date to button
            shutdownPlanned.Text = "Shutting down on " + shutdownDateTime.ToString("dd.MM.yyyy - HH:mm") + "!";
            shutdownPlanned.BackColor = Color.DarkRed;
        }

        /*
         * Cancels shutdown again
         */
        private void cancelShutdownWindows()
        {
            string strCmdText;
            strCmdText = "/K shutdown -a & exit";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //Write date to setting
            Properties.Settings.Default.lastShutdownDateTime = new DateTime(1970, 1, 1);
            Properties.Settings.Default.Save();

            //Write msg to button
            shutdownPlanned.BackColor = Color.DarkGreen;
            shutdownPlanned.Text = "There is no shutdown planned currently!";
        }

        
    }
}
