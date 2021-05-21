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

namespace TimeTableManagement.Session
{
    public partial class Sessions : MetroFramework.Forms.MetroForm
    {
        public Sessions()
        {
            InitializeComponent();
        }

        SessionsClass c = new SessionsClass();
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private string lecturer = "";
        private object ID;
        // add session tab................................................................

        private void btnSesSaveAdd_Click(object sender, EventArgs e)
        {
            if (IsValidSave())
            {
                //Get value from input fiellds

                c.LecturerName = lectextBox.Text;
                c.subjectname = subtextBox2.Text;
                c.subjectcode = cmbSesSubAdd.Text;
                c.tag = cmbSesTagAdd.Text;
                c.group = cmbSesGroupAdd.Text;
                c.duration = DurationUpDown1.Text;
                c.Numberofstudents = NoOfStuUpDown2.Text;

                //inserting data into the database 
                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("New Session Successfully Insert");
                    //Call the clear method here
                    ClearFieldsAfterSave();
                }
                else
                {
                    MessageBox.Show("Error");
                }

                // LOAD DATA 
                DataTable dt = c.Select();
                metroGrid1.DataSource = dt;
            }

        }


        private void Sessions_Load(object sender, EventArgs e)
        {

            GetSubjects();
            GetLecturers();
            GetTags();
            GetGroups();
            GetGroup();
            //load data from database
            DataTable dt = c.Select();
            metroGrid1.DataSource = dt;

            tabControlSession.SelectedTab = tabPageSesEdit;
        }

        private void btnSesClearAdd_Click(object sender, EventArgs e)
        {
            //clear method
            ClearFieldsAfterSave();
        }

        private void ClearFieldsAfterSave()
        {
            lectextBox.Clear();
            lecturer = "";
            subtextBox2.Clear();
            cmbSesLecAdd.SelectedIndex = -1;
            cmbSesTagAdd.SelectedIndex = -1;
            cmbSesGroupAdd.SelectedIndex = -1;
            DurationUpDown1.Value = 0;
            NoOfStuUpDown2.Value = 0;
        }

        //save validate 
        private bool IsValidSave()
        {
            if ((lectextBox.Text == string.Empty) || (subtextBox2.Text == string.Empty)
                || (cmbSesSubAdd.Text == string.Empty) || (DurationUpDown1.Text == string.Empty)
                || (cmbSesTagAdd.Text == string.Empty) || (cmbSesGroupAdd.Text == string.Empty) || (NoOfStuUpDown2.Text == string.Empty))
            {
                MessageBox.Show("Fill the all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //clear selected lecturer list
        private void metroButton2_Click(object sender, EventArgs e)
        {
            cmbSesLecAdd.SelectedIndex = -1;
            lecturer = "";
            lectextBox.Clear();

        }
        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            cmbSesLecEdit.SelectedIndex = -1;
            lecturer = "";
            textBox2.Clear();
        }




        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lecturer = lecturer + cmbSesLecAdd.Text + ", ";

            lectextBox.Text = lecturer;

        }

        private void cmbSesLecEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            lecturer = lecturer + cmbSesLecEdit.Text + ", ";

            textBox2.Text = lecturer;
        }

        //getsubject in databse.................
        public void GetSubjects()
        {
            SqlConnection conn = new SqlConnection(myconnstr);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT SubCode, OfferedYear FROM Add_Subject order by OfferedYear";

            cmd.ExecuteNonQuery();

            DataTable dtsubjects = new DataTable();

            SqlDataAdapter dasubjects = new SqlDataAdapter(cmd);

            dasubjects.Fill(dtsubjects);

            foreach (DataRow dr in dtsubjects.Rows)
            {
                cmbSesSubAdd.Items.Add(dr["SubCode"].ToString());
            }

            foreach (DataRow dr in dtsubjects.Rows)
            {
                cmbSesSubjectEdit.Items.Add(dr["SubCode"].ToString());
            }

            conn.Close();
        }
        //load subject into the text box............................
        private void cmbSesSubjectEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = cmbSesSubjectEdit.Text;

            SqlConnection conn = new SqlConnection(myconnstr);

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT SubName FROM Add_Subject Where SubCode = '" + keyword + "'", conn);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            string data = reader["SubName"].ToString();

            reader.Close();
            conn.Close();

            textBox1.Text = data;
        }
        private void cmbSesSubAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = cmbSesSubAdd.Text;

            SqlConnection conn = new SqlConnection(myconnstr);

            conn.Open();

            SqlCommand command = new SqlCommand("SELECT SubName FROM Add_Subject Where SubCode = '" + keyword + "'", conn);

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            string data = reader["SubName"].ToString();

            reader.Close();
            conn.Close();

            subtextBox2.Text = data;

        }

        public void GetLecturers()
        {
            SqlConnection conn = new SqlConnection(myconnstr);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT Name FROM Lecture order by Name";

            cmd.ExecuteNonQuery();

            DataTable dtlecturers = new DataTable();

            SqlDataAdapter dalecturers = new SqlDataAdapter(cmd);

            dalecturers.Fill(dtlecturers);

            foreach (DataRow dr in dtlecturers.Rows)
            {
                cmbSesLecAdd.Items.Add(dr["Name"].ToString());
            }

            foreach (DataRow dr in dtlecturers.Rows)
            {
                cmbSesLecEdit.Items.Add(dr["Name"].ToString() + ", ");
            }

            conn.Close();
        }

        public void GetTags()
        {
            SqlConnection conn = new SqlConnection(myconnstr);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT tag FROM Tag1";

            cmd.ExecuteNonQuery();

            DataTable dttags = new DataTable();

            SqlDataAdapter datags = new SqlDataAdapter(cmd);

            datags.Fill(dttags);

            foreach (DataRow dr in dttags.Rows)
            {
                cmbSesTagAdd.Items.Add(dr["tag"].ToString());
            }

            foreach (DataRow dr in dttags.Rows)
            {
                cmbSesTagEdit.Items.Add(dr["tag"].ToString());
            }

            conn.Close();
        }


        public void GetGroups()
        {
            if (cmbSesTagAdd.Text == "Lab")
            {
                SqlConnection con = new SqlConnection(myconnstr);

                con.Open();
                cmbSesGroupAdd.Items.Clear();
                SqlCommand cmd2 = con.CreateCommand();

                cmd2.CommandType = CommandType.Text;

                cmd2.CommandText = "SELECT GenSubGrpNum FROM GenSubGroupNumber order by GenSubGrpNum";

                cmd2.ExecuteNonQuery();

                DataTable dtgroups = new DataTable();

                SqlDataAdapter dagroups = new SqlDataAdapter(cmd2);

                dagroups.Fill(dtgroups);

                foreach (DataRow dr in dtgroups.Rows)
                {
                    cmbSesGroupAdd.Items.Add(dr["GenSubGrpNum"].ToString());
                }

                
                con.Close();
            }
            else
            {
                SqlConnection con = new SqlConnection(myconnstr);
                con.Open();
                cmbSesGroupAdd.Items.Clear();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT GenGrpNum FROM GenGroupNumber order by GenGrpNum";

                cmd.ExecuteNonQuery();

                DataTable dtgroups = new DataTable();

                SqlDataAdapter dagroups = new SqlDataAdapter(cmd);

                dagroups.Fill(dtgroups);

                foreach (DataRow dr in dtgroups.Rows)
                {
                    cmbSesGroupAdd.Items.Add(dr["GenGrpNum"].ToString());
                }

                con.Close();
            }
        }
        public void GetGroup()
        {
            SqlConnection con = new SqlConnection(myconnstr);
            if (cmbSesTagEdit.Text == "Lab")
            {
                con.Open();
                cmbSesGroupEdit.Items.Clear();
                SqlCommand cmd2 = con.CreateCommand();

                cmd2.CommandType = CommandType.Text;

                cmd2.CommandText = "SELECT GenSubGrpNum FROM GenSubGroupNumber order by GenSubGrpNum";

                cmd2.ExecuteNonQuery();

                DataTable dtgroups = new DataTable();

                SqlDataAdapter dagroups = new SqlDataAdapter(cmd2);

                dagroups.Fill(dtgroups);

                foreach (DataRow dr in dtgroups.Rows)
                {
                    cmbSesGroupEdit.Items.Add(dr["GenSubGrpNum"].ToString());
                }


                con.Close();
            }
            else
            {
                con.Open();
                cmbSesGroupEdit.Items.Clear();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT GenGrpNum FROM GenGroupNumber order by GenGrpNum";

                cmd.ExecuteNonQuery();

                DataTable dtgroups = new DataTable();

                SqlDataAdapter dagroups = new SqlDataAdapter(cmd);

                dagroups.Fill(dtgroups);

                foreach (DataRow dr in dtgroups.Rows)
                {
                    cmbSesGroupEdit.Items.Add(dr["GenGrpNum"].ToString());
                }

                con.Close();
            }
        }

        //load data into the text box in edit tab
        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data Grid View and load it tho the textboxex respectively
            int rowIndex = e.RowIndex;
            textBox3.Text = metroGrid1.Rows[rowIndex].Cells[0].Value.ToString();
            textBox2.Text = metroGrid1.Rows[rowIndex].Cells[1].Value.ToString();
            textBox1.Text = metroGrid1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbSesSubjectEdit.Text = metroGrid1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbSesTagEdit.Text = metroGrid1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbSesGroupEdit.Text = metroGrid1.Rows[rowIndex].Cells[5].Value.ToString();
            DurationUpDown2.Text = metroGrid1.Rows[rowIndex].Cells[6].Value.ToString();
            NoOfStuUpDown1.Text = metroGrid1.Rows[rowIndex].Cells[7].Value.ToString();
        }

        private void btnLecUpdate_Click(object sender, EventArgs e)
        {
            if (IsValidUpdate())
            {


                //get the data from texbox
                c.ID = int.Parse(textBox3.Text);
                c.LecturerName = textBox2.Text;
                c.subjectname = textBox1.Text;
                c.subjectcode = cmbSesSubjectEdit.Text;
                c.tag = cmbSesTagEdit.Text;
                c.group = cmbSesGroupEdit.Text;
                c.duration = DurationUpDown2.Text;
                c.Numberofstudents = NoOfStuUpDown1.Text;


                bool success = c.Update(c);
                if (success == true)
                {
                    //Upload Successfully 
                    MessageBox.Show("Session has been Successfully Updated");
                    // LOAD DATA 
                    DataTable dt = c.Select();
                    metroGrid1.DataSource = dt;

                    ClearFieldsAfterUpdate();
                }
                else
                {
                    //faild to update
                    MessageBox.Show("ERROR ");
                }

            }

        }


        private void ClearFieldsAfterUpdate()
        {
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();

            cmbSesTagEdit.SelectedIndex = -1;
            cmbSesGroupEdit.SelectedIndex = -1;
            DurationUpDown2.Value = 0;
            NoOfStuUpDown1.Value = 0;

        }


        //creat method to when user click update button without selecting row
        private bool IsValidUpdate()
        {
            if ((textBox2.Text == string.Empty) || (textBox1.Text == string.Empty)
                || (cmbSesSubjectEdit.Text == string.Empty) || (cmbSesTagEdit.Text == string.Empty) || (cmbSesGroupEdit.Text == string.Empty)
                || (DurationUpDown2.Text == string.Empty) || (NoOfStuUpDown1.Text == string.Empty))
            {
                MessageBox.Show("Please Select a Session to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //clear btn in edit tab
        private void metroButton3_Click(object sender, EventArgs e)
        {
            ClearFieldsAfterUpdate();
        }



        private void btnLecDelete_Click(object sender, EventArgs e)
        {
            if (IsValidDelete())
            {

                //Get data  from database
                c.ID = Convert.ToInt32(textBox3.Text);

                bool success = c.Delete(c);

                if (success == true)
                {
                    MessageBox.Show("Session Successfully Deleted.");
                    // LOAD DATA 
                    DataTable dt = c.Select();
                    metroGrid1.DataSource = dt;

                    ClearFieldsAfterUpdate();
                }
                else
                {
                    MessageBox.Show("error");
                }

            }
        }

        //DELETE VALIDATE 
        private bool IsValidDelete()
        {
            if ((textBox2.Text == string.Empty) || (textBox1.Text == string.Empty)
                || (cmbSesSubjectEdit.Text == string.Empty) || (cmbSesTagEdit.Text == string.Empty) || (cmbSesGroupEdit.Text == string.Empty)
                || (DurationUpDown2.Text == string.Empty) || (NoOfStuUpDown1.Text == string.Empty))
            {
                MessageBox.Show("Please Select a Session to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }



        private void txtSesSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from text box
            string keyword1 = txtSesSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Add_Sessions WHERE LecNames LIKE '%" + keyword1 + "%' OR SubCodes LIKE '%" + keyword1 + "%' OR Groupname LIKE '%" + keyword1 + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.DataSource = dt;
        }


        private void cmbSesFilterLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get data from filtering year

            string keyword = cmbSesFilterLecturer.Text;

            if (cmbSesFilterLecturer.Text == "Clear")
            {
                cmbSesFilterLecturer.SelectedIndex = -1;
            }
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Add_Sessions WHERE SesTag LIKE '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.DataSource = dt;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void DurationUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }

        private void cmbSesTagAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSesSearch_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSesEdit_Click(object sender, EventArgs e)
        {

        }

    }
    }
