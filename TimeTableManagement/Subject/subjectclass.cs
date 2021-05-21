using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Subject
{
    class SubjectClass
    {
        //Creat a Getter Setter Properties
        //act as data carrier in our application

        public int ID { get; set; }

        public string SubjectName { get; set; }

        public string SubjectCode { get; set; }
        public string OfferedYear { get; set; }
        public string OfferedSemester { get; set; }
        public string NumberofLecHours { get; set; }
        public string NumberofTuteHours { get; set; }
        public string NumberofLabHours { get; set; }
        public string NumberofEvaluHours { get; set; }


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
                string sql = "SELECT * FROM Add_Subject";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Dataadapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }// end of  method selct data from database

        //inserting data in to datbase

        public bool Insert (SubjectClass c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO Add_Subject (SubCode, SubName, OfferedYear, OfferedSem, LecHours, TuteHours, LabHours, EvaHours) VALUES (@SubjectCode, @SubjectName, @OfferedYear, @OfferedSemeste, @NumberofLecHours, @NumberofTuteHours, @NumberofLabHours, @NumberofEvaluHours) ";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@OfferedYear", c.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemeste", c.OfferedSemester);
                cmd.Parameters.AddWithValue("@NumberofLecHours", c.NumberofLecHours);
                cmd.Parameters.AddWithValue("@NumberofTuteHours", c.NumberofTuteHours);
                cmd.Parameters.AddWithValue("@NumberofLabHours", c.NumberofLabHours);
                cmd.Parameters.AddWithValue("@NumberofEvaluHours", c.NumberofEvaluHours);


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
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Method to update data in database from this application
        public bool Update (SubjectClass c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql updat data in our database
                string sql = "UPDATE Add_Subject SET SubCode=@SubjectCode, SubName=@SubjectName, OfferedYear=@OfferedYear ,OfferedSem=@OfferedSemeste, LecHours=@NumberofLecHours, TuteHours=@NumberofTuteHours, LabHours=@NumberofLabHours, EvaHours=@NumberofEvaluHours WHERE ID=@ID";
                //CREAT SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creat parameters to add value
                cmd.Parameters.AddWithValue("@SubjectCode", c.SubjectCode);
                cmd.Parameters.AddWithValue("@SubjectName", c.SubjectName);
                cmd.Parameters.AddWithValue("@OfferedYear", c.OfferedYear);
                cmd.Parameters.AddWithValue("@OfferedSemeste", c.OfferedSemester);
                cmd.Parameters.AddWithValue("@NumberofLecHours", c.NumberofLecHours);
                cmd.Parameters.AddWithValue("@NumberofTuteHours", c.NumberofTuteHours);
                cmd.Parameters.AddWithValue("@NumberofLabHours", c.NumberofLabHours);
                cmd.Parameters.AddWithValue("@NumberofEvaluHours", c.NumberofEvaluHours);
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
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //creat method to delete data from database

        public bool Delete(SubjectClass c)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Add_Subject WHERE ID=@ID";

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
            catch(Exception ex)
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
