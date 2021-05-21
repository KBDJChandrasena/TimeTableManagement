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

namespace TimetableManagementSystem.Subject
{
    public partial class addSubject : MetroFramework.Forms.MetroForm
    {
        public addSubject()
        {
            InitializeComponent();
        }
        
        SubjectClass c = new SubjectClass();
        
        
        public string ID { get; private set; }


        //Save

        private void btnSubSaveAdd_Click_1(object sender, EventArgs e)
        {
            if (IsValidSave())
            {
                //Get value from input fiellds

                c.SubjectCode = txtSubCodeAdd.Text;
                c.SubjectName = txtSubNameAdd.Text;
                c.OfferedYear = cmbSubYearAdd.Text;
                c.OfferedSemester = cmbSubSemesterAdd.Text;
                c.NumberofLecHours = cmbSubLecHoursAdd.Text;
                c.NumberofTuteHours = cmbSubTuteAdd.Text;
                c.NumberofLabHours = cmbSubLabAdd.Text;
                c.NumberofEvaluHours = cmbSubEvaHoursAdd.Text;

                //inserting data into the database 
                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("New Subject Successfully Insert");
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

        
        
        private void addSubject_Load(object sender, EventArgs e)
        {
            //load data from database
            DataTable dt = c.Select();
            metroGrid1.DataSource = dt;

            tabControlSubject.SelectedTab = tabPagesubEdit;
        }

       

        //Update


        private void btnSubUpdate_Click(object sender, EventArgs e)
        {



            if (IsValidUpdate())
            {
                //get the data from texbox
                c.ID = int.Parse(txtSubIDEdit.Text);
                c.SubjectCode = txtSubCodeEdit.Text;
                c.SubjectName = txtSubNameEdit.Text;
                c.OfferedYear = cmbSubYearEdit.Text;
                c.OfferedSemester = cmbSubSemesterEdit.Text;
                c.NumberofLecHours = cmbSubLecHoursEdit.Text;
                c.NumberofTuteHours = cmbSubTuteHoursEdit.Text;
                c.NumberofLabHours = cmbSubLabHoursEdit.Text;
                c.NumberofEvaluHours = cmbSubEvaHoursEdit.Text;

                bool success = c.Update(c);
                if (success == true)
                {
                    //Upload Successfully 
                    MessageBox.Show("Subject has been Successfully Updated");
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

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data Grid View and load it tho the textboxex respectively
            int rowIndex = e.RowIndex;
            txtSubIDEdit.Text = metroGrid1.Rows[rowIndex].Cells[0].Value.ToString();
            txtSubCodeEdit.Text = metroGrid1.Rows[rowIndex].Cells[1].Value.ToString();
            txtSubNameEdit.Text = metroGrid1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbSubYearEdit.Text = metroGrid1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbSubSemesterEdit.Text = metroGrid1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbSubLecHoursEdit.Text = metroGrid1.Rows[rowIndex].Cells[5].Value.ToString();
            cmbSubTuteHoursEdit.Text = metroGrid1.Rows[rowIndex].Cells[6].Value.ToString();
            cmbSubLabHoursEdit.Text = metroGrid1.Rows[rowIndex].Cells[7].Value.ToString();
            cmbSubEvaHoursEdit.Text = metroGrid1.Rows[rowIndex].Cells[8].Value.ToString();

        }
        


        private void ClearFieldsAfterSave()
        {

           
            txtSubNameAdd.Clear();
            txtSubCodeAdd.Clear();
            cmbSubYearAdd.SelectedIndex = -1;
            cmbSubSemesterAdd.SelectedIndex = -1;
            cmbSubLecHoursAdd.SelectedIndex = -1;
            cmbSubTuteAdd.SelectedIndex = -1;
            cmbSubLabAdd.SelectedIndex = -1;
            cmbSubEvaHoursAdd.SelectedIndex = -1;
        }
        private void ClearFieldsAfterUpdate()
        {

            txtSubIDEdit.Clear();
            txtSubNameEdit.Clear();
            txtSubCodeEdit.Clear();
            cmbSubYearEdit.SelectedIndex = -1;
            cmbSubSemesterEdit.SelectedIndex = -1;
            cmbSubLecHoursEdit.SelectedIndex = -1;
            cmbSubTuteHoursEdit.SelectedIndex = -1;
            cmbSubLabHoursEdit.SelectedIndex = -1;
            cmbSubEvaHoursEdit.SelectedIndex = -1;
        }
        //creat method to when user click update button without selecting row
        private bool IsValidUpdate()
        {
            if ((txtSubNameEdit.Text == string.Empty) || (txtSubCodeEdit.Text == string.Empty)
                || (cmbSubYearEdit.Text == string.Empty) || (cmbSubSemesterEdit.Text == string.Empty) || (cmbSubLecHoursEdit.Text == string.Empty)
                || (cmbSubTuteHoursEdit.Text == string.Empty) || (cmbSubLabHoursEdit.Text == string.Empty) || (cmbSubEvaHoursEdit.Text == string.Empty))
            {
                MessageBox.Show("Please Select a Subject to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //save validate 
        private bool IsValidSave()
        {
            if ((txtSubNameAdd.Text == string.Empty) || (txtSubCodeAdd.Text == string.Empty)
                || (cmbSubYearAdd.Text == string.Empty) || (cmbSubSemesterAdd.Text == string.Empty) || (cmbSubLecHoursAdd.Text == string.Empty)
                || (cmbSubTuteAdd.Text == string.Empty) || (cmbSubLabAdd.Text == string.Empty) || (cmbSubEvaHoursAdd.Text == string.Empty))
            {
                MessageBox.Show("Fill the all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        //DELETE VALIDATE 
        private bool IsValidDelete()
        {
            if ((txtSubNameEdit.Text == string.Empty) || (txtSubCodeEdit.Text == string.Empty)
                || (cmbSubYearEdit.Text == string.Empty) || (cmbSubSemesterEdit.Text == string.Empty) || (cmbSubLecHoursEdit.Text == string.Empty)
                || (cmbSubTuteHoursEdit.Text == string.Empty) || (cmbSubLabHoursEdit.Text == string.Empty) || (cmbSubEvaHoursEdit.Text == string.Empty))
            {
                MessageBox.Show("Please Select a Subject to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        


        //Clear Btn

        private void btnSubClearAdd_Click(object sender, EventArgs e)
        {
            //clear method
            ClearFieldsAfterSave();
        }



        //Delete

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            if (IsValidDelete())
            {

          
                //Get data  from database
                c.ID = Convert.ToInt32(txtSubIDEdit.Text);
                bool success = c.Delete(c);
                if (success == true)
                {
                    MessageBox.Show("Subject Successfully Deleted.");
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



        //Searchbar

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        private void txtSubSearch_TextChanged_1(object sender, EventArgs e)
        {
            //get the value from text box
            string keyword = txtSubSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Add_Subject WHERE SubCode LIKE '%" + keyword + "%' OR SubName LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void cmbSubFilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get data from filtering year
            
            string keyword = cmbSubFilterYear.Text;

            if (cmbSubFilterYear.Text == "Clear")
            {
                cmbSubFilterYear.SelectedIndex = -1;
            }
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Add_Subject WHERE OfferedYear LIKE '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.DataSource = dt;
        }














        private void txtSubSearch_Click(object sender, EventArgs e)
        {
            
        }


        private void tabPagesubEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLecNameEdit_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void SubdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void cmbLecBuildingAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLecLevelAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLecCenterAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void metroLabel26_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel27_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSubAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSubTuteHoursEdit_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage();
            homepage.ShowDialog();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
