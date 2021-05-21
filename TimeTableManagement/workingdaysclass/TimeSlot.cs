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
    class TimeSlot
    {
        public string timeslotDay { get; set; }

        public string timeslotWkh { get; set; }

        public int timeslotentryId { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private SqlConnection conn;


        public DataTable Select()

        {
            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dta = new DataTable();
            try
            {

                string sql = "SELECT * FROM timeslot_wkh";



                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dta);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dta;

           
        }

        //Data insert method

        public bool Insert(TimeSlot a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO timeslot_wkh (timeslotDay,timeslotWkh) VALUES (@timeslotDay,@timeslotWkh)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@timeslotDay", a.timeslotDay);
                cmd.Parameters.AddWithValue("@timeslotWkh", a.timeslotWkh);

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

        public bool Update(TimeSlot c)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE timeslot_wkh SET timeslotDay=@timeslotDay , timeslotWkh=@timeslotWkh WHERE timeslotentryId=@timeslotentryId ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@timeslotDay", c.timeslotDay);
                cmd.Parameters.AddWithValue("@timeslotWkh", c.timeslotWkh);
                cmd.Parameters.AddWithValue("timeslotentryId", c.timeslotentryId);

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

        public bool Delete(TimeSlot c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM timeslot_wkh WHERE timeslotentryId=@timeslotentryId";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@timeslotentryId ", c.timeslotentryId);

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
