using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Session
{
    class SessionsClass
    {

        //Creat a Getter Setter Properties
        //act as data carrier in our application

        public int ID { get; set; }

        public string LecturerName { get; set; }

        public string tag { get; set; }
        public string subjectcode { get; set; }
        public string subjectname { get; set; }
        public string group { get; set; }
        public string duration { get; set; }
        public string Numberofstudents { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selecting data from database
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                // writing sql query
                string sql = "SELECT * FROM Add_Sessions";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }// end of  method selct data from database

        //inserting data in to datbase

        public bool Insert(SessionsClass c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO Add_Sessions (LecNames, SubNames, SubCodes, SesTag, Groupname, Duration, NoOfStudent) VALUES (@LecturerName, @subjectname, @subjectcode, @tag, @group, @duration, @Numberofstudents)";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@LecturerName", c.LecturerName);
                cmd.Parameters.AddWithValue("@subjectname", c.subjectname);
                cmd.Parameters.AddWithValue("@subjectcode", c.subjectcode);
                cmd.Parameters.AddWithValue("@tag", c.tag);
                cmd.Parameters.AddWithValue("@group", c.group);
                cmd.Parameters.AddWithValue("@duration", c.duration);
                cmd.Parameters.AddWithValue("@Numberofstudents", c.Numberofstudents);


                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfuly then the value of row will be greater then zero els its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in database from this application
        public bool Update(SessionsClass c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql updat data in our database
                string sql = "UPDATE Add_Sessions SET LecNames=@LecturerName, SubNames=@subjectname,  SubCodes=@subjectcode, SesTag=@tag ,Groupname=@group, Duration=@duration, NoOfStudent=@Numberofstudents WHERE SessID=@ID";
                //CREAT SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creat parameters to add value
                cmd.Parameters.AddWithValue("@LecturerName", c.LecturerName);
                cmd.Parameters.AddWithValue("@subjectname", c.subjectname);
                cmd.Parameters.AddWithValue("@subjectcode", c.subjectcode);
                cmd.Parameters.AddWithValue("@tag", c.tag);
                cmd.Parameters.AddWithValue("@group", c.group);
                cmd.Parameters.AddWithValue("@duration", c.duration);
                cmd.Parameters.AddWithValue("@Numberofstudents", c.Numberofstudents);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                //open databse connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfuly then the value of row will be greater then zero els its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //creat method to delete data from database

        public bool Delete(SessionsClass c)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Add_Sessions WHERE SessID=@ID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                //open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfuly then the value of row will be greater then zero els its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close connection
                conn.Close();
            }
            return isSuccess;
        }


    }
}

