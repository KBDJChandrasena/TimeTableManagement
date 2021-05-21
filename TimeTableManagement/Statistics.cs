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

namespace TimeTableManagement
{
    public partial class Statistics : MetroFramework.Forms.MetroForm
    {
        public Statistics()
        {
            InitializeComponent();
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection connection = new SqlConnection(@"Data Source=sqlazuresingledatabase.database.windows.net;Initial Catalog=TimetableManagmentSystem;Persist Security Info=True;User ID=admin1;Password=0717363727gg@");

        private void Statistics_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadLecFacChart()
        {
            

        }
        private void faclec_chart_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }
    }
}
