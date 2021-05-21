using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.workingdaysclass
{
    class workingdays
    {
        //getter and setter properties
        public string numOfday { get; set; }
        public int dayentryId { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private SqlConnection conn;


        public DataTable Select()

        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {

                string sql = "SELECT * FROM num_of_days";



                SqlCommand cmd = new SqlCommand(sql, conn);

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
        //insert data
        public bool Insert(workingdays c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO num_of_days (numOfday) VALUES (@numOfday)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@numOfday", c.numOfday);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        //Update data

        public bool Update(workingdays c)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE num_of_days SET numOfday=@numOfday WHERE dayentryId=@dayentryId ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@numOfday", c.numOfday);
                cmd.Parameters.AddWithValue("dayentryId", c.dayentryId);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
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

        
        

        //Delete method

        public bool Delete(workingdays c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM num_of_days WHERE dayentryId=@dayentryId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@dayentryId ", c.dayentryId);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

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

        

    }
}
