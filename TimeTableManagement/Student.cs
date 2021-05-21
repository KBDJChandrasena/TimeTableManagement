using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.StudentClass;

namespace TimeTableManagement
{
    public partial class Student : MetroFramework.Forms.MetroForm
    {
        public Student()
        {
            InitializeComponent();
        }

        YearandSemster c = new YearandSemster();
        Programme p = new Programme();
        GroupNumber gn = new GroupNumber();
        SubgroupNumber sgn = new SubgroupNumber();
        GroupID gid = new GroupID();
        SubgroupID sgid = new SubgroupID();



        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
        //load  

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }
        //ADD BUTtON YEAR AND SEMESTER
        private void metroButton20_Click(object sender, EventArgs e)
        {

            
            
                //Get value from input fiellds

                c.sYear = sYear.Text;
                c.sSem = sSem.Text;
                

                //inserting data into the database 
                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("Successfully Insert");
                    //Call the clear method here
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }

            // LOAD DATA  
            DataTable dt = c.Select();
            metroGrid7.DataSource = dt;

            

            Clear1();


        }

        //loadData
        
        
        private void metroGrid6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Update
        private void metroButton22_Click(object sender, EventArgs e)
        {
            //get the data from texbox
            c.sYearID = int.Parse(sYearID.Text);
            c.sYear = sYear.Text;
            c.sSem = sSem.Text;
            

            bool success = c.Update(c);
            if (success == true)
            {
                //Upload Successfully 
                MessageBox.Show(" Successfully Updated");
                // LOAD DATA 
                

               
            }
            else
            {
                //faild to update
                MessageBox.Show("ERROR ");
            }
            DataTable dt = c.Select();
            metroGrid7.DataSource = dt;
            Clear1();
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            //Get data  from database
            c.sYearID = Convert.ToInt32(sYearID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Subject Successfully Deleted.");
                // LOAD DATA 
                DataTable dt = c.Select();
                metroGrid7.DataSource = dt;


            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            metroGrid7.DataSource = dt;


            DataTable dtp = p.Select();
            metroGrid2.DataSource = dtp;

            DataTable dtgn = gn.Select();
            metroGrid3.DataSource = dtgn;

            DataTable dtsgn = sgn.Select();
            metroGrid1.DataSource = dtsgn;

            DataTable dtgid = gid.Select();
            metroGrid4.DataSource = dtgid;

            DataTable dtsgid = sgid.Select();
            metroGrid5.DataSource = dtsgid;

        }
      
        public void Clear1()
        {
            sYear.Text = "";
            sSem.Text = "";


        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            Clear1();
        }

        //Method to clickevent
        private void metroGrid7_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            sYearID.Text = metroGrid7.Rows[rowIndex].Cells[0].Value.ToString();
            sYear.Text = metroGrid7.Rows[rowIndex].Cells[1].Value.ToString();
            sSem.Text = metroGrid7.Rows[rowIndex].Cells[2].Value.ToString();
        }
        //Programme-----------------------------------------------------------------------------------------------------

        //add button
        private void metroButton4_Click(object sender, EventArgs e)
        {
            //Get value from input fiellds

            
            p.sProgramme = sProgramme.Text;


            //inserting data into the database 
            bool success = p.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Successfully Insert");
                //Call the clear method here

            }
            else
            {
                MessageBox.Show("Error");
            }

            // LOAD DATA  
            DataTable dtp = p.Select();
            metroGrid2.DataSource = dtp;



            Clear2();
        }

        public void Clear2()
        {
            sProgramme.Text = "";
            


        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            //get the data from texbox
            p.sPID = int.Parse(sPID.Text);
            p.sProgramme = sProgramme.Text;
            


            bool success = p.Update(p);
            if (success == true)
            {
                //Upload Successfully 
                MessageBox.Show(" Successfully Updated");
                



            }
            else
            {
                //faild to update
                MessageBox.Show("ERROR ");
            }
            DataTable dtp = p.Select();
            metroGrid2.DataSource = dtp;



            Clear2();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            p.sPID = Convert.ToInt32(sPID.Text);
            bool success = p.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Subject Successfully Deleted.");
               


            }
            else
            {
                MessageBox.Show("error");
            }

            DataTable dtp = p.Select();
            metroGrid2.DataSource = dtp;



            Clear2();
        }
        //mouse click event
        private void metroGrid2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            sPID.Text = metroGrid2.Rows[rowIndex].Cells[0].Value.ToString();
            sProgramme.Text = metroGrid2.Rows[rowIndex].Cells[1].Value.ToString();
        }

        //groupnumber -----------------------------------------------------------------------------------------------
        //add
        private void metroButton9_Click(object sender, EventArgs e)
        {
            gn.sgroupno = sgroupno.Text;


            //inserting data into the database 
            bool success = gn.Insert(gn);
            if (success == true)
            {
                MessageBox.Show("Successfully Insert");
                //Call the clear method here

            }
            else
            {
                MessageBox.Show("Error");
            }

            // LOAD DATA  
            DataTable dtgn = gn.Select();
            metroGrid3.DataSource = dtgn;



            Clear3();
        }

        public void Clear3()
        {
            sgroupno.Text = "";



        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            gn.sGroupnoID = int.Parse(sGroupnoID.Text);
            gn.sgroupno = sgroupno.Text;



            bool success = gn.Update(gn);
            if (success == true)
            {
                //Upload Successfully 
                MessageBox.Show(" Successfully Updated");




            }
            else
            {
                //faild to update
                MessageBox.Show("ERROR ");
            }
            DataTable dtgn = gn.Select();
            metroGrid3.DataSource = dtgn;



            Clear3();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            gn.sGroupnoID = Convert.ToInt32(sGroupnoID.Text);
            bool success = gn.Delete(gn);
            if (success == true)
            {
                MessageBox.Show("Subject Successfully Deleted.");



            }
            else
            {
                MessageBox.Show("error");
            }
            DataTable dtgn = gn.Select();
            metroGrid3.DataSource = dtgn;



            Clear3();
        }

        private void metroGrid3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            sGroupnoID.Text = metroGrid3.Rows[rowIndex].Cells[0].Value.ToString();
            sgroupno.Text = metroGrid3.Rows[rowIndex].Cells[1].Value.ToString();
        }

        //subgroup name--------------------------------------------------------------------
        private void metroButton2_Click(object sender, EventArgs e)
        {
            sgn.sSubgroup = sSubgroup.Text;


            //inserting data into the database 
            bool success = sgn.Insert(sgn);
            if (success == true)
            {
                MessageBox.Show("Successfully Insert");
                //Call the clear method here

            }
            else
            {
                MessageBox.Show("Error");
            }

            // LOAD DATA  
            DataTable dtsgn = sgn.Select();
            metroGrid1.DataSource = dtsgn;



            Clear4();

        }

        public void Clear4()
        {
            sSubgroup.Text = "";



        }
        //update
        private void metroButton12_Click(object sender, EventArgs e)
        {
            sgn.sSubgroupId = int.Parse(sSubgroupId.Text);
            sgn.sSubgroup = sSubgroup.Text;



            bool success = sgn.Update(sgn);
            if (success == true)
            {
                //Upload Successfully 
                MessageBox.Show(" Successfully Updated");




            }
            else
            {
                //faild to update
                MessageBox.Show("ERROR ");
            }
            DataTable dtsgn = sgn.Select();
            metroGrid1.DataSource = dtsgn;



            Clear4();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            sgn.sSubgroupId = Convert.ToInt32(sSubgroupId.Text);
            bool success = sgn.Delete(sgn);
            if (success == true)
            {
                MessageBox.Show(" Successfully Deleted.");



            }
            else
            {
                MessageBox.Show("error");
            }
            DataTable dtsgn = sgn.Select();
            metroGrid1.DataSource = dtsgn;



            Clear4();

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            sSubgroupId.Text = metroGrid1.Rows[rowIndex].Cells[0].Value.ToString();
            sSubgroup.Text = metroGrid1.Rows[rowIndex].Cells[1].Value.ToString();
        }

        //GroupId----------------------------------------------------------------------------------------------------------------
        //add
        private void metroButton14_Click(object sender, EventArgs e)
        {
            gid.sgroupidname = sgroupidname.Text;


            //inserting data into the database 
            bool success = gid.Insert(gid);
            if (success == true)
            {
                MessageBox.Show("Successfully Insert");
                //Call the clear method here

            }
            else
            {
                MessageBox.Show("Error");
            }

            // LOAD DATA  
            DataTable dtgid = gid.Select();
            metroGrid4.DataSource = dtgid;



            Clear5();
        }

        public void Clear5()
        {
            sgroupidname.Text = "";



        }

        //Delete
        private void metroButton15_Click(object sender, EventArgs e)
        {
             gid.sGroupId = Convert.ToInt32(sGroupId.Text);
            bool success = gid.Delete(gid);
            if (success == true)
            {
                MessageBox.Show(" Successfully Deleted.");



            }
            else
            {
                MessageBox.Show("error");
            }
            DataTable dtgid = gid.Select();
            metroGrid4.DataSource = dtgid;



            Clear5();
        }

        private void metroGrid4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            sGroupId.Text = metroGrid4.Rows[rowIndex].Cells[0].Value.ToString();
            sgroupidname.Text = metroGrid4.Rows[rowIndex].Cells[1].Value.ToString();
        }

        //sub group ID -----------------------------------------------------------------------
        //ADD
        private void metroButton17_Click(object sender, EventArgs e)
        {
            sgid.sGroupIds = sGroupIds.Text;


            //inserting data into the database 
            bool success = sgid.Insert(sgid);
            if (success == true)
            {
                MessageBox.Show("Successfully Insert");
                //Call the clear method here

            }
            else
            {
                MessageBox.Show("Error");
            }

            // LOAD DATA  
            DataTable dtsgid = sgid.Select();
            metroGrid5.DataSource = dtsgid;



            Clear6();

        }
        //delete
        private void metroButton18_Click(object sender, EventArgs e)
        {

            sgid.sSubgroupIdt = Convert.ToInt32(sSubgroupIdt.Text);
            bool success = sgid.Delete(sgid);
            if (success == true)
            {
                MessageBox.Show(" Successfully Deleted.");



            }
            else
            {
                MessageBox.Show("error");
            }
            DataTable dtsgid = sgid.Select();
            metroGrid5.DataSource = dtsgid;



            Clear6();
        }

        public void Clear6()
        {
            sGroupIds.Text = "";



        }

        private void metroGrid5_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            sSubgroupIdt.Text = metroGrid5.Rows[rowIndex].Cells[0].Value.ToString();
            sGroupIds.Text = metroGrid5.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f32 = new Form1();
            
            f32.Show();
        }
    }
}
