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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        //Search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Initializing new personV2 class
            PersonV2 temp = new PersonV2();

            //Performing the search created in PersonV2 class / storing returned dataset as ds
            DataSet ds = temp.SearchPersonV2(txtSearchLastName.Text, txtSearchPhoneNum.Text, cbHomePhone.Checked, cbCellPhone.Checked);

            //Displaying data
            dgvSearchResults.DataSource = ds;
            dgvSearchResults.DataMember = ds.Tables["PersonV2_temp"].ToString();
        }

        //Event handler for information grab when doubleclicking data cell
        private void dgvSearchResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gathering the info
            String strPersonV2_ID = dgvSearchResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Displays ID in Popup
            MessageBox.Show(strPersonV2_ID);

            //Converts string ID to int ID
            int intPersonV2_ID = Convert.ToInt32(strPersonV2_ID);

            //creating editor form
            Form1 Editor = new Form1(intPersonV2_ID);
            Editor.ShowDialog();
        }

        private void cbPhoneChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //if home phone is checked cell phone is unchecked
        private void cbHomePhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHomePhone.Checked)
            {
                cbCellPhone.Checked = false;
            }
        }

        //if cell phone is checked home phone is unchecked
        private void cbCellPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCellPhone.Checked)
            {
                cbHomePhone.Checked = false;
            }
        }
    }
}
