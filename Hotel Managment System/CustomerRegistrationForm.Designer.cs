
namespace Hotel_Managment_System
{
    partial class CustomerRegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitCircleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustomerMobailNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerEmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DOBDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.IDProofTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IDProofNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckInDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.RoomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BedComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RoomNumberComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BookRoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitCircleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 49);
            this.panel1.TabIndex = 50;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(444, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 43);
            this.label1.TabIndex = 50;
            this.label1.Text = "Customer Registration";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.ExitCircleButton.Location = new System.Drawing.Point(1136, 1);
            this.ExitCircleButton.Name = "ExitCircleButton";
            this.ExitCircleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitCircleButton.ShadowDecoration.Parent = this.ExitCircleButton;
            this.ExitCircleButton.Size = new System.Drawing.Size(61, 46);
            this.ExitCircleButton.TabIndex = 50;
            this.ExitCircleButton.Click += new System.EventHandler(this.ExitCircleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Customer Name";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Animated = true;
            this.CustomerNameTextBox.AutoRoundedCorners = true;
            this.CustomerNameTextBox.BorderRadius = 17;
            this.CustomerNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerNameTextBox.DefaultText = "";
            this.CustomerNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTextBox.DisabledState.Parent = this.CustomerNameTextBox;
            this.CustomerNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTextBox.FocusedState.Parent = this.CustomerNameTextBox;
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CustomerNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerNameTextBox.HoverState.Parent = this.CustomerNameTextBox;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(15, 107);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.PasswordChar = '\0';
            this.CustomerNameTextBox.PlaceholderText = "";
            this.CustomerNameTextBox.SelectedText = "";
            this.CustomerNameTextBox.ShadowDecoration.Parent = this.CustomerNameTextBox;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(310, 36);
            this.CustomerNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // CustomerMobailNoTextBox
            // 
            this.CustomerMobailNoTextBox.Animated = true;
            this.CustomerMobailNoTextBox.AutoRoundedCorners = true;
            this.CustomerMobailNoTextBox.BorderRadius = 17;
            this.CustomerMobailNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerMobailNoTextBox.DefaultText = "";
            this.CustomerMobailNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerMobailNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerMobailNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerMobailNoTextBox.DisabledState.Parent = this.CustomerMobailNoTextBox;
            this.CustomerMobailNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerMobailNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerMobailNoTextBox.FocusedState.Parent = this.CustomerMobailNoTextBox;
            this.CustomerMobailNoTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CustomerMobailNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerMobailNoTextBox.HoverState.Parent = this.CustomerMobailNoTextBox;
            this.CustomerMobailNoTextBox.Location = new System.Drawing.Point(15, 225);
            this.CustomerMobailNoTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CustomerMobailNoTextBox.Name = "CustomerMobailNoTextBox";
            this.CustomerMobailNoTextBox.PasswordChar = '\0';
            this.CustomerMobailNoTextBox.PlaceholderText = "";
            this.CustomerMobailNoTextBox.SelectedText = "";
            this.CustomerMobailNoTextBox.ShadowDecoration.Parent = this.CustomerMobailNoTextBox;
            this.CustomerMobailNoTextBox.Size = new System.Drawing.Size(310, 36);
            this.CustomerMobailNoTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustomerMobailNoTextBox.TabIndex = 1;
            this.CustomerMobailNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerMobailNoTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer Mobail No.";
            // 
            // CustomerEmailTextBox
            // 
            this.CustomerEmailTextBox.Animated = true;
            this.CustomerEmailTextBox.AutoRoundedCorners = true;
            this.CustomerEmailTextBox.BorderRadius = 17;
            this.CustomerEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerEmailTextBox.DefaultText = "";
            this.CustomerEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomerEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomerEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerEmailTextBox.DisabledState.Parent = this.CustomerEmailTextBox;
            this.CustomerEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomerEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerEmailTextBox.FocusedState.Parent = this.CustomerEmailTextBox;
            this.CustomerEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.CustomerEmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustomerEmailTextBox.HoverState.Parent = this.CustomerEmailTextBox;
            this.CustomerEmailTextBox.Location = new System.Drawing.Point(15, 347);
            this.CustomerEmailTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CustomerEmailTextBox.Name = "CustomerEmailTextBox";
            this.CustomerEmailTextBox.PasswordChar = '\0';
            this.CustomerEmailTextBox.PlaceholderText = "";
            this.CustomerEmailTextBox.SelectedText = "";
            this.CustomerEmailTextBox.ShadowDecoration.Parent = this.CustomerEmailTextBox;
            this.CustomerEmailTextBox.Size = new System.Drawing.Size(310, 36);
            this.CustomerEmailTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustomerEmailTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Customer Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Gender";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Animated = true;
            this.GenderComboBox.AutoRoundedCorners = true;
            this.GenderComboBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderComboBox.BorderRadius = 17;
            this.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.FocusedState.Parent = this.GenderComboBox;
            this.GenderComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderComboBox.HoverState.Parent = this.GenderComboBox;
            this.GenderComboBox.ItemHeight = 30;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.ItemsAppearance.Parent = this.GenderComboBox;
            this.GenderComboBox.Location = new System.Drawing.Point(17, 456);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.ShadowDecoration.Parent = this.GenderComboBox;
            this.GenderComboBox.Size = new System.Drawing.Size(321, 36);
            this.GenderComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.GenderComboBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 30);
            this.label6.TabIndex = 32;
            this.label6.Text = "Date Of Birth";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.CheckedState.Parent = this.DOBDateTimePicker;
            this.DOBDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOBDateTimePicker.HoverState.Parent = this.DOBDateTimePicker;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(17, 570);
            this.DOBDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOBDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.ShadowDecoration.Parent = this.DOBDateTimePicker;
            this.DOBDateTimePicker.Size = new System.Drawing.Size(308, 36);
            this.DOBDateTimePicker.TabIndex = 4;
            this.DOBDateTimePicker.Value = new System.DateTime(2021, 5, 3, 11, 30, 4, 238);
            // 
            // IDProofTypeComboBox
            // 
            this.IDProofTypeComboBox.Animated = true;
            this.IDProofTypeComboBox.AutoRoundedCorners = true;
            this.IDProofTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.IDProofTypeComboBox.BorderRadius = 17;
            this.IDProofTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IDProofTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDProofTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDProofTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDProofTypeComboBox.FocusedState.Parent = this.IDProofTypeComboBox;
            this.IDProofTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IDProofTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.IDProofTypeComboBox.HoverState.Parent = this.IDProofTypeComboBox;
            this.IDProofTypeComboBox.ItemHeight = 30;
            this.IDProofTypeComboBox.Items.AddRange(new object[] {
            "Aadhar Card",
            "PAN",
            "Votter ID"});
            this.IDProofTypeComboBox.ItemsAppearance.Parent = this.IDProofTypeComboBox;
            this.IDProofTypeComboBox.Location = new System.Drawing.Point(387, 103);
            this.IDProofTypeComboBox.Name = "IDProofTypeComboBox";
            this.IDProofTypeComboBox.ShadowDecoration.Parent = this.IDProofTypeComboBox;
            this.IDProofTypeComboBox.Size = new System.Drawing.Size(321, 36);
            this.IDProofTypeComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.IDProofTypeComboBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 30);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID Prof Type";
            // 
            // IDProofNumberTextBox
            // 
            this.IDProofNumberTextBox.Animated = true;
            this.IDProofNumberTextBox.AutoRoundedCorners = true;
            this.IDProofNumberTextBox.BorderRadius = 17;
            this.IDProofNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDProofNumberTextBox.DefaultText = "";
            this.IDProofNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDProofNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDProofNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDProofNumberTextBox.DisabledState.Parent = this.IDProofNumberTextBox;
            this.IDProofNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDProofNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDProofNumberTextBox.FocusedState.Parent = this.IDProofNumberTextBox;
            this.IDProofNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.IDProofNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDProofNumberTextBox.HoverState.Parent = this.IDProofNumberTextBox;
            this.IDProofNumberTextBox.Location = new System.Drawing.Point(385, 225);
            this.IDProofNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.IDProofNumberTextBox.Name = "IDProofNumberTextBox";
            this.IDProofNumberTextBox.PasswordChar = '\0';
            this.IDProofNumberTextBox.PlaceholderText = "";
            this.IDProofNumberTextBox.SelectedText = "";
            this.IDProofNumberTextBox.ShadowDecoration.Parent = this.IDProofNumberTextBox;
            this.IDProofNumberTextBox.Size = new System.Drawing.Size(310, 36);
            this.IDProofNumberTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.IDProofNumberTextBox.TabIndex = 6;
            this.IDProofNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDProofNumberTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID Prof Number";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Animated = true;
            this.AddressTextBox.AutoRoundedCorners = true;
            this.AddressTextBox.BorderRadius = 17;
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.DefaultText = "";
            this.AddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.DisabledState.Parent = this.AddressTextBox;
            this.AddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.FocusedState.Parent = this.AddressTextBox;
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.HoverState.Parent = this.AddressTextBox;
            this.AddressTextBox.Location = new System.Drawing.Point(385, 347);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PasswordChar = '\0';
            this.AddressTextBox.PlaceholderText = "";
            this.AddressTextBox.SelectedText = "";
            this.AddressTextBox.ShadowDecoration.Parent = this.AddressTextBox;
            this.AddressTextBox.Size = new System.Drawing.Size(310, 36);
            this.AddressTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AddressTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 30);
            this.label10.TabIndex = 32;
            this.label10.Text = "Check In Date";
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.CheckedState.Parent = this.CheckInDateTimePicker;
            this.CheckInDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CheckInDateTimePicker.HoverState.Parent = this.CheckInDateTimePicker;
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(387, 470);
            this.CheckInDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CheckInDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.ShadowDecoration.Parent = this.CheckInDateTimePicker;
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(308, 36);
            this.CheckInDateTimePicker.TabIndex = 8;
            this.CheckInDateTimePicker.Value = new System.DateTime(2021, 5, 3, 11, 30, 4, 238);
            // 
            // RoomTypeComboBox
            // 
            this.RoomTypeComboBox.Animated = true;
            this.RoomTypeComboBox.AutoRoundedCorners = true;
            this.RoomTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomTypeComboBox.BorderRadius = 17;
            this.RoomTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeComboBox.FocusedState.Parent = this.RoomTypeComboBox;
            this.RoomTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomTypeComboBox.HoverState.Parent = this.RoomTypeComboBox;
            this.RoomTypeComboBox.ItemHeight = 30;
            this.RoomTypeComboBox.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.RoomTypeComboBox.ItemsAppearance.Parent = this.RoomTypeComboBox;
            this.RoomTypeComboBox.Location = new System.Drawing.Point(810, 103);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.ShadowDecoration.Parent = this.RoomTypeComboBox;
            this.RoomTypeComboBox.Size = new System.Drawing.Size(321, 36);
            this.RoomTypeComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RoomTypeComboBox.TabIndex = 9;
            this.RoomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomTypeComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(805, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "Room Type";
            // 
            // BedComboBox
            // 
            this.BedComboBox.Animated = true;
            this.BedComboBox.AutoRoundedCorners = true;
            this.BedComboBox.BackColor = System.Drawing.Color.Transparent;
            this.BedComboBox.BorderRadius = 17;
            this.BedComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BedComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BedComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BedComboBox.FocusedState.Parent = this.BedComboBox;
            this.BedComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BedComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.BedComboBox.HoverState.Parent = this.BedComboBox;
            this.BedComboBox.ItemHeight = 30;
            this.BedComboBox.ItemsAppearance.Parent = this.BedComboBox;
            this.BedComboBox.Location = new System.Drawing.Point(810, 221);
            this.BedComboBox.Name = "BedComboBox";
            this.BedComboBox.ShadowDecoration.Parent = this.BedComboBox;
            this.BedComboBox.Size = new System.Drawing.Size(321, 36);
            this.BedComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BedComboBox.TabIndex = 10;
            this.BedComboBox.SelectedIndexChanged += new System.EventHandler(this.BedComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(805, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 30);
            this.label12.TabIndex = 32;
            this.label12.Text = "Bed";
            // 
            // RoomNumberComboBox
            // 
            this.RoomNumberComboBox.Animated = true;
            this.RoomNumberComboBox.AutoRoundedCorners = true;
            this.RoomNumberComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumberComboBox.BorderRadius = 17;
            this.RoomNumberComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNumberComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumberComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumberComboBox.FocusedState.Parent = this.RoomNumberComboBox;
            this.RoomNumberComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomNumberComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomNumberComboBox.HoverState.Parent = this.RoomNumberComboBox;
            this.RoomNumberComboBox.ItemHeight = 30;
            this.RoomNumberComboBox.ItemsAppearance.Parent = this.RoomNumberComboBox;
            this.RoomNumberComboBox.Location = new System.Drawing.Point(810, 343);
            this.RoomNumberComboBox.Name = "RoomNumberComboBox";
            this.RoomNumberComboBox.ShadowDecoration.Parent = this.RoomNumberComboBox;
            this.RoomNumberComboBox.Size = new System.Drawing.Size(321, 36);
            this.RoomNumberComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RoomNumberComboBox.TabIndex = 11;
            this.RoomNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomNumberComboBox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(805, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 30);
            this.label13.TabIndex = 32;
            this.label13.Text = "Room Number";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Animated = true;
            this.PriceTextBox.AutoRoundedCorners = true;
            this.PriceTextBox.BorderRadius = 17;
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTextBox.DefaultText = "";
            this.PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.DisabledState.Parent = this.PriceTextBox;
            this.PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTextBox.FocusedState.Parent = this.PriceTextBox;
            this.PriceTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTextBox.HoverState.Parent = this.PriceTextBox;
            this.PriceTextBox.Location = new System.Drawing.Point(808, 460);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.PlaceholderText = "";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.ShadowDecoration.Parent = this.PriceTextBox;
            this.PriceTextBox.Size = new System.Drawing.Size(310, 36);
            this.PriceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceTextBox.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(805, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 30);
            this.label14.TabIndex = 30;
            this.label14.Text = "Price";
            // 
            // BookRoomButton
            // 
            this.BookRoomButton.Animated = true;
            this.BookRoomButton.BorderRadius = 30;
            this.BookRoomButton.CheckedState.Parent = this.BookRoomButton;
            this.BookRoomButton.CustomImages.Parent = this.BookRoomButton;
            this.BookRoomButton.FillColor = System.Drawing.Color.Green;
            this.BookRoomButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.BookRoomButton.ForeColor = System.Drawing.Color.White;
            this.BookRoomButton.HoverState.Parent = this.BookRoomButton;
            this.BookRoomButton.Location = new System.Drawing.Point(810, 570);
            this.BookRoomButton.Name = "BookRoomButton";
            this.BookRoomButton.ShadowDecoration.Parent = this.BookRoomButton;
            this.BookRoomButton.Size = new System.Drawing.Size(340, 60);
            this.BookRoomButton.TabIndex = 13;
            this.BookRoomButton.Text = "Allocate Room";
            this.BookRoomButton.Click += new System.EventHandler(this.BookRoomButton_Click);
            // 
            // CustomerRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.BookRoomButton);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RoomNumberComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BedComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RoomTypeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDProofTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CustomerEmailTextBox);
            this.Controls.Add(this.IDProofNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerMobailNoTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitCircleButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox CustomerNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox CustomerMobailNoTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox CustomerEmailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox GenderComboBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox IDProofTypeComboBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox IDProofNumberTextBox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox AddressTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckInDateTimePicker;
        private Guna.UI2.WinForms.Guna2ComboBox RoomTypeComboBox;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox BedComboBox;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox RoomNumberComboBox;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button BookRoomButton;
    }
}