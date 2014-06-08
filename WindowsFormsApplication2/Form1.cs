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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //This if statement checks if the directory exists. 
            //It assumes that both necrodancer folder and osu folder are within the directory
            if (Directory.Exists("C:/Program Files (x86)"))
            {
                is64 = true;               
            }
        }
        //Declares a few variables to use
        string fileToOpen, fileToSave, nameOfFile, nameOfFileExt;
        int selectedIndex;
        static public bool is64;
        OpenFileDialog ofd = new OpenFileDialog(); //Creates an open File dialog for program to manipulate.

        private void openOsuFileButton_Click(object sender, EventArgs e)
        {
            switch (selectedIndex)
            {
                case 0:
                    ofd.Filter = "Osu Beatmap File|*.osu"; //Sets the default to only show .osu files.
                    //Checks the bool created before then uses it to set the default directory.
                    if (is64)
                    {
                        ofd.InitialDirectory = "C:\\Program Files (x86)\\osu!\\Songs";
                    }
                    else
                    {
                        ofd.InitialDirectory = "C:\\Program Files\\osu!\\Songs";
                    }

                    ofd.RestoreDirectory = true; //Just to make sure that multiple runs come to the same directory. It may be unneeded.
                    break;
                default:
                    break;
            }

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //If the OK button was pressed. It sets a variable to contain the file path. It also sets the textbox to have the path as well.
                nameOfFile = "";
                textBox1.Text = ofd.FileName;
                fileToOpen = ofd.FileName;

                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName)); //Opens the file to read
                switch (selectedIndex)
                {
                    case 0:
                        while (nameOfFile == "") //As the file was set to "" before it will force this loop.
                        {
                            string line; //Sets a variable to store the data of the line
                            line = sr.ReadLine();
                            if (line.IndexOf("AudioFilename:") != -1) //Checks if "AudioFilename:" exists within the line.
                            {
                                string output = line.Remove(0, 14); //Removes AudioFileName:
                                nameOfFileExt = output; //Sets the name of the song with extension.
                                output = output.Remove(output.Length - 4); //Removes extension.
                                nameOfFile = output;
                            }
                        }                        
                        sr.Dispose(); //Removes the file from memory.
                        break;
                    default:
                        break;
                }
                textBox2.Text = nameOfFile; //Sets the second textbox to have the file name. unessesary but is a little bit of feedback.
                saveLocationButton.Enabled = true; //Activates 2nd step button.
                convertOkButton.Enabled = false; //Incase the program has already ran through once.
                textBox1.Enabled = true;
                textBox2.Enabled = false;
            }
        }

        private void saveLocationButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog(); //Opens a Save file Dialog.
            ofd.Filter = "Text Files|*.txt";
            ofd.AddExtension = true; //Makes sure to set the extension to .txt no matter what.
            ofd.DefaultExt = ".txt";
            ofd.RestoreDirectory = true;
            ofd.FileName = nameOfFile;
            if (is64)
            {
                ofd.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Crypt of the NecroDancer\\data\\custom_music";
            }
            else
            {
                ofd.InitialDirectory = "C:\\Program Files\\Steam\\steamapps\\common\\Crypt of the NecroDancer\\data\\custom_music";
            }

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = ofd.FileName; //Sets the final path of the file to save.
                fileToSave = ofd.FileName;
            }
            convertOkButton.Enabled = true; //Activates step 4 button.
            textBox2.Enabled = true;
        }

        private void convertOkButton_Click(object sender, EventArgs e)
        {
            //Now this is where it gets crazy. Sorry for my crappy code writing skills.
            if (checkBox1.Checked) //If copy file was selected then it copies the file with a few edited values.
            {
                string musicOriginalPath = fileToOpen.Remove(fileToOpen.LastIndexOf("\\")) + "\\" + nameOfFileExt.Remove(0, 1);
                string musicFilePath = fileToSave.Remove(fileToSave.LastIndexOf(".txt")) + ".mp3";
                try //Added some error catching. Just in case file is non existant.
                {
                    System.IO.File.Copy(musicOriginalPath, musicFilePath, true);
                }
                catch
                {
                    MessageBox.Show("Error: Unable to move file. File may be missing or the program may not have permission.", "Error");
                }
            }

            Form2 f2 = new Form2(); //Calls forth the debug form. Needed otherwise the code will complain that it hasn't been called.

            if (showDebugCheckBox.Checked) //If the show Debug was selected, it will show debug window. This does not have much purpose though :/.
            {
                f2.activateDebugWindow();
            }
            switch (selectedIndex)
            {
                case 0:
                    f2.enterDetails("Starting sequence for .osu files.");
                    bool found = false, continueRead = true, finishTimeFound = false, firstRun = true;
                    int lines = 0, position;
                    string carryOverLine = "", line;
                    char comma = Convert.ToChar(",");
                    double bpmMilliseconds, carryOverBpm = 0, time = 0, carryOverOffset = 0, startOffset = 0;
                    //A whole lot of variables called for the remainder of this function.
                    //Some of these may be unnecessary. I need help to clean it up.

                    StreamReader sr = new StreamReader(File.OpenRead(fileToOpen)); //Opens the file to read.
                    f2.enterDetails("Loaded file to read");
                    StreamWriter sw = new StreamWriter(File.Create(fileToSave)); //Opens the file to write. It will overwrite existing files.
                    f2.enterDetails("Save file loaded");
                    while (found == false) //Finds where the timing points are
                    {
                        lines++;
                        line = sr.ReadLine();
                        f2.enterDetails(lines + ": " + line);
                        if (line.IndexOf("[TimingPoints]") != -1) //Searches for "[TimingPoints]". The osu file has no space for it.
                        {
                            found = true;
                            f2.enterDetails("Found Timing points at line " + lines);
                        }
                    }
                    while (continueRead == true) //Sets a statement that is only fuffilled if the final beat was found.
                    {
                        if (firstRun == true) //Completes variables that are empty. Otherwise it will use the previous runs variables.
                        {
                            line = sr.ReadLine();
                            f2.enterDetails("First timing point = " + line);
                        }
                        else
                        {
                            line = carryOverLine;
                            f2.enterDetails("Converted line to " + line);
                        }

                        if (firstRun == true)
                        {
                            string tempLine3 = line; //Creates a temporary line
                            f2.enterDetails("Creating Temporary Line " + tempLine3);
                            position = tempLine3.IndexOf(",");
                            tempLine3 = tempLine3.Remove(tempLine3.IndexOf(",")); //cuts the line from the first "," point.
                            f2.enterDetails("Shortened Temporary Line to " + tempLine3);
                            startOffset = Convert.ToDouble(tempLine3); //Converts to an int.
                            f2.enterDetails("First offset is " + startOffset);

                            position = line.IndexOf(",");
                            tempLine3 = line; //Resets the temporary line.
                            f2.enterDetails("Replacing Temporary Line with " + tempLine3);
                            tempLine3 = tempLine3.Remove(0, position + 1); //Removes the first portion including the comma.
                            for (int i = 0; i < 6; i++) //Removes the last 6 commas. This is due to the comma and period being considered the same. (BPM has a period)
                            {
                                tempLine3 = tempLine3.Remove(tempLine3.LastIndexOf(","));
                            }
                            f2.enterDetails("Shortened Temporary Line to " + tempLine3);
                            bpmMilliseconds = Convert.ToDouble(tempLine3); //Converts this into the first Bpm indication
                            f2.enterDetails("The bpm in milliseconds is " + bpmMilliseconds);
                            if (checkBox2.Checked) //If the adds beats checkbox was checked. It will make the start offset as close to zero as possible.
                            {
                                while (startOffset > bpmMilliseconds)
                                {
                                    startOffset = startOffset - bpmMilliseconds;
                                }
                                time = startOffset / 1000;
                            }
                            else //Else it will set it to the normal offset
                            {
                                time = startOffset / 1000;
                            }
                            firstRun = false; //Makes sure that the program does not execute these lines again. 
                        }
                        else
                        {
                            startOffset = carryOverOffset; //Sets the values from the last run through
                            f2.enterDetails("New start offset is " + startOffset);
                            time = startOffset / 1000;
                            bpmMilliseconds = carryOverBpm;
                            f2.enterDetails("The new bpm in milliseconds is " + bpmMilliseconds);
                        }
                        carryOverBpm = -1; //Needed to make the program acces the following while loop.
                        while (carryOverBpm < 0) //InHerited timing sections have a negetive Bpm value. As such it's needed to find the next value.
                        {
                            f2.enterDetails("The Bpm was lower than 0. Finding the next timing point with bpm change.");
                            carryOverLine = sr.ReadLine(); //Reads the line.
                            if (carryOverLine == "" || carryOverLine == null) //Checks if the value was null. This would then mean that it reached the end of the Timing Sections.
                            {
                                f2.enterDetails("No suitable timing section found. Finding last note for end time.");
                                string result = "", result2 = ""; //Sets three variables
                                int i = 0;
                                while (result2 != "[HitObjects]") //Checks where the hit Object section is
                                {
                                    result = result2;
                                    result2 = sr.ReadLine();
                                    i++;
                                    f2.enterDetails(i + " " + result2);
                                }
                                result2 = "adasda"; //Just so it doesn't trick the next while loop.
                                f2.enterDetails("Found the HitObjects section.");
                                i = 0;
                                while (result2 != null) //Checks until the very last line. (Or after Hitobjects are finished.)
                                {
                                    i++;
                                    result = result2; //Makes sure that the value is actually there.
                                    result2 = sr.ReadLine();
                                    f2.enterDetails(i + " " + result2);
                                }
                                finishTimeFound = true; //Sets two variable that control the overall while loop
                                continueRead = false;
                                f2.enterDetails("Found the final beat. It is " + result);
                                string tempLine2 = result; //Creats a temporary Lne.
                                f2.enterDetails("Creating temporary line with " + result);
                                tempLine2 = tempLine2.Remove(0, tempLine2.IndexOf(",") + 1);
                                tempLine2 = tempLine2.Remove(0, tempLine2.IndexOf(",") + 1); //Removes the first two sections. These are the coordinates of the hitobject.
                                f2.enterDetails("Changed temporary line to " + tempLine2);
                                tempLine2 = tempLine2.Remove(tempLine2.IndexOf(",")); //Removes the rest of the line.
                                f2.enterDetails("Changed temp line to " + tempLine2);
                                carryOverOffset = Convert.ToDouble(tempLine2);
                                f2.enterDetails("The song length is " + carryOverOffset + " milliseconds");
                                carryOverBpm = bpmMilliseconds; //Sets the bpm to this to get out of while loop
                                f2.enterDetails("Set Bpm to " + bpmMilliseconds);
                            }
                            else
                            {
                                //This sectiion checks the next line and sets variables.
                                f2.enterDetails("Going to next line.");
                                position = carryOverLine.IndexOf(",");
                                string tempLine2 = carryOverLine.Remove(0, position + 1);
                                f2.enterDetails("Creating a temporary line of " + tempLine2);
                                tempLine2 = tempLine2.Remove(tempLine2.IndexOf(","));
                                f2.enterDetails("Shortened temp line to " + tempLine2);
                                carryOverBpm = Convert.ToDouble(tempLine2);
                                f2.enterDetails("The new bpm will be " + carryOverBpm);
                                tempLine2 = carryOverLine;
                                f2.enterDetails("Resetting temporary line to " + tempLine2);
                                carryOverOffset = Convert.ToDouble(tempLine2.Remove(position));
                                f2.enterDetails("The new offset will be " + carryOverOffset);
                            }
                        }
                        f2.enterDetails("Creating times from " + time + " to " + carryOverOffset);
                        while (time < carryOverOffset / 1000) //A while loop that checks whether the beats are still under time.
                        {
                            if (finishTimeFound == true) //May be an unnecessary if function. I forgot if this actually did anything.
                            {
                                if (time < 0) //Checks if time is below zero as some offsets are in the negeatives
                                {
                                    time += (bpmMilliseconds / 1000);
                                }
                                else
                                {
                                    if (carryOverOffset / 1000 > time + (bpmMilliseconds / 1000)) //checks if it will go over the next offset.
                                    {
                                        sw.WriteLine(time);
                                        time += (bpmMilliseconds / 1000);
                                    }
                                    else
                                    {
                                        sw.WriteLine(time);
                                        time = carryOverOffset; //Makes sure that it sets the values correctly.
                                    }
                                }
                            }
                            else //I honestly don't know if this is needed anymore.
                            {
                                if (time < 0)
                                {
                                    time += (bpmMilliseconds / 1000);
                                }
                                else
                                {
                                    if (carryOverOffset / 1000 > time + (bpmMilliseconds / 1000))
                                    {
                                        sw.WriteLine(time);
                                        time += (bpmMilliseconds / 1000);
                                    }
                                    else
                                    {
                                        sw.WriteLine(time);
                                        time = carryOverOffset / 1000;
                                    }
                                }
                            }
                        }
                        f2.enterDetails("Completed a round."); //Adds a line to say that while loop has finished a runthrough
                    }
                    sr.Dispose(); //Deletes the two files from memory.
                    sw.Dispose();
                    f2.enterDetails("Song Completed");
                    MessageBox.Show("Your song " + nameOfFile + " is completed", "Song Complete"); //Shows a messagebox to the user to notify them that the program is finished.
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = (int)comboBox1.SelectedIndex; //Upon the combobox updating, it will check the value.
            switch (selectedIndex) //It then sets the value for the program to use while setting up the final parts in most steps.
            {
                case 0: //The Default, .osu files.
                    label3.Text = "Open a .osu file from your preferred song.";
                    convertOkButton.Enabled = false; 
                    openOsuFileButton.Enabled = true; //Makes sure that all steps are set up properly so program does not break.
                    saveLocationButton.Enabled = false;
                    textBox1.Text = "Please select a .osu file for the program to convert.";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox2.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    showDebugCheckBox.Checked = false;
                    break;
                case 1: //To be decided.
                    label3.Text = "Open a *To Be dicided* file from your preferred song.";
                    convertOkButton.Enabled = false;
                    openOsuFileButton.Enabled = false;
                    saveLocationButton.Enabled = false;
                    textBox1.Text = "This option is not available just yet.";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox2.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    showDebugCheckBox.Checked = false;
                    break;
                case 2: //Will open up a new form with the ability to have manually set options. (Coming Soon).
                    Manual_Editer f3 = new Manual_Editer();
                    f3.Show();
                    label3.Text = "Manual editing.";
                    convertOkButton.Enabled = false;
                    openOsuFileButton.Enabled = false;
                    saveLocationButton.Enabled = false;
                    textBox1.Text = "This option opens up a new form.";
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox2.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    showDebugCheckBox.Checked = false;
                    break;
                default:
                    break;
            }
        }
    }
}
