using System;
using System.Windows.Forms;
using Minecraft_Bootcode_Generator.Generator;

namespace Minecraft_Bootcode_Generator
{
    public partial class MainForm : Form
    {
        private readonly Bootcode bootcode = new Bootcode();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Generate_Win_Click(object sender, EventArgs e)
        {
            //Remove Spaces in the Filename.
            ServerFileName_Win.Text = ServerFileName_Win.Text.Replace(" ", "");

            //Check if the Filename is filled.
            if(ServerFileName_Win.TextLength > 0)
            {
                //Check if user filled in the Filename with the File extension. If not, insert it automaticly.
                if(!ServerFileName_Win.Text.Contains(".jar"))
                {
                    ServerFileName_Win.Text += ".jar";
                }
            }
            else
            {
                //Return error Message if user didn't filled the Filename.
                MessageBox.Show("Bitte trage einen Dateinamen ein.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Set variables to values
            bool autoReboot = AutomaticReboot_Win.Checked;
            bool showGUI = ShowGUI_Win.Checked;
            int RAM = Convert.ToInt32(ServerRAM_Win.Value); //NumericUpAndDown dosen't support decimals. (No Data loss)

            //Generate Bootcode with prefences.
            bootcode.GenerateWin(ServerFileName_Win.Text, RAM, autoReboot, showGUI);
        }

    }
}
