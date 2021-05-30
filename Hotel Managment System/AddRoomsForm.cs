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
    public partial class AddRoomsForm : Form
    {
        public AddRoomsForm()
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

        private void RoomNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - StartPoint.X,p.Y - StartPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void AddNewRoomButton_Click(object sender, EventArgs e)
        {
            if(isValidated())
            {
                DialogResult result = MessageBox.Show("Are You Really Want to Add this record???","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    if(ValidatedRoomNumber(RoomNoTextBox.Text))
                    {
                        AddThisRecord();
                        MessageBox.Show("Record Added Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ShowMessage("This Room Number Already Exist Try Again","Validation Error");
                    }
                    
                }
            }
        }

        private bool ValidatedRoomNumber(string text)
        {
            bool validateRooms;
            int RoomNumber = int.Parse(text);

            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_CheckRoomExist", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //output parameters
                    cmd.Parameters.Add("@ValidateRooms", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    //parameters
                    cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    validateRooms = (bool)cmd.Parameters["@ValidateRooms"].Value;
                }
            }

            return validateRooms;
        }

        private void AddThisRecord()
        {
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_AddNewRoom", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();


                    //parameters
                    cmd.Parameters.AddWithValue("@RoomNo",RoomNoTextBox.Text);
                    cmd.Parameters.AddWithValue("@RoomType", RoomTypeComboBox.Text);
                    cmd.Parameters.AddWithValue("@BedType", BedComboBox.Text);
                    cmd.Parameters.AddWithValue("@RoomPrice", PriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@isBooked","No");

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private bool isValidated()
        {
            if(RoomNoTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Room Number First","Validation Error");
                return false;
            }
            else if(RoomTypeComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select Room Type First", "Validation Error");
                return false;
            }
            else if(BedComboBox.SelectedIndex == -1)
            {
                ShowMessage("Please Select Bed Type First", "Validation Error");
                return false;
            }
            else if(PriceTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Room Price First", "Validation Error");
                return false;
            }
            return true;
        }

        private void ShowMessage(string v1, string v2)
        {
            MessageBox.Show(v1,v2,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void AddRoomsForm_Load(object sender, EventArgs e)
        {
            LoadAllRooms();
        }

        private void LoadAllRooms()
        {
            RoomsDataGridView.DataSource = GetData();
        }

        private DataTable GetData()
        {
            DataTable Dt_Rooms = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DisplayAllRooms", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dt_Rooms.Load(reader);
                }
            }
            return Dt_Rooms;
        }

        private void RefreshCircleButton_Click(object sender, EventArgs e)
        {
            LoadAllRooms();
        }
        private int RoomID;
        private void RoomsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = RoomsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            RoomID = (int)RoomsDataGridView.Rows[row].Cells["ID"].Value;

            RoomNoTextBox.Text = RoomsDataGridView.Rows[row].Cells["Room Number"].Value.ToString();


        }

        private void DeleteThisRecord(int iD)
        {
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DeleteRooms", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@RoomId", iD);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (RoomNoTextBox.Text.Trim() != string.Empty)
            {
                DialogResult result = MessageBox.Show("Are You Really Want To Delete This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!(ValidatedRoomNumber(RoomNoTextBox.Text)))
                    {
                        DeleteThisRecord(RoomID);
                        MessageBox.Show("Room Are Deleted Successfully","Room Are Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Room Numbers, Tying Again", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                ShowMessage("Please Select Room Number First", "Validation Error");
            }
        }
    }
}
