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
        public string CotNDef {get; set;}
        public string OsuDef {get; set;}
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
                OsuDef = folderBrowser.SelectedPath;
                textBox1.Text = OsuDef;
            }
            
        }
        private void cotnFinder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //If the OK button was pressed. It sets a variable to contain the file path. It also sets the textbox to have the path as well.
                CotNDef = folderBrowser.SelectedPath;
                textBox3.Text = CotNDef;
            }

        }
        private void complete_Click(object sender, EventArgs e)
        {
            this.Close();

        }
   
    }
}
