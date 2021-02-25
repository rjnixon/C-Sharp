using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NixonWeek6Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //initializing PersonV2 class
            PersonV2 temp = new PersonV2();
            //Assigning values
            temp.Feedback = "";
            temp.FName = txtFirstName.Text;
            temp.MName = txtMiddleName.Text;
            temp.LName = txtLastName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.ZipCode = txtZipCode.Text;
            temp.PhoneNum = txtPhoneNum.Text;
            temp.CellPhone = txtCellPhone.Text;
            temp.Email = txtEmail.Text;
            temp.InstagramLink = txtInstagramLink.Text;

            //if input is wrong it displays error
            if (temp.Feedback.Contains("ERROR:"))
            {
                labelFeedback.Text = temp.Feedback;

                //If input is correct  values are displayed
            } else
            {
                //labelFeedback.Text = "Information Inputted:\nFirst Name: " + temp.FName + "\nMiddle Name: " + temp.MName + "\nLast Name: " + temp.LName + "\nStreet 1: " + temp.Street1 + "\nStreet 2: " + temp.Street2 + "\nCity: " + temp.City + "\nState: " + temp.State + "\nZip Code: " + temp.ZipCode + "\nHome Phone #: " + temp.PhoneNum + "\nCell Phone #:" + temp.CellPhone + "\nEmail: " + temp.Email + "\nInstagram Username: " + temp.InstagramLink;
                //labelFeedback.Text = temp.Feedback;
                string strFeedback = temp.AddARecord();
                labelFeedback.Text = strFeedback;
            }
        }
    }
}
