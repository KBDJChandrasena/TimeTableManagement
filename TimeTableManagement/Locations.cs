using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagement
{
    public partial class Locations : MetroFramework.Forms.MetroForm
    {
        public Locations()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=sqlazuresingledatabase.database.windows.net;Initial Catalog=TimetableManagmentSystem;Persist Security Info=True;User ID=admin1;Password=0717363727gg@");
        int id = 0;

        private void Locations_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (buildingTxt.Text == "" || roomTxt.Text == "" || capacityTxt.Text == "" || roomTypeCB.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                try
                {
                    connection.Open();
                    String qry = "INSERT INTO location (building, room, room_type, capacity) values('" + buildingTxt.Text + "', '" + roomTxt.Text + "', '" + roomTypeCB.Text + "', '" + Int32.Parse(capacityTxt.Text) + "')";
                    SqlCommand command = new SqlCommand(qry, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Location Saved!");
                    connection.Close();
                    buildingTxt.Text = "";
                    roomTxt.Text = "";
                    capacityTxt.Text = "";
                    roomTypeCB.Text = "";
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void loadData()
        {
            connection.Open();
            String qry = "SELECT * FROM location";
            SqlDataAdapter adapter = new SqlDataAdapter(qry, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            table.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

            buildingTxt.Text = "";
            roomTxt.Text = "";
            capacityTxt.Text = "";
            roomTypeCB.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                MessageBox.Show("Please select location to update!");
            }
            else
            {
                try
                {
                    connection.Open();
                    String qry = "UPDATE location SET building = '" + buildingTxtUpdate.Text + "', room = '" + roomTxtUpdate.Text + "', capacity = '" + Int32.Parse(capacityTxtUpdate.Text) + "', room_type ='" + roomTypeCBUpdate.Text + "' WHERE id = '" + id + "'";
                    SqlCommand command = new SqlCommand(qry, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Location Updated!");
                    connection.Close();
                    buildingTxtUpdate.Text = "";
                    roomTxtUpdate.Text = "";
                    capacityTxtUpdate.Text = "";
                    roomTypeCBUpdate.Text = "";
                    loadData();
                    id = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (id == 0)
            {
                MessageBox.Show("Please select location to delete!");
            }
            else
            {
                try
                {
                    connection.Open();
                    String qry = "DELETE FROM location WHERE id = '" + id + "'";
                    SqlCommand command = new SqlCommand(qry, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Location Deleted!");
                    connection.Close();
                    buildingTxtUpdate.Text = "";
                    roomTxtUpdate.Text = "";
                    capacityTxtUpdate.Text = "";
                    roomTypeCBUpdate.Text = "";
                    loadData();
                    id = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.table.Rows[e.RowIndex];
                id = Int32.Parse(row.Cells[0].Value.ToString());
                buildingTxtUpdate.Text = row.Cells[1].Value.ToString();
                roomTxtUpdate.Text = row.Cells[2].Value.ToString();
                roomTypeCBUpdate.Text = row.Cells[3].Value.ToString();
                capacityTxtUpdate.Text = row.Cells[4].Value.ToString();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homepage = new Form1();
            homepage.ShowDialog();
        }
    }




}
