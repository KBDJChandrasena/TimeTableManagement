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
    class GroupID
    {
        public int sGroupId { get; set; }

        public String sgroupidname { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dtgid = new DataTable();
            try
            {
                // writing sql query
                string sql = "SELECT * FROM sSubGroupName";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dtgid);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtgid;

        }

        //inserting data in to datbase

        public bool Insert(GroupID gid)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO sSubGroupName (sgroupidname) VALUES (@sgroupidname) ";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@sgroupidname", gid.sgroupidname);




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

        
        //creat method to delete data from database

        public bool Delete(GroupID gid)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM sSubGroupName WHERE sGroupId=@sGroupId";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sGroupId", gid.sGroupId);
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
