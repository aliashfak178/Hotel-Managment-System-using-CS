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
    public partial class CustomerRegistrationForm : Form
    {
        public CustomerRegistrationForm()
        {
            InitializeComponent();
        }

        // Moving LayOut Variable
        private bool drag = false;
        private Point StartPoint = new Point(0, 0);


        // Item Changed

        private void ExitCircleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerMobailNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void IDProofNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
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

        private void RoomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BedComboBox.DataSource = GetAllBeds(RoomTypeComboBox.Text);
            BedComboBox.DisplayMember = "Bed Type";
            BedComboBox.SelectedIndex = -1;
        }

        private DataTable GetAllBeds(string text)
        {
            DataTable Dt_Beds = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllBeds", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@RoomType",text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Beds.Load(reader);
                }
            }
            return Dt_Beds;
        }

        private void BedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomNumberComboBox.DataSource = GetAllRoomNumbers(BedComboBox.Text);
            RoomNumberComboBox.DisplayMember = "Room Number";
        }

        private DataTable GetAllRoomNumbers(string text)
        {
            DataTable Dt_Rooms = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetAllRooms", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@BedType", text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Rooms.Load(reader);
                }
            }
            return Dt_Rooms;
        }

        private DataTable GetPrice(string text)
        {
            DataTable DtPrice = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_GetPriceByRoomNo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@RoomNumber", text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DtPrice.Load(reader);
                }
            }
            return DtPrice;
        }

        private void RoomNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt_Price = GetPrice(RoomNumberComboBox.Text);
            DataRow row = Dt_Price.Rows[0];
            PriceTextBox.Text = row["Room Price"].ToString();
        }

        private void BookRoomButton_Click(object sender, EventArgs e)
        {
            if(isValidated())
            {
                DialogResult result = MessageBox.Show("Are You Really Want To insert This Record ??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    InsertAllRecord();
                    MessageBox.Show("Record Added Successfully","Successd",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }

        private void InsertAllRecord()
        {
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_NewCostomer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@C_Name", CustomerNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@C_MobailNo",CustomerMobailNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@C_Email", CustomerEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@Gender",GenderComboBox.Text);
                    cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@IDProof",IDProofTypeComboBox.Text);
                    cmd.Parameters.AddWithValue("@ID_Number",IDProofNumberTextBox.Text);
                    cmd.Parameters.AddWithValue("@Address",AddressTextBox.Text);
                    cmd.Parameters.AddWithValue("@CheckIn",CheckInDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@RoomType",RoomTypeComboBox.Text);
                    cmd.Parameters.AddWithValue("@BedType",BedComboBox.Text);
                    cmd.Parameters.AddWithValue("@RoomNumber",RoomNumberComboBox.Text);
                    cmd.Parameters.AddWithValue("@Price",PriceTextBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool isValidated()
        {
            if(CustomerNameTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Costomer Name First","Validation Error");
                return false;
            }
            else if(CustomerMobailNoTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Mobail Number First", "Validation Error");
                return false;
            }
            else if(CustomerEmailTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Email First", "Validation Error");
                return false;
            }
            else if(GenderComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select Your Gender First", "Validation Error");
                return false;
            }
            else if(IDProofTypeComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select ID Prof Type First", "Validation Error");
                return false;
            }
            else if(IDProofNumberTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter ID Prof Number First", "Validation Error");
                return false;
            }
            else if(AddressTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Complete Address Frist", "Validation Error");
                return false;
            }
            else if(RoomTypeComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select Room Type First", "Validation Error");
                return false;
            }
            else if(BedComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select BedType First", "Validation Error");
                return false;
            }
            else if(RoomNumberComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select Room Number First", "Validation Error");
                return false;
            }
            return true;
        }

        private void ShowMessage(string v1, string v2)
        {
            MessageBox.Show(v1, v2,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
