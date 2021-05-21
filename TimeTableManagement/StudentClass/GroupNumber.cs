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
    class GroupNumber
    {
        public int sGroupnoID { get; set; }

        public String sgroupno { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dtgn = new DataTable();
            try
            {
                // writing sql query
                string sql = "SELECT * FROM sGroupNumber";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dtgn);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtgn;

        }

        //inserting data in to datbase

        public bool Insert(GroupNumber gn)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO sGroupNumber (sgroupno) VALUES (@sgroupno) ";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@sgroupno", gn.sgroupno);




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
        public bool Update(GroupNumber gn)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql updat data in our database
                string sql = "UPDATE sGroupNumber SET  sgroupno=@sgroupno WHERE sGroupnoID=@sGroupnoID";
                //CREAT SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creat parameters to add value
                cmd.Parameters.AddWithValue("@sgroupno", gn.sgroupno);


                cmd.Parameters.AddWithValue("@sGroupnoID", gn.sGroupnoID);

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

        public bool Delete(GroupNumber gn)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM sGroupNumber WHERE sGroupnoID=@sGroupnoID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sGroupnoID", gn.sGroupnoID);
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
