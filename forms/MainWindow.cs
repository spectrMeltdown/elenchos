using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Google.Protobuf.Reflection.UninterpretedOption.Types;

namespace Elenchos
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        //------------------------------------------------------------------------------------
        //----------------------------------FORM RELATED--------------------------------------
        //------------------------------------------------------------------------------------
        
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            MonthViewButton.BackColor = Color.White;
            WeekViewButton.BackColor = Color.LightCyan;
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            var exit = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.No)
            {
                Application.Exit();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MainWindowControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {

        }

        private void AccountAndSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void WeekViewButton_Click(object sender, EventArgs e)
        {
            MonthViewButton.BackColor = Color.White;
            WeekViewButton.BackColor = Color.LightCyan;
        }

        private void MonthViewButton_Click(object sender, EventArgs e)
        {
            WeekViewButton.BackColor = Color.White;
            MonthViewButton.BackColor = Color.LightCyan;
        }

        private void SundayButton_Click(object sender, EventArgs e)
        {

        }

        private void MondayButton_Click(object sender, EventArgs e)
        {

        }

        private void TuesdayButton_Click(object sender, EventArgs e)
        {

        }

        private void WednesdayButton_Click(object sender, EventArgs e)
        {

        }

        private void ThurdayButton_Click(object sender, EventArgs e)
        {

        }

        private void FridayButton_Click(object sender, EventArgs e)
        {

        }

        private void SaturdayButton_Click(object sender, EventArgs e)
        {

        }

        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        void SelectDay(RoyalButton day)
        {
            for(int x = 0; x != days.Length; x++ )
            {
                if (!(day.Text == days[x]))
                {
                    string buttonReset = days[x] + "Button" + "";
                    WeekViewButton.BackColor = Color.White;
                    MonthViewButton.BackColor = Color.LightCyan;
                }
            }
        }


        //------------------------------------------------------------------------------------
        //-----------------------------------SIDE PANEL---------------------------------------
        //------------------------------------------------------------------------------------


        //------------------------------------------------------------------------------------
        //-----------------------------------MAIN PANEL---------------------------------------
        //------------------------------------------------------------------------------------


    }
}
