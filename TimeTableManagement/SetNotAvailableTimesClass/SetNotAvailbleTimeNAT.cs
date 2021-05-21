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
    class SetNotAvailbleTimeNAT
    {

        public int sheduleId { get; set; }

        public String Type { get; set; }

        public String Item { get; set; }
        public String startTime { get; set; }

        public String endTime { get; set; }

        public String day { get; set; } 


        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private SqlConnection conn;

        public DataTable Select()

        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dtf = new DataTable();
            try
            {

                string sql = "SELECT * FROM SetNotAvailableTime";



                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dtf);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtf;

        }

        //Data insert method

        public bool Insert(SetNotAvailbleTimeNAT f)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO SetNotAvailableTime (Type,Item,startTime,endTime,day) VALUES (@Type,@Item,@startTime,@endTime,@day)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Type", f.Type);
                cmd.Parameters.AddWithValue("@Item", f.Item);
                cmd.Parameters.AddWithValue("@startTime", f.startTime);
                cmd.Parameters.AddWithValue("@endTime", f.endTime);
                cmd.Parameters.AddWithValue("@day", f.day);



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

        public bool Update(SetNotAvailbleTimeNAT f)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE SetNotAvailableTime SET Type=@Type , Item=@Item , startTime=@startTime, endTime=@endTime, day=@day  WHERE sheduleId=@sheduleId ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Type", f.Type);
                cmd.Parameters.AddWithValue("@Item", f.Item);
                cmd.Parameters.AddWithValue("@startTime", f.startTime);
                cmd.Parameters.AddWithValue("@endTime", f.endTime);
                cmd.Parameters.AddWithValue("@day", f.day);

                cmd.Parameters.AddWithValue("sheduleId", f.sheduleId);

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

        public bool Delete(SetNotAvailbleTimeNAT f)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM SetNotAvailableTime WHERE sheduleId=@sheduleId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@sheduleId ", f.sheduleId);

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

