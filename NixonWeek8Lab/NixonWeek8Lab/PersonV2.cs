using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using NixonWeek7Lab;


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

        //adds record to database
        public string AddARecord()
        {
            string strResult = "";

            //Initialize connection
            SqlConnection Conn = new SqlConnection();

            //Sent connection string via Discord///INSERT CONNECTION STRING
            Conn.ConnectionString = ;

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

        //Search's database for matching data
        public DataSet SearchPersonV2(string strLastName, string strPhoneNum,bool cbHomePhone, bool cbCellPhone)
        {
            //creates dataset to be filled
            DataSet ds = new DataSet();

            //creates command for sql statement
            SqlCommand comm = new SqlCommand();

            //select statement
            String strSQL = "SELECT PersonID, FName,MName, LName, PhoneNum, Email, CellPhone, InstagramLink FROM PersonV2 WHERE 0=0";

           //if something is inputted
            if (strLastName.Length > 0)
            {
                strSQL += " AND LName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + strLastName + "%");
            }

            //if home phone is checked
             if (cbHomePhone) {
                strSQL += " AND PhoneNum LIKE @PhoneNum ";
                comm.Parameters.AddWithValue("@PhoneNum", "%" + strPhoneNum + "%");

             }

             //if cell phone is checked
            if (cbCellPhone)
            {
                strSQL += " AND CellPhone LIKE @CellPhone ";
                comm.Parameters.AddWithValue("@CellPhone", "%" + strPhoneNum + "%");
            }

            //Creating DB tools and configuring


            SqlConnection conn = new SqlConnection();

            //create the connection
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            //filling in info to command object

            //determining what connection to use 
            comm.Connection = conn;

            //Tell the command what to say
            comm.CommandText = strSQL;

            //creating data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            //get data
            conn.Open(); //open
            da.Fill(ds, "PersonV2_temp"); //fill dataset
            conn.Close(); // close

            //return data
            return ds;
        }
        //constructor 
        public PersonV2(): base()
        {
            cellPhone = "";
            instagramLink = "";
        }

        //connection to server
        private string GetConnected()
        {
            //INSERT CONNECTION STRING AFTER RETURN
            return ;
        }

        //Finds record info via ID
        public SqlDataReader FindOneRecord(int intPersonV2_ID)
        {
            //creating and initializing db tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //connection string
            string strConn = GetConnected();

            //sql command string to pull up data from PErsonV2
            string sqlString = "SELECT * FROM PersonV2 WHERE PersonID = @PersonID;";
            //telling connection info
            conn.ConnectionString = strConn;

            //passing along info needed
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPersonV2_ID);

            //open up database
            conn.Open();

            //feedback return
            return comm.ExecuteReader();
        }
    }

  
}
