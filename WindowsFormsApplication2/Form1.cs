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
using System.Media;
using TagLib;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        //Declares a few variables to use
        string fileToOpen, fileToSave, nameOfFile, songNameOfFile, nameOfFileExt;
        string[] performers = new string[1];
        int selectedIndex;
        static public bool is64;
        public string CotNDef, OsuDef;

        public Form1()
        {
            InitializeComponent();
            //This if statement checks if the directory exists. 
            
            //This is to find the initial directories of both the osu opener and the cotn opener.
            if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Osu To NecroDancer Convert Tool\\Settings.txt")) //Sees if a settings file exists.
            {
                //If it does, it opens it up and reads the two lines within
                StreamReader sr = new StreamReader(System.IO.File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + "Osu To NecroDancer Convert Tool\\Settings.txt"));
                OsuDef = sr.ReadLine();
                CotNDef = sr.ReadLine();
                sr.Dispose();
            }
            else
            {
                //If it doesn't, it attempts to create the file (and the directory)
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Osu To NecroDancer Convert Tool");
                StreamWriter sw = new StreamWriter(System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "Osu To NecroDancer Convert Tool\\Settings.txt"));

                //This then calls form 3 and waits for the user to input
                Form3 f3 = new Form3();
                f3.ShowDialog();

                //After inputting variables, these are then defined...
                OsuDef = f3.OsuDef;
                CotNDef = f3.CotNDef;
                //then written into the file
                sw.WriteLine(OsuDef);
                sw.WriteLine(CotNDef);
                sw.Flush();
                sw.Dispose();
            }

            ofdOsu.InitialDirectory = OsuDef; //Sets default path for the osu button
            ofdOsu.Filter = "Osu Beatmap File|*.osu"; //Sets the default to only show .osu files.
            ofdOsu.RestoreDirectory = false;

            sfdCotn.InitialDirectory = CotNDef; //Sets default path for the sotn button
            sfdCotn.Filter = "Text Files|*.txt";
            sfdCotn.AddExtension = true; //Makes sure to set the extension to .txt no matter what.
            sfdCotn.DefaultExt = ".txt";
            sfdCotn.RestoreDirectory = false;
        }

        SaveFileDialog sfdCotn = new SaveFileDialog(); //Creates an open File dialog for program to manipulate.
        OpenFileDialog ofdOsu = new OpenFileDialog();

        private void openOsuFileButton_Click(object sender, EventArgs e)
        {
            if (ofdOsu.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //If the OK button was pressed. It sets a variable to contain the file path. It also sets the textbox to have the path as well.
                nameOfFile = "";
                textBox1.Text = ofdOsu.FileName;
                fileToOpen = ofdOsu.FileName;

                StreamReader sr = new StreamReader(System.IO.File.OpenRead(ofdOsu.FileName)); //Opens the file to read
 
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

                sr = new StreamReader(System.IO.File.OpenRead(ofdOsu.FileName));
                songNameOfFile = "";
                while (songNameOfFile == "") //As the file was set to "" before it will force this loop.
                {
                    string line; //Sets a variable to store the data of the line
                    line = sr.ReadLine();
                    if (line.IndexOf("Title:") != -1) //Checks if "AudioFilename:" exists within the line.
                    {
                        string output = line.Remove(0, 6); //Removes AudioFileName:
                        songNameOfFile = output;
                    }

                }
                sr = new StreamReader(System.IO.File.OpenRead(ofdOsu.FileName));
                performers[0] = "";
                while (performers[0] == "") //As the file was set to "" before it will force this loop.
                {
                    string line; //Sets a variable to store the data of the line
                    line = sr.ReadLine();
                    if (line.IndexOf("Artist:") != -1) //Checks if "AudioFilename:" exists within the line.
                    {
                        string output = line.Remove(0, 7); //Removes AudioFileName:
                        performers[0] = output;
                    }

                }

                sr.Dispose(); //Removes the file from memory.
                if (nameOfFileExt.IndexOf(".mp3") != -1)
                {
                    textBox2.Text = nameOfFile; //Sets the second textbox to have the file name. unessesary but is a little bit of feedback.
                    saveLocationButton.Enabled = true; //Activates 2nd step button.
                    convertOkButton.Enabled = false; //Incase the program has already ran through once.
                    textBox1.Enabled = true;
                    textBox2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("This beatmap does not use a supported music file type of NecroDancer.");
                }
            }
        }

        private void saveLocationButton_Click(object sender, EventArgs e)
        {

            sfdCotn.FileName = nameOfFileExt.ToUpper() + ".txt";

            if (sfdCotn.ShowDialog() == System.Windows.Forms.DialogResult.OK && sfdCotn.FileName.IndexOf(".txt") != -1)
            {
                textBox2.Text = sfdCotn.FileName; //Sets the final path of the file to save.
                fileToSave = sfdCotn.FileName;
            }
            else if (sfdCotn.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = sfdCotn.FileName + ".txt"; //Sets the final path of the file to save.
                fileToSave = sfdCotn.FileName + ".txt";
            }
            convertOkButton.Enabled = true; //Activates step 4 button.
            textBox2.Enabled = true;
        }

        private void convertOkButton_Click(object sender, EventArgs e)
        {
            //Now this is where it gets crazy. Sorry for my crappy code writing skills.
            string musicOriginalPath = fileToOpen.Remove(fileToOpen.LastIndexOf("\\")) + "\\" + nameOfFileExt.Remove(0, 1);
            string musicFilePath = fileToSave.Remove(fileToSave.LastIndexOf(".txt"));
            
            if (checkBox1.Checked) //If copy file was selected then it copies the file with a few edited values.
            {
                try //Added some error catching. Just in case file is non existant.
                {
                    System.IO.File.Copy(musicOriginalPath, musicFilePath, true);
                    if (fixSongCheckBox.Checked)
                    {
                        MessageBox.Show(songNameOfFile + ":" + performers[0]);
                        TagLib.File musicFile = TagLib.File.Create(musicFilePath);
                        musicFile.Tag.Title = songNameOfFile;
                        musicFile.Tag.Performers = performers;
                        musicFile.Save();
                    }
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
                f2.enterDetails("Starting sequence for .osu files.");
                bool found = false, continueRead = true, firstRun = true;
                int lines = 0, position;
                string carryOverLine = "", line;
                char comma = Convert.ToChar(",");
                float bpmMilliseconds, carryOverBpm = 0, time = 0, carryOverOffset = 0, startOffset = 0;
                //A whole lot of variables called for the remainder of this function.

                StreamReader sr = new StreamReader(System.IO.File.OpenRead(fileToOpen)); //Opens the file to read.
                StreamWriter sw = new StreamWriter(System.IO.File.Create(fileToSave)); //Opens the file to write. It will overwrite existing files.

                while (found == false) //Finds where the timing points are
                {
                    lines++;
                    line = sr.ReadLine();
                    if (line.IndexOf("[TimingPoints]") != -1) //Searches for "[TimingPoints]". The osu file has no space for it.
                    {
                        found = true;
                        f2.enterDetails("Found Timing points at line " + lines);
                    }
                }

                while (continueRead) //Sets a statement that is only fuffilled if the final beat was found.
                {
                    if (firstRun) //Completes variables that are empty. Otherwise it will use the previous runs variables.
                    {
                        //Finds the initial starting time of the first beat
                        line = sr.ReadLine();
                        f2.enterDetails("First timing point = " + line);
                        startOffset = Convert.ToSingle(line.Remove(line.IndexOf(",")));
                        f2.enterDetails("First offset is " + startOffset);
                        
                        line = line.Remove(0, line.IndexOf(",") + 1); //Removes the first portion including the comma.
                        for (int i = 0; i < 6; i++) //Removes the last 6 commas. This is due to the comma and period being considered the same. (BPM has a period)
                        {
                            line = line.Remove(line.LastIndexOf(","));
                        }
                        bpmMilliseconds = Convert.ToSingle(line); //Converts this into the first Bpm indication
                        f2.enterDetails("The bpm in milliseconds is " + bpmMilliseconds);

                        if (checkBox2.Checked) //If the adds beats checkbox was checked. It will make the start offset as close to zero as possible.
                        {
                            while (startOffset > bpmMilliseconds)
                            {
                                startOffset = startOffset - bpmMilliseconds;
                            }
                        }

                        time = startOffset / 1000;
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

                    do
                    {
                        f2.enterDetails("Finding the next timing point with bpm change.");
                        carryOverLine = sr.ReadLine(); //Reads the line.
                        if (carryOverLine == "" || carryOverLine == null) //Checks if the value was null. This would then mean that it reached the end of the Timing Sections.
                        {
                            TagLib.File musicFile = TagLib.File.Create(musicOriginalPath);

                            carryOverOffset = Convert.ToSingle(musicFile.Properties.Duration.TotalMilliseconds);
                            continueRead = false;
                            carryOverBpm = bpmMilliseconds;
                            f2.enterDetails("The final offset will be " + carryOverOffset);
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
                            carryOverBpm = Convert.ToSingle(tempLine2);
                            f2.enterDetails("The new bpm will be " + carryOverBpm);
                            tempLine2 = carryOverLine;
                            f2.enterDetails("Resetting temporary line to " + tempLine2);
                            carryOverOffset = Convert.ToSingle(tempLine2.Remove(position));
                            f2.enterDetails("The new offset will be " + carryOverOffset);
                        }
                    } while (carryOverBpm <= 0);

                    f2.enterDetails("Creating times from " + time + " to " + carryOverOffset);
                    while (time < carryOverOffset / 1000) //A while loop that checks whether the beats are still under time.
                    {
                        if (time >= 0) //Checks if time is below zero as some offsets are in the negeatives
                        {
                            if (carryOverOffset / 1000 > time + (bpmMilliseconds / 1000)) //checks if it will go over the next offset.
                            {
                                sw.WriteLine(time);
                            }
                        }
                        time += (bpmMilliseconds / 1000);                                     
                    }

                    f2.enterDetails("Completed a round."); //Adds a line to say that while loop has finished a runthrough
                }
                sr.Dispose(); //Deletes the two files from memory.
                sw.Dispose();
                f2.enterDetails("Song Completed");
                MessageBox.Show("Your song " + nameOfFile + " is completed", "Song Complete"); //Shows a messagebox to the user to notify them that the program is finished.
            
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
                case 2: //To be decided.
                    label3.Text = "Open a *To Be decided* file from your preferred song.";
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
                case 1: //Will open up a new form with the ability to have manually set options. (Coming Soon).
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
