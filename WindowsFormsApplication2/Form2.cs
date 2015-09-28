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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void activateDebugWindow()
        {
            this.Show(); //Shows the window if the function is called.
        }

        public void enterDetails(string entered)
        {
            //richTextBox1.Text = entered + "\n" + richTextBox1.Text; //Adds the given line to the top of the textbox.
        }
    }
}
