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

namespace TimeTableManagement.Lecturer
{
    public partial class AddLecturer : MetroFramework.Forms.MetroForm
    {
        public AddLecturer()
        {
            InitializeComponent();
        }

        LecturerClass c = new LecturerClass();


        //Save Lecturer
        private void btnLecSaveAdd_Click(object sender, EventArgs e)
        {
            if(IsValidSave())
            {
                //Get valu from input fields
                c.LecID = txtLecIDAdd.Text;
                c.Name = txtLecNameAdd.Text;
                c.Faculty = cmbLecFacultyAdd.Text;
                c.Department = cmbLecDepartmentAdd.Text;
                c.Building = cmbLecBuildingAdd.Text;
                c.Center = cmbLecCenterAdd.Text;
                c.Level = cmbLecLevelAdd.Text;
                
            
                //inserting in to the database

                bool success = c.Insert(c);
                    if(success == true)
                    {
                        MessageBox.Show("New Lecturer Successfully Insert");
                        //call the clear mehod
                        ClearFieldsAfterSave();
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }

                    // LOAD DATA 
                    DataTable dt = c.Select();
                    metroGrid1.DataSource = dt;


            }

        }




        private void cmbLecFacultyAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLecDepartmentAdd.Items.Clear();

            if (cmbLecFacultyAdd.SelectedItem.Equals("Faculty of Engineering"))
            {
                cmbLecDepartmentAdd.Items.Add("CE");
                cmbLecDepartmentAdd.Items.Add("EEE");
                cmbLecDepartmentAdd.Items.Add("ME");
                cmbLecDepartmentAdd.Items.Add("QS");
            }
            else if (cmbLecFacultyAdd.SelectedItem.Equals("Faculty of Computing"))
            {
                cmbLecDepartmentAdd.Items.Add("CSSE");
                cmbLecDepartmentAdd.Items.Add("DS");
                cmbLecDepartmentAdd.Items.Add("CSNE");
                cmbLecDepartmentAdd.Items.Add("IT");
                cmbLecDepartmentAdd.Items.Add("CS");
                cmbLecDepartmentAdd.Items.Add("IM");
                cmbLecDepartmentAdd.Items.Add("ISE");
            }
            else if (cmbLecFacultyAdd.SelectedItem.Equals("Faculty of Business"))
            {
                cmbLecDepartmentAdd.Items.Add("AF");
                cmbLecDepartmentAdd.Items.Add("BA");
                cmbLecDepartmentAdd.Items.Add("HCM");
                cmbLecDepartmentAdd.Items.Add("MM");
                cmbLecDepartmentAdd.Items.Add("IM");
                cmbLecDepartmentAdd.Items.Add("BM");
            }
            else if (cmbLecFacultyAdd.SelectedItem.Equals("Faculty of Humanities and Science"))
            {
                cmbLecDepartmentAdd.Items.Add("MU");
                cmbLecDepartmentAdd.Items.Add("ELT");
            }
            //cmbLecFac.SelectedIndex = -1;
        }


        //Clear button
        private void btnLecClearAdd_Click(object sender, EventArgs e)
        {
            ClearFieldsAfterSave();
        }


        private bool IsValidSave()
        {
            if ((txtLecIDAdd.Text == string.Empty) || (txtLecNameAdd.Text == string.Empty) || (cmbLecLevelAdd.Text == string.Empty)
                || (cmbLecFacultyAdd.Text == string.Empty) || (cmbLecDepartmentAdd.Text == string.Empty) || (cmbLecBuildingAdd.Text == string.Empty)
                 || (cmbLecCenterAdd.Text == string.Empty))
            {
                MessageBox.Show("Fill the all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void ClearFieldsAfterSave()
        {
            txtLecNameAdd.Clear();
            txtLecIDAdd.Clear();
            cmbLecDepartmentAdd.SelectedIndex = -1;
            cmbLecBuildingAdd.SelectedIndex = -1;
            cmbLecCenterAdd.SelectedIndex = -1;
            cmbLecLevelAdd.SelectedIndex = -1;

        }






        //UPdate

        private void btnLecUpdate_Click(object sender, EventArgs e)
        {

            if(IsValidUpdate())
            {

                    
                        //get the data from texbox
                        c.ID = int.Parse(txtID.Text);
                        c.LecID = txtLecIdEdit.Text;
                        c.Name = txtLecNameEdit.Text;
                        c.Faculty = cmbLecFacultyEdit.Text;
                        c.Department = cmbLecDepartmentEdit.Text;
                        c.Building = cmbLecBuildingEdit.Text;
                        c.Center = cmbLecCenterEdit.Text;
                        c.Level = cmbLecLevelEdit.Text;
                

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

            txtID.Text = metroGrid1.Rows[rowIndex].Cells[0].Value.ToString();
            txtLecIdEdit.Text = metroGrid1.Rows[rowIndex].Cells[1].Value.ToString();
            txtLecNameEdit.Text = metroGrid1.Rows[rowIndex].Cells[2].Value.ToString();
            cmbLecFacultyEdit.Text = metroGrid1.Rows[rowIndex].Cells[3].Value.ToString();
            cmbLecDepartmentEdit.Text = metroGrid1.Rows[rowIndex].Cells[4].Value.ToString();
            cmbLecBuildingEdit.Text = metroGrid1.Rows[rowIndex].Cells[5].Value.ToString();
            cmbLecCenterEdit.Text = metroGrid1.Rows[rowIndex].Cells[6].Value.ToString();
            cmbLecLevelEdit.Text = metroGrid1.Rows[rowIndex].Cells[7].Value.ToString();
        }
       

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        
        

        private void ClearFieldsAfterUpdate()
        {

            txtID.Clear();
            txtLecNameEdit.Clear();
            txtLecIdEdit.Clear();
            
            cmbLecDepartmentEdit.SelectedIndex = -1;
            cmbLecBuildingEdit.SelectedIndex = -1;
            cmbLecCenterEdit.SelectedIndex = -1;
            cmbLecLevelEdit.SelectedIndex = -1;

        }


        //creat method to when user click update button without selecting row
        private bool IsValidUpdate()
        {
            if ((txtLecNameEdit.Text == string.Empty) || (txtLecIdEdit.Text == string.Empty)
                || (cmbLecFacultyEdit.Text == string.Empty) || (cmbLecDepartmentEdit.Text == string.Empty) || (cmbLecBuildingEdit.Text == string.Empty)
                || (cmbLecLevelEdit.Text == string.Empty) || (cmbLecCenterEdit.Text == string.Empty))
            {
                MessageBox.Show("Please Select a Lecturer to Update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }







        private void cmbLecFacultyEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLecDepartmentEdit.Items.Clear();

            if (cmbLecFacultyEdit.SelectedItem.Equals("Faculty of Engineering"))
            {
                cmbLecDepartmentEdit.Items.Add("CE");
                cmbLecDepartmentEdit.Items.Add("EEE");
                cmbLecDepartmentEdit.Items.Add("ME");
                cmbLecDepartmentEdit.Items.Add("QS");
            }
            else if (cmbLecFacultyEdit.SelectedItem.Equals("Faculty of Computing"))
            {
                cmbLecDepartmentEdit.Items.Add("CSSE");
                cmbLecDepartmentEdit.Items.Add("DS");
                cmbLecDepartmentEdit.Items.Add("CSNE");
                cmbLecDepartmentEdit.Items.Add("IT");
                cmbLecDepartmentEdit.Items.Add("CS");
                cmbLecDepartmentEdit.Items.Add("IM");
                cmbLecDepartmentEdit.Items.Add("ISE");
            }
            else if (cmbLecFacultyEdit.SelectedItem.Equals("Faculty of Business"))
            {
                cmbLecDepartmentEdit.Items.Add("AF");
                cmbLecDepartmentEdit.Items.Add("BA");
                cmbLecDepartmentEdit.Items.Add("HCM");
                cmbLecDepartmentEdit.Items.Add("MM");
                cmbLecDepartmentEdit.Items.Add("IM");
                cmbLecDepartmentEdit.Items.Add("BM");
            }
            else if (cmbLecFacultyEdit.SelectedItem.Equals("Faculty of Humanities and Science"))
            {
                cmbLecDepartmentEdit.Items.Add("MU");
                cmbLecDepartmentEdit.Items.Add("ELT");
            }
            //cmbLecFac.SelectedIndex = -1;
        }




        //Delete



        private void btnLecDelete_Click(object sender, EventArgs e)
        {
            if (IsValidDelete())
            {


                //Get data  from database
                c.ID = Convert.ToInt32(txtID.Text);
                bool success = c.Delete(c);
                if (success == true)
                {
                    MessageBox.Show("Lecurer Successfully Deleted.");
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
            if ((txtLecNameEdit.Text == string.Empty) || (txtLecIdEdit.Text == string.Empty)
                || (cmbLecFacultyEdit.Text == string.Empty) || (cmbLecDepartmentEdit.Text == string.Empty) || (cmbLecBuildingEdit.Text == string.Empty)
                || (cmbLecLevelEdit.Text == string.Empty))
            {
                MessageBox.Show("Please Select a Lecturer to Delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
        

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;


        private void txtLecSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from text box
            string keyword = txtLecSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Lecture WHERE Name LIKE '%" + keyword + "%' OR Rank LIKE '%" + keyword + "%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.DataSource = dt;
        }

        private void cmbLecFilterFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get data from filtering year

            string keyword = cmbLecFacultyEdit.Text;

            if (cmbLecFacultyEdit.Text == "Clear")
            {
                cmbLecFacultyEdit.SelectedIndex = -1;
            }
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM Lecture WHERE Faculty LIKE '%" + keyword + "%' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            metroGrid1.DataSource = dt;
        }
        


        private void AddLecturer_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            metroGrid1.DataSource = dt;
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbLecBuildingAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageLecAdd_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        

        private void txtLecGenarateRank_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }

        private void cmbLecLevelAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
