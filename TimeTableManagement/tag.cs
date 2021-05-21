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

namespace TimeTableManagement.Tag
{
    public partial class tag : MetroFramework.Forms.MetroForm
    {
        int tagID;


        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection con = new SqlConnection(myconnstr);
        
        private string id;

        public tag()
        {
            InitializeComponent();
        }

        private void Tag_Load(object sender, EventArgs e)
        {

            String query1 = "Select * from Tag1";

            SqlConnection con = new SqlConnection(myconnstr);
            con.Open();

            SqlCommand cmd = new SqlCommand(query1, con);
            DataTable dt = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);

            tagNameData.AutoGenerateColumns = true;
            tagNameData.DataSource = dt;

            con.Close();
        }

        private void tagNameClrBtn_Click(object sender, EventArgs e)
        {
            tagNameTxt.Text = "";
        }

        private void tagNameSearchBox_Click(object sender, EventArgs e)
        {
            tagNameSearchBox.Text = "";
        }

        private void tagNameAddBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconnstr);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Tag1 (tag) VALUES ('" + tagNameTxt.Text + "');";
            cmd.ExecuteNonQuery();

            String query2 = "Select * from Tag1";

            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            tagNameData.DataSource = dt;

            con.Close();
        }

        private void tagNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (tagNameSrtDrpDwn.Text == "")
            {
                SqlConnection con = new SqlConnection(myconnstr);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tag1 WHERE tag LIKE '%" + tagNameSearchBox.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tagNameData.DataSource = dt;
                con.Close();
            }
            else if (tagNameSrtDrpDwn.Text == "Tag Name")
            {
                SqlConnection con = new SqlConnection(myconnstr);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tag1 WHERE tag LIKE '%" + tagNameSearchBox.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tagNameData.DataSource = dt;
                con.Close();
            }
            else if (tagNameSrtDrpDwn.Text == "ID")
            {
                SqlConnection con = new SqlConnection(myconnstr);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tag1 WHERE id LIKE '%" + tagNameSearchBox.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tagNameData.DataSource = dt;
                con.Close();
            }
        }

        private void tagNameData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void tagNameData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > 0)
            {
                DataGridViewRow selectRow = tagNameData.Rows[index];
                tagID = Int32.Parse(selectRow.Cells[0].Value.ToString());
                tagNameTxt.Text = selectRow.Cells[1].Value.ToString();

            }
        }
        

        private void tagNameEditBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconnstr);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Tag1 SET tag = '" + tagNameTxt.Text + "' WHERE id = '" + tagID + "'";
            cmd.ExecuteNonQuery();

            String query2 = "Select * from Tag1";

            SqlDataAdapter sda = new SqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            tagNameData.DataSource = dt;

            con.Close();

            MessageBox.Show("Updated Succesfully");

        }



        private void tagNameDltBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(myconnstr);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM [dbo].[Tag1] WHERE id=" + tagID + "";
                cmd.ExecuteNonQuery();

                String query2 = "select id, tag from Tag1";

                SqlDataAdapter sda = new SqlDataAdapter(query2, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tagNameData.DataSource = dt;


                con.Close();

                MessageBox.Show("Generated Group Number Deleted Successfully", "Delete Successful");
            }
        
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }

        private void tagNameData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index > 0)
            {
                DataGridViewRow selectRow = tagNameData.Rows[index];
                tagID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            }
        }
    }
}
