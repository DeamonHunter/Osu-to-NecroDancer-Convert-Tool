using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Manual_Editer : Form
    {
        public Manual_Editer()
        {
            InitializeComponent();
            debug.activateDebugWindow();
        }
        //Declares variables for form to use.
        double bpmMilliseconds = 0, newBpmMilliseconds = 0, time = 0;
        int bpm = 100, newBpm = 0, offset = 0, newOffset = 0, minutes = 0, seconds = 0, milliseconds = 0, changeBpm = 0;
        string copyFilePath = "", saveFilePath = "", filename = "", filenameExt;
        bool hasNewBpm = false, changingBpm = false;

        Form2 debug = new Form2();
        //All of these functions are called when the appropriate button is pressed.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://necrodancer.eviltroopa.com/");
        }

        private void bpmUpDown_ValueChanged(object sender, EventArgs e)
        {
            bpm = Convert.ToInt32(bpmUpDown.Value);
            debug.enterDetails("Bpm was changed to: " + bpm);
        }

        private void offsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            offset = Convert.ToInt32(offsetUpDown.Value);
            debug.enterDetails("Offset was changed to: " + offset);
        }

        private void minutesUpDown_ValueChanged(object sender, EventArgs e)
        {
            minutes = Convert.ToInt32(minutesUpDown.Value);
            debug.enterDetails("Minutes was changed to: " + minutes);
        }

        private void secondsUpDown_ValueChanged(object sender, EventArgs e)
        {
            seconds = Convert.ToInt32(secondsUpDown.Value);
            debug.enterDetails("Seconds was changed to: " + seconds);
        }

        private void millisecondsUpDown_ValueChanged(object sender, EventArgs e)
        {
            milliseconds = Convert.ToInt32(millisecondsUpDown.Value);
            debug.enterDetails("Milliseconds was changed to: " + milliseconds);
        }

        private void bpmChangeUpDown_ValueChanged(object sender, EventArgs e)
        {
            changeBpm = Convert.ToInt32(bpmChangeUpDown.Value);
            debug.enterDetails("Changing BPM was changed to: " + changeBpm);
        }

        private void newBpmUpDown_ValueChanged(object sender, EventArgs e)
        {
            newBpm = Convert.ToInt32(newBpmUpDown.Value);
            debug.enterDetails("New BPM was changed to: " + newBpm);
        }

        private void newOffsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            newOffset = Convert.ToInt32(newOffsetUpDown.Value);
            debug.enterDetails("New offset was changed to: " + newOffset);
        }

        private void openManualButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                copyFilePath = ofd.FileName;
                filename = ofd.SafeFileName.Remove(ofd.SafeFileName.Length - 4);
                filenameExt = ofd.SafeFileName;
                textBox1.Text = ofd.FileName;
                debug.enterDetails("A new file to copy was selected: " + copyFilePath);
                manualConvertButton.Enabled = false;
            }
        }

        private void saveManualButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (Form1.is64)
            {
                sfd.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Crypt of the NecroDancer\\data\\custom_music";
            }
            else
            {
                sfd.InitialDirectory = "C:\\Program Files\\Steam\\steamapps\\common\\Crypt of the NecroDancer\\data\\custom_music";
            }
            if (filename != "" && filename != null)
            {
                sfd.FileName = filename;
            }
            else
            {
                sfd.FileName = "";
            }
            sfd.AddExtension = true;
            sfd.DefaultExt = "*.txt";
            sfd.RestoreDirectory = true;
            sfd.Filter = "Text Files| *.txt";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveFilePath = sfd.FileName;
                debug.enterDetails("Path for save file has been created: " + saveFilePath);
                textBox2.Text = sfd.FileName;
            }
            manualConvertButton.Enabled = true;
        }

        private void manualConvertButton_Click(object sender, EventArgs e)
        {
            if(bpm > 0)
            {
                bpmMilliseconds = 60000 / bpm;
                int finishtime = (minutes * 60 * 1000) + (seconds * 1000) + milliseconds;
                if ((minutes > 0 || seconds > 0 || milliseconds > 0) && finishtime > bpmMilliseconds + offset)
                {
                    if (saveFilePath != null && saveFilePath != "")
                    {
                        debug.enterDetails("Starting writing process.");
                        bpmUpDown.Enabled = false;
                        bpmChangeUpDown.Enabled = false;
                        offsetUpDown.Enabled = false;
                        newBpmUpDown.Enabled = false;
                        newOffsetUpDown.Enabled = false;
                        minutesUpDown.Enabled = false;
                        secondsUpDown.Enabled = false;
                        millisecondsUpDown.Enabled = false;
                        if (copyFilePath != null && copyFilePath != "")
                        {
                            debug.enterDetails("Copying file.");
                            string musicOriginalPath = copyFilePath;
                            string musicFilePath = saveFilePath.Remove(saveFilePath.LastIndexOf("\\")) + filenameExt;
                            try //Added some error catching. Just in case file is non existant.
                            {
                                System.IO.File.Copy(musicOriginalPath, musicFilePath, true);
                            }
                            catch
                            {
                                MessageBox.Show("Error: Unable to move file. File may be missing or the program may not have permission.", "Error");
                            }
                        }
                        StreamWriter sw = new StreamWriter(File.Create(saveFilePath));
                        debug.enterDetails("Loaded file to save.");
                        if (newBpm != 0)
                        {
                            hasNewBpm = true;
                            changingBpm = false;
                            newBpmMilliseconds = 60000 / newBpm;
                        }
                        else
                        {
                            hasNewBpm = false;
                            changingBpm = false;
                        }
                        if (changeBpm != 0)
                        {
                            hasNewBpm = false;
                            changingBpm = true;
                        }
                        time = offset;
                        while (time < finishtime)
                        {
                            if (hasNewBpm && time < newOffset)
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                time = time + bpmMilliseconds;
                            }
                            else if (hasNewBpm && time >= newOffset)
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                time = time + newBpmMilliseconds;
                            }
                            else if (changingBpm)
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                bpm = bpm + changeBpm;
                                time = time + (60000 / bpm);
                            }
                            else
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                time = time + bpmMilliseconds;
                            }
                        }
                        MessageBox.Show("Completed " + filename + ".");
                        sw.Dispose();
                        bpmUpDown.Enabled = true;
                        bpmChangeUpDown.Enabled = true;
                        offsetUpDown.Enabled = true;
                        newBpmUpDown.Enabled = true;
                        newOffsetUpDown.Enabled = true;
                        minutesUpDown.Enabled = true;
                        secondsUpDown.Enabled = true;
                        millisecondsUpDown.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to add a save location.","Error");
                    }
                }
                else
                {
                    MessageBox.Show("A time greater than one beat needs to be added.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Default Bpm needs to be higher than 0.", "Error");
            }
        }

    }
}
