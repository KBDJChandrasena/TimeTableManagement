using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.StudentClass
{
    class Programme
    {
        public int sPID { get; set; }
        public String sProgramme { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dtp = new DataTable();
            try
            {
                // writing sql query
                string sql = "SELECT * FROM StudentProgramme";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dtp);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtp;

        }

        //inserting data in to datbase

        public bool Insert(Programme p)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO StudentProgramme (sProgramme) VALUES (@sProgramme) ";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@sProgramme", p.sProgramme);
             



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
        public bool Update(Programme p)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql updat data in our database
                string sql = "UPDATE StudentProgramme SET  sProgramme=@sProgramme WHERE sPID=@sPID";
                //CREAT SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creat parameters to add value
                cmd.Parameters.AddWithValue("@sProgramme", p.sProgramme);
               

                cmd.Parameters.AddWithValue("@sPID", p.sPID);

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

        public bool Delete(Programme p)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM StudentProgramme WHERE sPID=@sPID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sPID", p.sPID);
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
