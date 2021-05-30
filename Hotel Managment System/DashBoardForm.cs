using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Managment_System
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void ExitCircleButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ADDRoomButton_Click(object sender, EventArgs e)
        {
            AddRoomsForm AR = new AddRoomsForm();
            AR.ShowDialog();
        }

        private void CustomerRegistrationButton_Click(object sender, EventArgs e)
        {
            CustomerRegistrationForm CR = new CustomerRegistrationForm();
            CR.ShowDialog();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            CheckOutForm CO = new CheckOutForm();
            CO.ShowDialog();
        }

        private void CustomerDetailsButton_Click(object sender, EventArgs e)
        {
            CustomerDetailsForm CD = new CustomerDetailsForm();
            CD.ShowDialog();
        }
    }
}
