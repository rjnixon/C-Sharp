using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NixonWeek7Lab;

namespace NixonWeek6Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form1 that passes in person ID
        public Form1(int intPersonV2_ID)
        {
            InitializeComponent();

            //gathering info and creating PersonV2 class of info
            PersonV2 temp = new PersonV2();
            //store in data reader
            SqlDataReader dr = temp.FindOneRecord(intPersonV2_ID);


            //loops through info to fill out form
            while (dr.Read())
            {

                //fills out info in form
                txtFirstName.Text = dr["FName"].ToString();
                txtMiddleName.Text = dr["MName"].ToString();
                txtLastName.Text = dr["LName"].ToString();
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZipCode.Text = dr["ZipCode"].ToString();
                txtPhoneNum.Text = dr["PhoneNum"].ToString();
                txtCellPhone.Text = dr["CellPhone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtInstagramLink.Text = dr["InstagramLink"].ToString();

                //upper right hand corner displays id #
                lblPersonV2_ID.Text = dr["PersonID"].ToString();
                
            }
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
