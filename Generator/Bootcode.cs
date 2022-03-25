using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Bootcode_Generator.Generator
{
    public class Bootcode
    {
        public void GenerateWin(string fileName, int RAM, bool autoReboot, bool showGUI)
        {
            string codeString = string.Empty;

            switch(autoReboot)
            {
                case true:
                    //If Reboot is enabled grab the Reboot-Code Template.
                    codeString = Properties.Resources.rebootCodeTemplate;

                    //Replace Filename inside the Template.
                    codeString = codeString.Replace("*fileName*", fileName);

                    //Replace RAM Value inside the Template.
                    codeString = codeString.Replace("*RAM*", RAM.ToString());

                    //Replace GUI Boolean inside the Template.
                    if(showGUI)
                    {
                        codeString = codeString.Replace("*GUI*", "");
                    }
                    else
                    {
                        codeString = codeString.Replace("*GUI*", "nogui");
                    }
                    break;

                case false:
                    //If Reboot is disabled grab the Default-Code Template.
                    codeString = Properties.Resources.defaultCodeTemplate;

                    //Replace Filename inside the Template.
                    codeString = codeString.Replace("*fileName*", fileName);

                    //Replace RAM Value inside the Template.
                    codeString = codeString.Replace("*RAM*", RAM.ToString());

                    //Replace GUI Boolean inside the Template.
                    if (showGUI)
                    {
                        codeString = codeString.Replace("*GUI*", "");
                    }
                    else
                    {
                        codeString = codeString.Replace("*GUI*", "nogui");
                    }
                    break;
            }

            while(true)
            {
                try
                {
                    //Ask the user where he wants to save the File.
                    SaveFileDialog saveFileDialog = new SaveFileDialog()
                    {
                        Filter = "Windows-Batch Befehlsdateien (*.bat)|*.bat|Windows-Command Befehlsdateien (*.cmd)|*.cmd",
                        Title = "Wo möchtest du deine Boot-Code Datei speichern?",
                        FileName = "Server-Starten.bat"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Write codeString into File.
                        File.WriteAllText(saveFileDialog.FileName, codeString, Encoding.Default);

                        //Show success message.
                        MessageBox.Show("Deine Datei wurde erfolgreich gespeichert!", "Minecraft Bootcode Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Leave loop if file is successfully written.
                    break;
                }
                catch (Exception ex)
                {
                    //Show error message.
                    if(MessageBox.Show(ex.Message, "Minecraft Bootcode Generator", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        //Leave loop if user canceled the retry.
                        break;
                    }
                }
            }
            
        }
    }
}
