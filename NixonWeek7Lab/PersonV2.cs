using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace NixonWeek6Lab
{
    //personv2 class inheriting person class
    class PersonV2 : Person
    {
        //initializing
        private string cellPhone;
        private string instagramLink;

        //get set cellhpone
        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                //validating information
                if (Validations.IsPhoneNumValid(value))
                {
                    cellPhone = value;
                } else
                {
                    Feedback += "\nERROR: " + "Cell Phone # is incorrect.";
                }
            }
        }

        //get set instagram username
        public string InstagramLink
        {
            get
            {
                return instagramLink;
            }

            set
            {
                //validating information
                if (Validations.IsInstagramLinkValid(value))
                {
                    instagramLink = value;
                } 
                else
                {
                    Feedback += "\nERROR: " + "Instagram Link is incorrect.";
                }
            }
        }

        public string AddARecord()
        {
            string strResult = "";

            //Initialize connection
            SqlConnection Conn = new SqlConnection();

            //Sent connection string via Discord
            Conn.ConnectionString = 

            string strSQL = "INSERT INTO PersonV2 (FName, MName, LName, Street1, Street2, City, State, ZipCode, PhoneNum, Email, CellPhone, InstagramLink) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @ZipCode, @PhoneNum, @Email, @CellPhone, @InstagramLink)";

            //command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn; //connection

            //Filling in values for parameters
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@ZipCode", ZipCode);
            comm.Parameters.AddWithValue("@PhoneNum", PhoneNum);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@InstagramLink", InstagramLink);

            //trying to connect to server
            try
            {
                //open connection
                Conn.Open();
                //number of records inputted
                int intRecs = comm.ExecuteNonQuery();
                //output if records successfully added
                strResult = $"Connected: Inserted {intRecs} records.";
                //close connection
                Conn.Close();
            }
            catch (Exception err)
            {
                //Error output if something goes wrong with connection
                strResult = "ERROR:" + err.Message;
            }
            finally
            {

            }

            return strResult;
        }
        //constructor 
        public PersonV2(): base()
        {
            cellPhone = "";
            instagramLink = "";
        }
    }
}
