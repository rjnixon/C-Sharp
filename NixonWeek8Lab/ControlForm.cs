using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NixonWeek6Lab;

namespace NixonWeek7Lab
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        //Add record Event handler
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //creating new form1
            Form1 temp = new Form1();
            temp.Show();
        }

        //Search record Event handler
        private void btnSearchRecord_Click(object sender, EventArgs e)
        {
            //Creating new SearchForm
            SearchForm temp = new SearchForm();
            temp.ShowDialog();
        }
    }
}
