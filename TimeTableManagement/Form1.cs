using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Advanced;
using TimeTableManagement.Lecturer;
using TimeTableManagement.Session;
using TimeTableManagement.Subject;

namespace TimeTableManagement
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void metroTile12_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkingDaysAndHours ffffff = new WorkingDaysAndHours();

            ffffff.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetNotAvailableTimes fffff = new SetNotAvailableTimes();

            fffff.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLecturer f = new AddLecturer();

            f.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
            advanced st = new advanced();
            st.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions fw = new Sessions();

            fw.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student st = new Student();
            st.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSubject ss = new addSubject();

            ss.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics ss = new Statistics();

            ss.Show();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locations ss = new Locations();

            ss.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {

            this.Hide();
            Tag.tag ss = new Tag.tag();
            ss.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm st = new StudentForm();
            st.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
