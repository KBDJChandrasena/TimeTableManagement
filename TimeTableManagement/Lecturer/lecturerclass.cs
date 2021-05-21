using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Lecturer
{
    class LecturerClass
    {
        // Creat a Getter Setter Proerties
        public int ID { get; set; }
        public string LecID  { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public string Building { get; set; }
        public string Center { get; set; }
        public string Level { get; set; }
        public float Rank { get; set; }


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Selecting Data from Databse

       
        public DataTable Select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                // writing sql query
                string sql = "SELECT * FROM Lecture";
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


        //inserting data in to datbase

        public bool Insert(LecturerClass c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;

            //step 1 Connect databse
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 creat a sql query to insert data
                string sql = "INSERT INTO Lecture ( LecID, Name, Faculty, Department, Building, Center, LecLevel, Rank ) VALUES (@LecID, @Name, @Faculty, @Department, @Building, @Center, @Level, @Rank) ";
                // creat sql Command using sql conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating to parameter to add data
                cmd.Parameters.AddWithValue("@LecID", c.LecID);
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Faculty", c.Faculty);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Building", c.Building);
                cmd.Parameters.AddWithValue("@Center", c.Center);
                cmd.Parameters.AddWithValue("@Level", c.Level);

                if (c.Level.Equals("Professor"))
                {
                    Rank = 1;
                }
                else if (c.Level.Equals("Assistant Professor"))
                {
                    Rank = 2;
                }
                else if (c.Level.Equals("Senior Lecturer(HG)"))
                {
                    Rank = 3;
                }
                else if (c.Level.Equals("Senior Lecturer"))
                {
                    Rank = 4;
                }
                else if (c.Level.Equals("Lecturer"))
                {
                    Rank = 5;
                }
                else if (c.Level.Equals("Assistant Lecturer"))
                {
                    Rank = 6;
                }
                else
                {
                    Rank = 7;
                }

                cmd.Parameters.AddWithValue("@Rank", c.Rank + "." + c.LecID);


               
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
        public bool Update(LecturerClass c)
        {
            //Creating a default reture type and setting its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql updat data in our database
                string sql = "UPDATE Lecture SET  LecID=@LecID, Name=@Name, Faculty=@Faculty, Department=@Department ,Building=@Building, Center=@Center, LecLevel=@Level, Rank=@Rank WHERE ID=@ID";
                //CREAT SQL COMMAND
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creat parameters to add value
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@LecID", c.LecID);
                cmd.Parameters.AddWithValue("@Faculty", c.Faculty);
                cmd.Parameters.AddWithValue("@Department", c.Department);
                cmd.Parameters.AddWithValue("@Building", c.Building);
                cmd.Parameters.AddWithValue("@Center", c.Center);
                cmd.Parameters.AddWithValue("@Level", c.Level);
                //GENARATE LEVEL
                if (c.Level.Equals("Professor"))
                {
                    Rank = 1;
                }
                else if (c.Level.Equals("Assistant Professor"))
                {
                    Rank = 2;
                }
                else if (c.Level.Equals("Senior Lecturer(HG)"))
                {
                    Rank = 3;
                }
                else if (c.Level.Equals("Senior Lecturer"))
                {
                    Rank = 4;
                }
                else if (c.Level.Equals("Lecturer"))
                {
                    Rank = 5;
                }
                else if (c.Level.Equals("Assistant Lecturer"))
                {
                    Rank = 6;
                }
                else
                {
                    Rank = 7;
                }

                cmd.Parameters.AddWithValue("@Rank", c.Rank + "." + c.LecID);

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

        public bool Delete(LecturerClass c)
        {
            //creat a default return value and set its value to false
            bool isSuccess = false;
            //creat sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM Lecture WHERE ID=@ID";

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
