using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public string CotNDir {get; set;}
        public string OsuDir {get; set;}
        public string SongDir { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        public void activateIniSetWindowbool()
        {
            this.Show(); //Shows the window if the function is called.
        }
        private void osuFinder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //If the OK button was pressed. It sets a variable to contain the file path. It also sets the textbox to have the path as well.
                OsuDir = folderBrowser.SelectedPath;
                textBox1.Text = OsuDir;
            }
            
        }
        private void cotnFinder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //If the OK button was pressed. It sets a variable to contain the file path. It also sets the textbox to have the path as well.
                CotNDir = folderBrowser.SelectedPath;
                textBox3.Text = CotNDir;
            }

        }
        private void complete_Click(object sender, EventArgs e)
        {
            if (OsuDir != null && SongDir != null && CotNDir != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Make sure all three options are chosen");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //If the OK button was pressed. It sets a variable to contain the file path. It also sets the textbox to have the path as well.
                SongDir = folderBrowser.SelectedPath;
                textBox2.Text = SongDir;
            }
        }
   
    }
}
