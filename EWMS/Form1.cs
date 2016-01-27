using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EWMS
{
    public partial class Form1 : Form
    {
        private string currentListName;
        private DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void createNewList_fn()
        {
            using (newListForm form = new newListForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    currentListName = form.ListName;
                }
            }
            Text = "Emigrated Worker Management System - " + currentListName;

            table = new DataTable(currentListName);
            DataColumn col_name = new DataColumn("Name of Emmigrated Women");
            DataColumn col_address = new DataColumn("Address");
            DataColumn col_nic = new DataColumn("NIC No");
            DataColumn col_passport = new DataColumn("Passport No");
            DataColumn col_ms = new DataColumn("Marital Status");
            DataColumn col_spouse = new DataColumn("Name of Spouse");
            DataColumn col_children = new DataColumn("Names of Children");
            DataColumn col_protector = new DataColumn("Name of Protector");
            DataColumn col_isProtector = new DataColumn("Is protector still available", typeof(Boolean));
            DataColumn col_Benefits = new DataColumn("Benefited from Emmigration", typeof(Boolean));
            DataColumn col_remarks = new DataColumn("Additional Notes");

            table.Columns.Add(col_name);
            table.Columns.Add(col_address);
            table.Columns.Add(col_nic);
            table.Columns.Add(col_passport);
            table.Columns.Add(col_ms);
            table.Columns.Add(col_spouse);
            table.Columns.Add(col_children);
            table.Columns.Add(col_protector);
            table.Columns.Add(col_isProtector);
            table.Columns.Add(col_Benefits);
            table.Columns.Add(col_remarks);

        
        }
        public string CurrentListName
        {
            get
            {
                return currentListName;
            }

            set
            {
                currentListName = value;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void newListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createNewList_fn();
        }
    }
}
