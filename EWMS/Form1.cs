using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EWMS
{
    public partial class Form1 : Form
    {
        private Form newList = new frmGetListName();
        public String currentLIST;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            textBox1.Text = startupPath;
        }

        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            newList.Show();
        }

        
    }
}
