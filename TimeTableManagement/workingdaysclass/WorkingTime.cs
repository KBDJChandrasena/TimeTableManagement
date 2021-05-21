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
    class WorkingTime
    {
        public int workingTimeEId { get; set; }
        public string whours { get; set; }
        public string wmins { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private SqlConnection conn;

        public DataTable Select()

        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dtb = new DataTable();
            try
            {

                string sql = "SELECT * FROM working_time_wkh";



                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dtb);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtb;






        }
        //Data insert method

        public bool Insert(WorkingTime b)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO working_time_wkh (whours,wmins) VALUES (@whours,@wmins)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@whours", b.whours);
                cmd.Parameters.AddWithValue("@wmins", b.wmins);

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

        //Data Update method

        public bool Update(WorkingTime b)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE working_time_wkh SET whours=@whours , wmins=@wmins WHERE workingTimeEId=@workingTimeEId ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@whours", b.whours);
                cmd.Parameters.AddWithValue("@wmins", b.wmins);
                cmd.Parameters.AddWithValue("workingTimeEId", b.workingTimeEId);

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
        //Delete Method

        public bool Delete(WorkingTime b)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM working_time_wkh WHERE workingTimeEId=@workingTimeEId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@workingTimeEId ", b.workingTimeEId);

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
