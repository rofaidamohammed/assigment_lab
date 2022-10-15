using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_lab
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        RichTextBox =false ;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1 .Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1 .Clear ();
        }
    }
}
