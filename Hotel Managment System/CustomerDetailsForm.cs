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
    public partial class CustomerDetailsForm : Form
    {
        public CustomerDetailsForm()
        {
            InitializeComponent();
        }
        // Moving LayOut Variable
        private bool drag = false;
        private Point StartPoint = new Point(0, 0);

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

        private void ExitCircleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            LoadAllCustomer();
        }

        private void LoadAllCustomer()
        {
            RoomsDataGridView.DataSource = GetAllData();
        }
        private DataTable Dt_Customer;
        private DataTable GetAllData()
        {
            Dt_Customer = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayAllCustomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Customer.Load(reader);
                }
            }
            return Dt_Customer;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DataView DtView = Dt_Customer.DefaultView;
            if(FilterComboBox.SelectedIndex == 0)
            {
                DtView.RowFilter = "Name LIKE '%" + SearchTextBox.Text + "%'";
            }
            else
            {
                DtView.RowFilter = "IDNumber LIKE '%" + SearchTextBox.Text + "%'";
            }
        }
    }
}
