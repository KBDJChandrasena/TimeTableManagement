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
    class DaysOfWorking
    {
        public int workingdayID { get; set; }
        public string day1 { get; set; }
        public string day2 { get; set; }

        public string day3 { get; set; }
        public string day4 { get; set; }

        public string day5 { get; set; }
        public string day6 { get; set; }

        public string day7 { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private SqlConnection conn;

        public DataTable Select()

        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dtd = new DataTable();
            try
            {

                string sql = "SELECT * FROM working_days";



                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dtd);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtd;






        }
        //Data insert method

        public bool Insert(DaysOfWorking d)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO working_days (day1,day2,day3,day4,day5,day6,day7) VALUES (@day1,@day2,@day3,@day4,@day5,@day6,@day7)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@day1", d.day1);
                cmd.Parameters.AddWithValue("@day2", d.day2);
                cmd.Parameters.AddWithValue("@day3", d.day3);
                cmd.Parameters.AddWithValue("@day4", d.day4);
                cmd.Parameters.AddWithValue("@day5", d.day5);
                cmd.Parameters.AddWithValue("@day6", d.day6);
                cmd.Parameters.AddWithValue("@day7", d.day7);


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

        public bool Update(DaysOfWorking d)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE working_days SET day1=@day1 , day2=@day2 , day3=@day3, day4=@day4, day5=@day5, day6=@day6 ,day7=@day7 WHERE workingdayID=@workingdayID ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@day1", d.day1);
                cmd.Parameters.AddWithValue("@day2", d.day2);
                cmd.Parameters.AddWithValue("@day3", d.day3);
                cmd.Parameters.AddWithValue("@day4", d.day4);
                cmd.Parameters.AddWithValue("@day5", d.day5);
                cmd.Parameters.AddWithValue("@day6", d.day6);
                cmd.Parameters.AddWithValue("@day7", d.day7);
                cmd.Parameters.AddWithValue("workingdayID", d.workingdayID);

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

        public bool Delete(DaysOfWorking d)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM working_days WHERE workingdayID=@workingdayID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@workingdayID ", d.workingdayID);

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
