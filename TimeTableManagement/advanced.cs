using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagement.Advanced
{
    public partial class advanced : MetroFramework.Forms.MetroForm
    {

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstr);

        public advanced()
        {
            InitializeComponent();
        }

        private void Advanced_Load(object sender, EventArgs e)
        {
            /*
            timeCmbBox.Items.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("select * from WorkingTimeSlot", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                timeCmbBox.Items.Add(dataRow["TimeSlot"].ToString());
            }
            */


            //Input time
            /*
            this.itmCmbBox.DataSource = null;
            timeCmbBox.Items.Clear();
            string query = "select * from WorkingTime";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "TimeSlot");
            timeCmbBox.DisplayMember = "TimeSlot";
            timeCmbBox.ValueMember = "WorkingTimeSlotID";
            timeCmbBox.DataSource = ds.Tables["TimeSlot"];
            con.Close();
            timeCmbBox.SelectedIndex = -1;
            */



            /*
            sesCmb01.Items.Clear();
            parSesCmbBox01.Items.Clear();
            notOverlapSesCmbBox01.Items.Clear();
            SqlDataAdapter sda2 = new SqlDataAdapter("select * from Sessions", con);
            DataTable dataTable2 = new DataTable();
            sda2.Fill(dataTable2);
            foreach (DataRow dataRow in dataTable2.Rows)
            {
                sesCmb01.Items.Add(dataRow["SubjectCode"].ToString() + " " + dataRow["Tag"].ToString() + " By " + dataRow["Lecturer"].ToString() + " for " + dataRow["GroupID"].ToString());
                parSesCmbBox01.Items.Add(dataRow["SubjectCode"].ToString() + " " + dataRow["Tag"].ToString() + " By " + dataRow["Lecturer"].ToString() + " for " + dataRow["GroupID"].ToString());
                notOverlapSesCmbBox01.Items.Add(dataRow["SubjectCode"].ToString() + " " + dataRow["Tag"].ToString() + " By " + dataRow["Lecturer"].ToString() + " for " + dataRow["GroupID"].ToString());
            }
            */


            this.sesCmb01.DataSource = null;
            sesCmb01.Items.Clear();

            this.parSesCmbBox01.DataSource = null;
            parSesCmbBox01.Items.Clear();

            this.notOverlapSesCmbBox01.DataSource = null;
            notOverlapSesCmbBox01.Items.Clear();

            string query2 = "select SessID, (SubCodes + ' ' + SesTag + ' By ' + LecNames + ' for ' + Groupname) AS NAME from Add_Sessions";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, conn);
            conn.Open();
            DataSet ds2 = new DataSet();
            da2.Fill(ds2, "Add_Sessions");

            sesCmb01.DisplayMember = "NAME";
            sesCmb01.ValueMember = "SessID";
            sesCmb01.DataSource = ds2.Tables["Add_Sessions"];

            parSesCmbBox01.DisplayMember = "NAME";
            parSesCmbBox01.ValueMember = "SessID";
            parSesCmbBox01.DataSource = ds2.Tables["Add_Sessions"];

            notOverlapSesCmbBox01.DisplayMember = "NAME";
            notOverlapSesCmbBox01.ValueMember = "SessID";
            notOverlapSesCmbBox01.DataSource = ds2.Tables["Add_Sessions"];

            conn.Close();
            sesCmb01.SelectedIndex = -1;
            parSesCmbBox01.SelectedIndex = -1;
            notOverlapSesCmbBox01.SelectedIndex = -1;


            /*
            sesCmb02.Items.Clear();
            parSesCmbBox02.Items.Clear();
            notOverlapSesCmbBox02.Items.Clear();
            SqlDataAdapter sda3 = new SqlDataAdapter("select * from Sessions", con);
            DataTable dataTable3 = new DataTable();
            sda3.Fill(dataTable3);
            foreach (DataRow dataRow in dataTable3.Rows)
            {
                sesCmb02.Items.Add(dataRow["SubjectCode"].ToString() + " " + dataRow["Tag"].ToString() + " By " + dataRow["Lecturer"].ToString() + " for " + dataRow["GroupID"].ToString());
                parSesCmbBox02.Items.Add(dataRow["SubjectCode"].ToString() + " " + dataRow["Tag"].ToString() + " By " + dataRow["Lecturer"].ToString() + " for " + dataRow["GroupID"].ToString());
                notOverlapSesCmbBox02.Items.Add(dataRow["SubjectCode"].ToString() + " " + dataRow["Tag"].ToString() + " By " + dataRow["Lecturer"].ToString() + " for " + dataRow["GroupID"].ToString());
            }
            */

            this.sesCmb02.DataSource = null;
            sesCmb02.Items.Clear();

            this.parSesCmbBox02.DataSource = null;
            parSesCmbBox02.Items.Clear();

            this.notOverlapSesCmbBox02.DataSource = null;
            notOverlapSesCmbBox02.Items.Clear();

            string query3 = "select SessID, (SubCodes + ' ' + SesTag + ' By ' + LecNames + ' for ' + Groupname) AS NAME from Add_Sessions";
            SqlDataAdapter da3 = new SqlDataAdapter(query3, conn);
            conn.Open();
            DataSet ds3 = new DataSet();
            da3.Fill(ds3, "Add_Sessions");

            sesCmb02.DisplayMember = "NAME";
            sesCmb02.ValueMember = "SessID";
            sesCmb02.DataSource = ds3.Tables["Add_Sessions"];

            parSesCmbBox02.DisplayMember = "NAME";
            parSesCmbBox02.ValueMember = "SessID";
            parSesCmbBox02.DataSource = ds3.Tables["Add_Sessions"];

            notOverlapSesCmbBox02.DisplayMember = "NAME";
            notOverlapSesCmbBox02.ValueMember = "SessID";
            notOverlapSesCmbBox02.DataSource = ds3.Tables["Add_Sessions"];

            sesCmb02.SelectedIndex = -1;
            parSesCmbBox02.SelectedIndex = -1;
            notOverlapSesCmbBox02.SelectedIndex = -1;


        
            String query5 = "select id,Sessions01,Sessions2 from ConsecutiveSession";

            SqlCommand cmd2 = new SqlCommand(query5, conn);
            DataTable dt2 = new DataTable();
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);


            consecData.AutoGenerateColumns = true;
            consecData.DataSource = dt2;

            conn.Close();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tabPageLecAdd_Click(object sender, EventArgs e)
        {

        }

        private void addConBtn_Click(object sender, EventArgs e)
        {

            if ((sesCmb01.Text != string.Empty) && (sesCmb02.Text != string.Empty))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String ID = "";

                if (sesCmb01.SelectedItem != null)
                {
                    DataRowView drv = sesCmb01.SelectedItem as DataRowView;
                    ID = drv.Row["SessID"].ToString();
                }

                String ID2 = "";

                if (sesCmb02.SelectedItem != null)
                {
                    DataRowView drv = sesCmb02.SelectedItem as DataRowView;
                    ID2 = drv.Row["SessID"].ToString();
                }

                cmd.CommandText = "INSERT INTO [dbo].[ConsecutiveSession] ([Sessions01],[Sessions2],[Sessions01Ref],[Sessions2Ref]) VALUES('" + sesCmb01.Text + "','" + sesCmb02.Text + "'," + ID + "," + ID2 + ")";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Consecutive Session Added");

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            String query5 = "select id,Sessions01,Sessions2 from ConsecutiveSession";

            SqlCommand cmd2 = new SqlCommand(query5, conn);
            DataTable dt2 = new DataTable();
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            dt2.Load(sdr2);

            consecData.AutoGenerateColumns = true;
            consecData.DataSource = dt2;

            conn.Close();
        }

        private void addParBtn_Click(object sender, EventArgs e)
        {

            if ((parSesCmbBox01.Text != string.Empty) && (parSesCmbBox02.Text != string.Empty) && (parSesDurationCmb.Text != string.Empty) && (parSesDayCmb.Text != string.Empty) && (parSesTimeSlotCmbStart.Text != string.Empty))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String ID = "";

                if (parSesCmbBox01.SelectedItem != null)
                {
                    DataRowView drv = parSesCmbBox01.SelectedItem as DataRowView;
                    ID = drv.Row["SessID"].ToString();
                }

                String ID2 = "";

                if (parSesCmbBox02.SelectedItem != null)
                {
                    DataRowView drv = parSesCmbBox02.SelectedItem as DataRowView;
                    ID2 = drv.Row["SessID"].ToString();
                }

                cmd.CommandText = "INSERT INTO [dbo].[ParallelSession] ([Session01] ,[Session02] ,[Duration] ,[Day] ,[StartTime] ,[EndTime],[Session01Ref] ,[Session02Ref]) VALUES ('" + parSesCmbBox01.Text + "' ,'" + parSesCmbBox02.Text + "' , " + parSesDurationCmb.Text + " ,'" + parSesDayCmb.Text + "' ,'" + parSesTimeSlotCmbStart.Text + "','" + parSesTimeSlotCmbEnd.Text + "' ," + ID + " ," + ID2 + ")";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Parallel Session Added");
                conn.Close();

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNotOverlapSesBtn_Click(object sender, EventArgs e)
        {

            if ((notOverlapSesCmbBox01.Text != string.Empty) && (notOverlapSesCmbBox02.Text != string.Empty) && (notOverlapSesDurationCmbBox.Text != string.Empty) && (notOverlapSesDayCmbBox.Text != string.Empty) && (notOverlapSesTimeSlotCmbBoxStart.Text != string.Empty))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                String ID = "";

                if (notOverlapSesCmbBox01.SelectedItem != null)
                {
                    DataRowView drv = notOverlapSesCmbBox01.SelectedItem as DataRowView;
                    ID = drv.Row["SessID"].ToString();
                }

                String ID2 = "";

                if (notOverlapSesCmbBox02.SelectedItem != null)
                {
                    DataRowView drv = notOverlapSesCmbBox02.SelectedItem as DataRowView;
                    ID2 = drv.Row["SessID"].ToString();
                }

                cmd.CommandText = "INSERT INTO [dbo].[NotOverlapSession] ([Session01],[Session02],[Duration],[Day],[StartTime],[EndTime],[Session01Ref],[Session02Ref]) VALUES ('" + notOverlapSesCmbBox01.Text + "' ,'" + notOverlapSesCmbBox02.Text + "' , " + notOverlapSesDurationCmbBox.Text + " ,'" + notOverlapSesDayCmbBox.Text + "' ,'" + notOverlapSesTimeSlotCmbBoxStart.Text + "','" + notOverlapSesTimeSlotCmbBoxEnd.Text + "' ," + ID + " ," + ID2 + ")";

                cmd.ExecuteNonQuery();
                MessageBox.Show("Should Not Overlap Session Added");
                conn.Close();

            }
            else
            {
                MessageBox.Show("All fields must be filled", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            sesCmb01.SelectedIndex = -1;
            sesCmb02.SelectedIndex = -1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            parSesCmbBox01.SelectedIndex = -1;
            parSesCmbBox02.SelectedIndex = -1;
            parSesDayCmb.SelectedIndex = -1;
            parSesDurationCmb.SelectedIndex = -1;
            parSesTimeSlotCmbStart.SelectedIndex = -1;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            notOverlapSesCmbBox01.SelectedIndex = -1;
            notOverlapSesCmbBox02.SelectedIndex = -1;
            notOverlapSesDayCmbBox.SelectedIndex = -1;
            notOverlapSesDurationCmbBox.SelectedIndex = -1;
            notOverlapSesTimeSlotCmbBoxStart.SelectedIndex = -1;

        }

        private void consecSearchBox_TextChanged(object sender, EventArgs e)


        {

            if (consecSearchDrpDown.Text == "")
            {
                SqlConnection conn = new SqlConnection(myconnstr);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,Sessions01,Sessions2 from ConsecutiveSession where Sessions01 LIKE '%" + consecSearchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                consecData.DataSource = dt;
                conn.Close();
            }
            if (consecSearchDrpDown.Text == "ID")
            {
                SqlConnection conn = new SqlConnection(myconnstr);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,Sessions01,Sessions2 from ConsecutiveSession where id LIKE '%" + consecSearchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                consecData.DataSource = dt;
                conn.Close();
            }
            if (consecSearchDrpDown.Text == "Sessions01")
            {
                SqlConnection conn = new SqlConnection(myconnstr);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,Sessions01,Sessions2 from ConsecutiveSession where Sessions01 LIKE '%" + consecSearchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                consecData.DataSource = dt;
                conn.Close();
            }
            if (consecSearchDrpDown.Text == "Sessions2")
            {
                SqlConnection conn = new SqlConnection(myconnstr);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select id,Sessions01,Sessions2 from ConsecutiveSession where Sessions2 LIKE '%" + consecSearchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                consecData.DataSource = dt;
                conn.Close();
            }
        }

        private void metroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }

        private void consecutiveSessions_Click(object sender, EventArgs e)
        {

        }
    }
}
