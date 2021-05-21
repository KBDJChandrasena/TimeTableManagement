using TimeTableManagement.SetNotAvailableTimesClass;
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
    public partial class SetNotAvailableTimes : MetroFramework.Forms.MetroForm
    {
        public SetNotAvailableTimes()
        {
            InitializeComponent();
        }

        SetNotAvailbleTimeNAT f = new SetNotAvailbleTimeNAT();
        AllocateNotReservableTime anr = new AllocateNotReservableTime();


        //Set Not Availble Time ----------------------------------------------------------------------------------------------
        //Add Set not Available Time 
        private void metroButton1_Click(object sender, EventArgs e)
        {
            f.Type = Type.Text;
            f.Item = Item.Text;
            f.startTime = startTime.Text;
            f.endTime = endTime.Text;
            f.day = day.Text;
            

            bool success = f.Insert(f);
            if (success == true)
            {
                MessageBox.Show("Successfully Saved");


            }
            else
            {
                MessageBox.Show("No");

            }

            //Load data to gried View
            DataTable dtf = f.Select();
            SetnotAvailbleTGried.DataSource = dtf;

            //clear
            notavailblelear();


        }

        //view method
         private void SetNotAvailableTimes_Load(object sender, EventArgs e)
        {
            DataTable dtf = f.Select();
            SetnotAvailbleTGried.DataSource = dtf;
        }

        //clearmethod
        private void notavailblelear()
        {
            Type.SelectedIndex = -1;
            Item.SelectedIndex = -1;
            startTime.SelectedIndex = -1;
            endTime.SelectedIndex = -1;
            day.SelectedIndex = -1;

            sheduleId.Clear();
        }

        private void ClesrSNT_Click(object sender, EventArgs e)
        {
            notavailblelear();
        }

        private void SetnotAvailbleTGried_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Mouse click event 
        private void SetnotAvailbleTGried_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;

            sheduleId.Text = SetnotAvailbleTGried.Rows[rowIndex].Cells[0].Value.ToString();
            Type.Text = SetnotAvailbleTGried.Rows[rowIndex].Cells[1].Value.ToString();
            Item.Text = SetnotAvailbleTGried.Rows[rowIndex].Cells[2].Value.ToString();
            startTime.Text = SetnotAvailbleTGried.Rows[rowIndex].Cells[3].Value.ToString();
            endTime.Text = SetnotAvailbleTGried.Rows[rowIndex].Cells[4].Value.ToString();
            day.Text = SetnotAvailbleTGried.Rows[rowIndex].Cells[5].Value.ToString();
            
        }


        //Update Button
        private void updateSNT_Click(object sender, EventArgs e)
        {
            f.sheduleId = int.Parse(sheduleId.Text);

            
            f.Type = Type.Text;
            f.Item = Item.Text;
            f.startTime = startTime.Text;
            f.endTime = endTime.Text;
            f.day = day.Text;




            bool success = f.Update(f);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("no");
            }

            //Load data to gried View
            DataTable dtf = f.Select();
            SetnotAvailbleTGried.DataSource = dtf;

            //clear
            notavailblelear();
        }

        //Delete method
        private void DeleteSNT_Click(object sender, EventArgs e)
        {
            f.sheduleId = Convert.ToInt32(sheduleId.Text);
            bool success = f.Delete(f);
            if (success == true)
            {
                MessageBox.Show("Successfully Deleted");

            }
            else
            {
                MessageBox.Show("no");
            }

            //Load data to gried View
            DataTable dtf = f.Select();
            SetnotAvailbleTGried.DataSource = dtf;

            //clear
            notavailblelear();
        }


        //Allocate Not available Time ------------------------------------------------------------------------------------------------------------
        //Add Data
        private void AllocateNRTime_Click(object sender, EventArgs e)
        {
            
            anr.room = room.Text;
            anr.notRtime = notRtime.Text;
            anr.startTimer = startTimer.Text;
            anr.endTimer = endTimer.Text;


            bool success = anr.Insert(anr);
            if (success == true)
            {
                MessageBox.Show("Successfully Saved");


            }
            else
            {
                MessageBox.Show("No");

            }
            notreservableTime();

        }

        private void notreservableTime()
        {
            room.SelectedIndex = -1;
            notRtime.SelectedIndex = -1;
            startTimer.SelectedIndex = -1;
            endTimer.SelectedIndex = -1;
            

            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            notreservableTime();
        }

        //Home Button---------------------------------------------------------------------------------
        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            //WorkingDaysAndHours f3 = new WorkingDaysAndHours();
            f3.Show();
        }
    }
}
