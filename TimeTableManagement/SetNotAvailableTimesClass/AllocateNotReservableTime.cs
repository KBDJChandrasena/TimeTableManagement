using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.SetNotAvailableTimesClass
{
    class AllocateNotReservableTime
    {
        public int anrtID { get; set; }
        public String room { get; set; }

        public String notRtime { get; set; }
        public String startTimer { get; set; }
        public String endTimer { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private SqlConnection conn;


        public DataTable Select()

        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable anr = new DataTable();
            try
            {

                string sql = "SELECT * FROM AllocateNotReservableTime";



                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(anr);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return anr;

        }

        //Data insert method

        public bool Insert(AllocateNotReservableTime anr)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO AllocateNotReservableTime (room,notRtime,startTimer,endTimer) VALUES (@room,@notRtime,@startTimer,@endTimer)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@room", anr.room);
                cmd.Parameters.AddWithValue("@notRtime", anr.notRtime);
                cmd.Parameters.AddWithValue("@startTimer", anr.startTimer);
                cmd.Parameters.AddWithValue("@endTimer", anr.endTimer);
                



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
    }
}
