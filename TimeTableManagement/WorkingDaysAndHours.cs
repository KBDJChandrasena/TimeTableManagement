using TimeTableManagement.workingdaysclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagement
{
    public partial class WorkingDaysAndHours : MetroFramework.Forms.MetroForm
    {
        public WorkingDaysAndHours()
        {
            InitializeComponent();
        }
        workingdays c = new workingdays();
        TimeSlot a = new TimeSlot();
        WorkingTime b = new WorkingTime();
        DaysOfWorking d = new DaysOfWorking();

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //ADD button in numberof working days
        private void metroButton1_Click(object sender, EventArgs e)
        {
            c.numOfday = numOfday.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Saved");

               
            }
            else 
            {
                MessageBox.Show("No");

            }

            //Load data to griedview

            DataTable dt = c.Select();

            noOfdays.DataSource = dt;

            clearworkingdays();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Number of days load in griedview

        private void WorkingDaysAndHours_Load(object sender, EventArgs e)
        {
            //Load data to griedview

            DataTable dt = c.Select();

            noOfdays.DataSource = dt;

            DataTable dta = a.Select();
            timeslotgriedview.DataSource = dta;

            //Load data to griedview

            DataTable dtb = b.Select();

            workingTimegried.DataSource = dtb;

            //load data
            DataTable dtd = d.Select();

            workingdaysgriedv.DataSource = dtd;

           
        }

        //
        private void noOfdays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        //update button in numberof days
        private void metroButton2_Click(object sender, EventArgs e)
        {
            c.dayentryId = int.Parse(dayentryId.Text);

            c.numOfday = numOfday.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("no");
            }

            //Load data to griedview

            DataTable dt = c.Select();

            noOfdays.DataSource = dt;

            clearworkingdays();
        }
        // numberof days mouse click event
        private void noOfdays_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dayentryId.Text = noOfdays.Rows[rowIndex].Cells[0].Value.ToString();
            numOfday.Text = noOfdays.Rows[rowIndex].Cells[1].Value.ToString();
        }


        //delete button number of days
        private void metroButton3_Click(object sender, EventArgs e)
        {
            c.dayentryId = Convert.ToInt32(dayentryId.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");

            }
            else 
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dt = c.Select();

            noOfdays.DataSource = dt;

            clearworkingdays();

        }

        // number of working days clear button
        private void metroButton4_Click(object sender, EventArgs e)
        {
            clearworkingdays();


        }
        //clesr Number of working days method
        private void clearworkingdays()
        {
            numOfday.SelectedIndex = -1;
            dayentryId.Clear();
        }

        

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        // Time slot 

        //Add button

        private void timeslotAdd_Click(object sender, EventArgs e)
        {
            a.timeslotDay = timeslotDay.Text;
            a.timeslotWkh = timeslotWkh.Text;
           

            bool success = a.Insert(a);
            if (success == true)
            {
                MessageBox.Show("Successfully Saved");


            }
            else
            {
                MessageBox.Show("No");

            }

            //Load data to griedview

            DataTable dta = a.Select();

            timeslotgriedview.DataSource = dta;

            timeslotclear();


        }

       
        //timeslot click event
        private void timeslotgriedview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            timeslotentryId.Text = timeslotgriedview.Rows[rowIndex].Cells[0].Value.ToString();
            timeslotDay.Text = timeslotgriedview.Rows[rowIndex].Cells[1].Value.ToString();
            timeslotWkh.Text = timeslotgriedview.Rows[rowIndex].Cells[2].Value.ToString();


        }

        //Time slot Update event
        private void timeslotEdit_Click(object sender, EventArgs e)
        {
            a.timeslotentryId = int.Parse(timeslotentryId.Text);

            a.timeslotDay = timeslotDay.Text;
            a.timeslotWkh = timeslotWkh.Text;

            bool success = a.Update(a);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dta = a.Select();

            timeslotgriedview.DataSource = dta;
            timeslotclear();

        }

        // Delete button event

        private void timeslotDelete_Click(object sender, EventArgs e)
        {
            a.timeslotentryId = Convert.ToInt32(timeslotentryId.Text);
            bool success = a.Delete(a);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");

            }
            else
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dta = a.Select();

            timeslotgriedview.DataSource = dta;
            timeslotclear();
        }

        private void timeslotDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timeslotWkh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }



        //Working Time Event 

        //Add button
        private void metroButton9_Click(object sender, EventArgs e)
        {
            b.whours = whours.Text;
            b.wmins = wmins.Text;
            


            bool success = b.Insert(b);
            if (success == true)
            {
                MessageBox.Show("Successfully Saved");


            }
            else
            {
                MessageBox.Show("No");

            }

            //Load data to griedview

            DataTable dtb = b.Select();

            workingTimegried.DataSource = dtb;
            workingtimeclear();
        }

        //mouse click event working time
        private void workingTimegried_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            workingTimeEId.Text = workingTimegried.Rows[rowIndex].Cells[0].Value.ToString();
            whours.Text = workingTimegried.Rows[rowIndex].Cells[1].Value.ToString();
            wmins.Text = workingTimegried.Rows[rowIndex].Cells[2].Value.ToString();
        }

        //Update button working time
        private void WorkingHoursUpdate_Click(object sender, EventArgs e)
        {
            b.workingTimeEId = int.Parse(workingTimeEId.Text);

            b.whours = whours.Text;
            b.wmins = wmins.Text;

            

            bool success = b.Update(b);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dtb = b.Select();

            workingTimegried.DataSource = dtb;
            workingtimeclear();

        }
        //Delete button working time
        private void WorkingHoursDelete_Click(object sender, EventArgs e)
        {
            b.workingTimeEId = Convert.ToInt32(workingTimeEId.Text);
            bool success = b.Delete(b);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");

            }
            else
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dtb = b.Select();

            workingTimegried.DataSource = dtb;
            workingtimeclear();
        }



        //Working Days 

        //Add button

        private void workingdayAdd_Click(object sender, EventArgs e)
        {

            d.day1 = day1.Text;
            d.day2 = day2.Text;
            d.day3 = day3.Text;
            d.day4 = day4.Text;
            d.day5 = day5.Text;
            d.day6 = day6.Text;
            d.day7 = day7.Text;



            bool success = d.Insert(d);
            if (success == true)
            {
                MessageBox.Show("Successfully Saved");


            }
            else
            {
                MessageBox.Show("No");

            }

            //Load data to griedview

            DataTable dtd = d.Select();

            workingdaysgriedv.DataSource = dtd;

            workingdaysclear();

        }

        //mmouse click event in workingdays
        private void workingdaysgriedv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            workingdayID.Text = workingdaysgriedv.Rows[rowIndex].Cells[0].Value.ToString();
            day1.Text = workingdaysgriedv.Rows[rowIndex].Cells[1].Value.ToString();
            day2.Text = workingdaysgriedv.Rows[rowIndex].Cells[2].Value.ToString();
            day3.Text = workingdaysgriedv.Rows[rowIndex].Cells[3].Value.ToString();
            day4.Text = workingdaysgriedv.Rows[rowIndex].Cells[4].Value.ToString();
            day5.Text = workingdaysgriedv.Rows[rowIndex].Cells[5].Value.ToString();
            day6.Text = workingdaysgriedv.Rows[rowIndex].Cells[6].Value.ToString();
            day7.Text = workingdaysgriedv.Rows[rowIndex].Cells[7].Value.ToString();

        }

        //Update button working days
        private void workingdaysUpdate_Click(object sender, EventArgs e)
        {
            
            d.workingdayID = int.Parse(workingdayID.Text);

            d.day1 = day1.Text;
            d.day2 = day2.Text;
            d.day3 = day3.Text;
            d.day4 = day4.Text;
            d.day5 = day5.Text;
            d.day6 = day6.Text;
            d.day7 = day7.Text;
           



            bool success = d.Update(d);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dtd = d.Select();

            workingdaysgriedv.DataSource = dtd;

            workingdaysclear();
        }
        //Delete button in working days
        private void workingdaysDelete_Click(object sender, EventArgs e)
        {
            d.workingdayID = Convert.ToInt32(workingdayID.Text);
            bool success = d.Delete(d);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");

            }
            else
            {
                MessageBox.Show("no");
            }
            //Load data to griedview

            DataTable dtd = d.Select();

            workingdaysgriedv.DataSource = dtd;

            workingdaysclear();
        }
        //timeslot clear method
        private void timeslotclear()
        {
            timeslotDay.SelectedIndex = -1;
            timeslotWkh.SelectedIndex = -1;
            timeslotentryId.Clear();
        }

        //timeslot clear button
        private void reset_Click(object sender, EventArgs e)
        {
            timeslotclear();
        }
        //working time clesr method 

        private void workingtimeclear() 
        {
            whours.SelectedIndex = -1;
            wmins.SelectedIndex = -1;
            workingTimeEId.Clear();
        }

        //Working time reset button
        private void workingtimereset_Click(object sender, EventArgs e)
        {
            workingtimeclear();
        }

        //working days clesr method

        private void workingdaysclear()
        {
            day1.SelectedIndex = -1;
            day2.SelectedIndex = -1;
            day3.SelectedIndex = -1;
            day4.SelectedIndex = -1;
            day5.SelectedIndex = -1;
            day6.SelectedIndex = -1;
            day7.SelectedIndex = -1;
            workingdayID.Clear();
        }
        // Working days Reset button
        private void metroButton8_Click(object sender, EventArgs e)
        {
            workingdaysclear();

        }

        //Don't want nevigate to next page noooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        private void metroButton5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //SetNotAvailableTimes f2 = new SetNotAvailableTimes();
            //f2.Show();

            this.Hide();
            Form1 f2 = new Form1();
            
            f2.Show();
        }
    }



}
