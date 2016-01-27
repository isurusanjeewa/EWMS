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
    public partial class newListForm : Form
    {
        
        public newListForm()
        {
            InitializeComponent();
        }

        public string ListName
        {
            get
            {
                return tb_list_Name.Text;
            }

            set
            {
                tb_list_Name.Text = value;
            }
        }


    }
}
