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
            System.Diagnostics.Process.Start("http://necrodancer.eviltroopa.com/"); //Opens link to the website.
        }

        private void bpmUpDown_ValueChanged(object sender, EventArgs e)
        {
            bpm = Convert.ToInt32(bpmUpDown.Value); //Sets Bom
            debug.enterDetails("Bpm was changed to: " + bpm);
        }

        private void offsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            offset = Convert.ToInt32(offsetUpDown.Value); //Sets offset
            debug.enterDetails("Offset was changed to: " + offset);
        }

        private void minutesUpDown_ValueChanged(object sender, EventArgs e)
        {
            minutes = Convert.ToInt32(minutesUpDown.Value); //Sets minutes.
            debug.enterDetails("Minutes was changed to: " + minutes);
        }

        private void secondsUpDown_ValueChanged(object sender, EventArgs e)
        {
            seconds = Convert.ToInt32(secondsUpDown.Value); //Sets seconds.
            debug.enterDetails("Seconds was changed to: " + seconds);
        }

        private void millisecondsUpDown_ValueChanged(object sender, EventArgs e)
        {
            milliseconds = Convert.ToInt32(millisecondsUpDown.Value); //Sets milliseconds.
            debug.enterDetails("Milliseconds was changed to: " + milliseconds);
        }

        private void bpmChangeUpDown_ValueChanged(object sender, EventArgs e)
        {
            changeBpm = Convert.ToInt32(bpmChangeUpDown.Value); //Sets the value for how much a bom changes by per beat.
            debug.enterDetails("Changing BPM was changed to: " + changeBpm);
        }

        private void newBpmUpDown_ValueChanged(object sender, EventArgs e)
        {
            newBpm = Convert.ToInt32(newBpmUpDown.Value); //Sets a bpm change to have this bpm.
            debug.enterDetails("New BPM was changed to: " + newBpm);
        }

        private void newOffsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            newOffset = Convert.ToInt32(newOffsetUpDown.Value); //Sets a bom change to happen at this offset.
            debug.enterDetails("New offset was changed to: " + newOffset);
        }

        private void openManualButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Opens a open file dialog and if successful, enters data into relevant variables.
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                copyFilePath = ofd.FileName;
                filename = ofd.SafeFileName.Remove(ofd.SafeFileName.Length - 4);
                filenameExt = ofd.SafeFileName;
                textBox1.Text = ofd.FileName;
                debug.enterDetails("A new file to copy was selected: " + copyFilePath);
                manualConvertButton.Enabled = false; //Makes sure that the user selects a place for the file to save.
            }
        }

        private void saveManualButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (Form1.is64) //Checks if they have a 64bit system.
            {
                sfd.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Crypt of the NecroDancer\\data\\custom_music";
            }
            else
            {
                sfd.InitialDirectory = "C:\\Program Files\\Steam\\steamapps\\common\\Crypt of the NecroDancer\\data\\custom_music";
            }
            if (filename != "" && filename != null)
            {
                sfd.FileName = filename; //checks if the open file dialog was opened
            }
            else
            {
                sfd.FileName = ""; //Else sets to nothing.
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
            manualConvertButton.Enabled = true; //Opens up the convert button.
        }

        private void manualConvertButton_Click(object sender, EventArgs e)
        {
            if(bpm > 0) //First checks if bpm is greater than 0
            {
                bpmMilliseconds = 60000 / bpm;
                int finishtime = (minutes * 60 * 1000) + (seconds * 1000) + milliseconds; //Gets the time
                if ((minutes > 0 || seconds > 0 || milliseconds > 0) && finishtime > bpmMilliseconds + offset) //check that the time entered wasn't null and that it is longer than a beat.
                {
                    if (saveFilePath != null && saveFilePath != "") //Checks that it has a place to save.
                    {
                        debug.enterDetails("Starting writing process.");
                        bpmUpDown.Enabled = false; //Disables all boxes
                        bpmChangeUpDown.Enabled = false;
                        offsetUpDown.Enabled = false;
                        newBpmUpDown.Enabled = false;
                        newOffsetUpDown.Enabled = false;
                        minutesUpDown.Enabled = false;
                        secondsUpDown.Enabled = false;
                        millisecondsUpDown.Enabled = false;
                        if (copyFilePath != null && copyFilePath != "") //Checks if there is a file to copy
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
                        StreamWriter sw = new StreamWriter(File.Create(saveFilePath)); //Creates the file to save to
                        debug.enterDetails("Loaded file to save.");
                        if (newBpm != 0) //Checks if it has a second bom
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
                        if (changeBpm != 0) //checks if the bom changes per beat
                        {
                            hasNewBpm = false;
                            changingBpm = true;
                        }
                        time = offset;
                        while (time < finishtime) //Keeps running until the time passes the length
                        {
                            if (hasNewBpm && time < newOffset) //Checks if it has a new bpm but still isn't above the offset
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                time = time + bpmMilliseconds;
                            }
                            else if (hasNewBpm && time >= newOffset) //Same as above but if it is
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                time = time + newBpmMilliseconds;
                            }
                            else if (changingBpm) //If it changes per beat
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                bpm = bpm + changeBpm;
                                time = time + (60000 / bpm);
                            }
                            else //All else falls here
                            {
                                sw.WriteLine(time / 1000);
                                debug.enterDetails("Writing time at " + time);
                                time = time + bpmMilliseconds;
                            }
                        }
                        MessageBox.Show("Completed " + filename + ".");
                        sw.Dispose(); //Gets rid of file
                        bpmUpDown.Enabled = true; //Opens up boxes.
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
