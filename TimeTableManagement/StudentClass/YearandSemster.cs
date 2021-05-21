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
    class YearandSemster
    {

        public int sYearID { get; set; }
        public String sYear { get; set; }
        public String sSem { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                // writing sql query
                string sql = "SELECT * FROM StudentyearandSem";
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

        }

        //inserting data in to datbase

        public bool Insert(YearandSemster c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO StudentyearandSem (sYear, sSem) VALUES (@sYear, @sSem) ";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@sYear", c.sYear);
                cmd.Parameters.AddWithValue("@sSem", c.sSem);
                


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
        public bool Update(YearandSemster c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql updat data in our database
                string sql = "UPDATE StudentyearandSem SET  sYear=@sYear, sSem=@sSem WHERE sYearID=@sYearID";
                //CREAT SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creat parameters to add value
                cmd.Parameters.AddWithValue("@sYear", c.sYear);
                cmd.Parameters.AddWithValue("@sSem", c.sSem);

                cmd.Parameters.AddWithValue("@sYearID", c.sYearID);

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

        public bool Delete(YearandSemster c)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM StudentyearandSem WHERE sYearID=@sYearID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sYearID", c.sYearID);
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
