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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(isValidated())
            {
                bool IsUserNameCurrect, IsPasswordCurrect;
                GetUserLoginCurrect(out IsUserNameCurrect, out IsPasswordCurrect);
                if (IsUserNameCurrect && IsPasswordCurrect)
                {
                    DashBoardForm BDF = new DashBoardForm();
                    BDF.Show();
                    this.Hide();
                }
                else
                {
                    ShowMessage("Invalid UserName And Password", "Validation Error");
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();
                    UserNameTextBox.Focus();
                }
                
            }
            
        }

        private void GetUserLoginCurrect(out bool isUserNameCurrect, out bool isPasswordCurrect)
        {
            string connString = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ChackUserLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    //output parameters
                    cmd.Parameters.Add("@IsUserNameCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IsPasswordCurrect", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    //parameters
                    cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);

                    //Execute The Command
                    cmd.ExecuteNonQuery();

                    //Passed Parameter's Values From Db
                    isUserNameCurrect = (bool)cmd.Parameters["@IsUserNameCurrect"].Value;
                    isPasswordCurrect = (bool)cmd.Parameters["@IsPasswordCurrect"].Value;
                }
            }
        }

        private bool isValidated()
        {
            if(UserNameTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter UserName First","Validation Error");
                return false;
            }
            else if(PasswordTextBox.Text.Trim() == string.Empty)
            {
                ShowMessage("Please Enter Password First", "Validtion Error");
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
