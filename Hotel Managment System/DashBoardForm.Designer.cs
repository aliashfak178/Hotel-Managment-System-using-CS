
namespace Hotel_Managment_System
{
    partial class DashBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerDetailsButton = new Guna.UI2.WinForms.Guna2Button();
            this.CheckOutButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerRegistrationButton = new Guna.UI2.WinForms.Guna2Button();
            this.ADDRoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ExitCircleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CustomerDetailsButton);
            this.panel1.Controls.Add(this.CheckOutButton);
            this.panel1.Controls.Add(this.CustomerRegistrationButton);
            this.panel1.Controls.Add(this.ADDRoomButton);
            this.panel1.Location = new System.Drawing.Point(79, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            // 
            // CustomerDetailsButton
            // 
            this.CustomerDetailsButton.BorderRadius = 26;
            this.CustomerDetailsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerDetailsButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomerDetailsButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CustomerDetailsButton.CheckedState.Parent = this.CustomerDetailsButton;
            this.CustomerDetailsButton.CustomImages.Parent = this.CustomerDetailsButton;
            this.CustomerDetailsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.CustomerDetailsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CustomerDetailsButton.ForeColor = System.Drawing.Color.White;
            this.CustomerDetailsButton.HoverState.Parent = this.CustomerDetailsButton;
            this.CustomerDetailsButton.Image = global::Hotel_Managment_System.Properties.Resources.customer_Details;
            this.CustomerDetailsButton.ImageSize = new System.Drawing.Size(40, 40);
            this.CustomerDetailsButton.Location = new System.Drawing.Point(758, 23);
            this.CustomerDetailsButton.Name = "CustomerDetailsButton";
            this.CustomerDetailsButton.ShadowDecoration.Parent = this.CustomerDetailsButton;
            this.CustomerDetailsButton.Size = new System.Drawing.Size(236, 85);
            this.CustomerDetailsButton.TabIndex = 0;
            this.CustomerDetailsButton.Text = "Customer Details";
            this.CustomerDetailsButton.Click += new System.EventHandler(this.CustomerDetailsButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BorderRadius = 26;
            this.CheckOutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CheckOutButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CheckOutButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CheckOutButton.CheckedState.Parent = this.CheckOutButton;
            this.CheckOutButton.CustomImages.Parent = this.CheckOutButton;
            this.CheckOutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CheckOutButton.ForeColor = System.Drawing.Color.White;
            this.CheckOutButton.HoverState.Parent = this.CheckOutButton;
            this.CheckOutButton.Image = global::Hotel_Managment_System.Properties.Resources.Check_out_50px;
            this.CheckOutButton.ImageSize = new System.Drawing.Size(40, 40);
            this.CheckOutButton.Location = new System.Drawing.Point(516, 23);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.ShadowDecoration.Parent = this.CheckOutButton;
            this.CheckOutButton.Size = new System.Drawing.Size(236, 85);
            this.CheckOutButton.TabIndex = 0;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // CustomerRegistrationButton
            // 
            this.CustomerRegistrationButton.BorderRadius = 26;
            this.CustomerRegistrationButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerRegistrationButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomerRegistrationButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.CustomerRegistrationButton.CheckedState.Parent = this.CustomerRegistrationButton;
            this.CustomerRegistrationButton.CustomImages.Parent = this.CustomerRegistrationButton;
            this.CustomerRegistrationButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.CustomerRegistrationButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.CustomerRegistrationButton.ForeColor = System.Drawing.Color.White;
            this.CustomerRegistrationButton.HoverState.Parent = this.CustomerRegistrationButton;
            this.CustomerRegistrationButton.Image = global::Hotel_Managment_System.Properties.Resources.customer_registration;
            this.CustomerRegistrationButton.ImageSize = new System.Drawing.Size(40, 40);
            this.CustomerRegistrationButton.Location = new System.Drawing.Point(250, 23);
            this.CustomerRegistrationButton.Name = "CustomerRegistrationButton";
            this.CustomerRegistrationButton.ShadowDecoration.Parent = this.CustomerRegistrationButton;
            this.CustomerRegistrationButton.Size = new System.Drawing.Size(253, 85);
            this.CustomerRegistrationButton.TabIndex = 0;
            this.CustomerRegistrationButton.Text = "Customer Registration";
            this.CustomerRegistrationButton.Click += new System.EventHandler(this.CustomerRegistrationButton_Click);
            // 
            // ADDRoomButton
            // 
            this.ADDRoomButton.BorderRadius = 26;
            this.ADDRoomButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ADDRoomButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.ADDRoomButton.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.ADDRoomButton.CheckedState.Parent = this.ADDRoomButton;
            this.ADDRoomButton.CustomImages.Parent = this.ADDRoomButton;
            this.ADDRoomButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ADDRoomButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.ADDRoomButton.ForeColor = System.Drawing.Color.White;
            this.ADDRoomButton.HoverState.Parent = this.ADDRoomButton;
            this.ADDRoomButton.Image = ((System.Drawing.Image)(resources.GetObject("ADDRoomButton.Image")));
            this.ADDRoomButton.ImageSize = new System.Drawing.Size(40, 40);
            this.ADDRoomButton.Location = new System.Drawing.Point(8, 23);
            this.ADDRoomButton.Name = "ADDRoomButton";
            this.ADDRoomButton.ShadowDecoration.Parent = this.ADDRoomButton;
            this.ADDRoomButton.Size = new System.Drawing.Size(236, 85);
            this.ADDRoomButton.TabIndex = 0;
            this.ADDRoomButton.Text = "ADD Room";
            this.ADDRoomButton.Click += new System.EventHandler(this.ADDRoomButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.CheckedState.Parent = this.MinimizeButton;
            this.MinimizeButton.CustomImages.Parent = this.MinimizeButton;
            this.MinimizeButton.FillColor = System.Drawing.Color.Empty;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.HoverState.Parent = this.MinimizeButton;
            this.MinimizeButton.Image = global::Hotel_Managment_System.Properties.Resources.minimize_window_25pxdf;
            this.MinimizeButton.ImageSize = new System.Drawing.Size(30, 30);
            this.MinimizeButton.Location = new System.Drawing.Point(12, 76);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(61, 46);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitCircleButton
            // 
            this.ExitCircleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitCircleButton.CheckedState.Parent = this.ExitCircleButton;
            this.ExitCircleButton.CustomImages.Parent = this.ExitCircleButton;
            this.ExitCircleButton.FillColor = System.Drawing.Color.Empty;
            this.ExitCircleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitCircleButton.ForeColor = System.Drawing.Color.White;
            this.ExitCircleButton.HoverState.Parent = this.ExitCircleButton;
            this.ExitCircleButton.Image = global::Hotel_Managment_System.Properties.Resources.cancel_50px;
            this.ExitCircleButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitCircleButton.Location = new System.Drawing.Point(12, 12);
            this.ExitCircleButton.Name = "ExitCircleButton";
            this.ExitCircleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitCircleButton.ShadowDecoration.Parent = this.ExitCircleButton;
            this.ExitCircleButton.Size = new System.Drawing.Size(61, 46);
            this.ExitCircleButton.TabIndex = 0;
            this.ExitCircleButton.Click += new System.EventHandler(this.ExitCircleButton_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitCircleButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardForm";
            this.Text = "DashBoardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitCircleButton;
        private Guna.UI2.WinForms.Guna2CircleButton MinimizeButton;
        private Guna.UI2.WinForms.Guna2Button CustomerDetailsButton;
        private Guna.UI2.WinForms.Guna2Button CheckOutButton;
        private Guna.UI2.WinForms.Guna2Button CustomerRegistrationButton;
        private Guna.UI2.WinForms.Guna2Button ADDRoomButton;
    }
}