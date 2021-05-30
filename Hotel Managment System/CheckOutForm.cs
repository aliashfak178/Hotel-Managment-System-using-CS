using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Managment_System
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }
        // Moving LayOut Variable
        private bool drag = false;
        private Point StartPoint = new Point(0, 0);
        private void ExitCircleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X, p.Y - StartPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void GetAllCustomers()
        {
            RoomsDataGridView.DataSource = GetAllData();
        }

        private DataTable GetAllData()
        {
            DataTable Dt_Customers = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CheckOutCustomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Customers.Load(reader);
                }
            }
            return Dt_Customers;
        }
        private int CustomerID;
        private int RoomNo;
        private void RoomsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = RoomsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            NameTextBox.Text = RoomsDataGridView.Rows[row].Cells["Customer Name"].Value.ToString();
            RoomNoTextBox.Text = RoomsDataGridView.Rows[row].Cells["Room Number"].Value.ToString();
            CustomerID = (int)RoomsDataGridView.Rows[row].Cells["Customer ID"].Value;
            RoomNo = int.Parse(RoomsDataGridView.Rows[row].Cells["Room Number"].Value.ToString());
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text.Trim() != string.Empty)
            {
                CheckOutCustomer(CustomerID);
                MessageBox.Show("Check Out SuccessFully","Successed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Select Any Record First","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CheckOutCustomer(int customerID)
        {
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CheckOutCustomers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@RoomNo", RoomNo);

                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
