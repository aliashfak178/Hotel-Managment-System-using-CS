
namespace Hotel_Managment_System
{
    partial class AddRoomsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitCircleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.RoomsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RoomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RefreshCircleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BedComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddNewRoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteRoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).BeginInit();
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
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(469, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "ADD New Rooms";
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
            this.ExitCircleButton.TabIndex = 10;
            this.ExitCircleButton.Click += new System.EventHandler(this.ExitCircleButton_Click);
            // 
            // RoomsDataGridView
            // 
            this.RoomsDataGridView.AllowUserToAddRows = false;
            this.RoomsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.RoomsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RoomsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RoomsDataGridView.ColumnHeadersHeight = 42;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomsDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.RoomsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RoomsDataGridView.EnableHeadersVisualStyles = false;
            this.RoomsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsDataGridView.Location = new System.Drawing.Point(12, 55);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.ReadOnly = true;
            this.RoomsDataGridView.RowHeadersVisible = false;
            this.RoomsDataGridView.RowTemplate.Height = 40;
            this.RoomsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.RoomsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomsDataGridView.Size = new System.Drawing.Size(577, 653);
            this.RoomsDataGridView.TabIndex = 6;
            this.RoomsDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RoomsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomsDataGridView.ThemeStyle.HeaderStyle.Height = 42;
            this.RoomsDataGridView.ThemeStyle.ReadOnly = true;
            this.RoomsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.RoomsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoomsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomsDataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.RoomsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomsDataGridView_CellDoubleClick);
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
            this.RoomTypeComboBox.Location = new System.Drawing.Point(632, 308);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.ShadowDecoration.Parent = this.RoomTypeComboBox;
            this.RoomTypeComboBox.Size = new System.Drawing.Size(481, 36);
            this.RoomTypeComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RoomTypeComboBox.TabIndex = 1;
            // 
            // RoomNoTextBox
            // 
            this.RoomNoTextBox.Animated = true;
            this.RoomNoTextBox.AutoRoundedCorners = true;
            this.RoomNoTextBox.BorderRadius = 17;
            this.RoomNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNoTextBox.DefaultText = "";
            this.RoomNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNoTextBox.DisabledState.Parent = this.RoomNoTextBox;
            this.RoomNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNoTextBox.FocusedState.Parent = this.RoomNoTextBox;
            this.RoomNoTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.RoomNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNoTextBox.HoverState.Parent = this.RoomNoTextBox;
            this.RoomNoTextBox.Location = new System.Drawing.Point(632, 217);
            this.RoomNoTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.RoomNoTextBox.Name = "RoomNoTextBox";
            this.RoomNoTextBox.PasswordChar = '\0';
            this.RoomNoTextBox.PlaceholderText = "";
            this.RoomNoTextBox.SelectedText = "";
            this.RoomNoTextBox.ShadowDecoration.Parent = this.RoomNoTextBox;
            this.RoomNoTextBox.Size = new System.Drawing.Size(475, 36);
            this.RoomNoTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RoomNoTextBox.TabIndex = 0;
            this.RoomNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomNoTextBox_KeyPress);
            // 
            // RefreshCircleButton
            // 
            this.RefreshCircleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshCircleButton.Animated = true;
            this.RefreshCircleButton.CheckedState.Parent = this.RefreshCircleButton;
            this.RefreshCircleButton.CustomImages.Parent = this.RefreshCircleButton;
            this.RefreshCircleButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.RefreshCircleButton.ForeColor = System.Drawing.Color.White;
            this.RefreshCircleButton.HoverState.Parent = this.RefreshCircleButton;
            this.RefreshCircleButton.Location = new System.Drawing.Point(1135, 55);
            this.RefreshCircleButton.Name = "RefreshCircleButton";
            this.RefreshCircleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.RefreshCircleButton.ShadowDecoration.Parent = this.RefreshCircleButton;
            this.RefreshCircleButton.Size = new System.Drawing.Size(62, 48);
            this.RefreshCircleButton.TabIndex = 5;
            this.RefreshCircleButton.Text = "↺";
            this.RefreshCircleButton.Click += new System.EventHandler(this.RefreshCircleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "Bed";
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
            this.BedComboBox.Items.AddRange(new object[] {
            "Single Bed",
            "Double Bed",
            "Triple Bed"});
            this.BedComboBox.ItemsAppearance.Parent = this.BedComboBox;
            this.BedComboBox.Location = new System.Drawing.Point(632, 414);
            this.BedComboBox.Name = "BedComboBox";
            this.BedComboBox.ShadowDecoration.Parent = this.BedComboBox;
            this.BedComboBox.Size = new System.Drawing.Size(491, 36);
            this.BedComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BedComboBox.TabIndex = 2;
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
            this.PriceTextBox.Location = new System.Drawing.Point(632, 504);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.PasswordChar = '\0';
            this.PriceTextBox.PlaceholderText = "";
            this.PriceTextBox.SelectedText = "";
            this.PriceTextBox.ShadowDecoration.Parent = this.PriceTextBox;
            this.PriceTextBox.Size = new System.Drawing.Size(475, 36);
            this.PriceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceTextBox.TabIndex = 3;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(640, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Room Price";
            // 
            // AddNewRoomButton
            // 
            this.AddNewRoomButton.Animated = true;
            this.AddNewRoomButton.BorderRadius = 30;
            this.AddNewRoomButton.CheckedState.Parent = this.AddNewRoomButton;
            this.AddNewRoomButton.CustomImages.Parent = this.AddNewRoomButton;
            this.AddNewRoomButton.FillColor = System.Drawing.Color.Green;
            this.AddNewRoomButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.AddNewRoomButton.ForeColor = System.Drawing.Color.White;
            this.AddNewRoomButton.HoverState.Parent = this.AddNewRoomButton;
            this.AddNewRoomButton.Location = new System.Drawing.Point(632, 559);
            this.AddNewRoomButton.Name = "AddNewRoomButton";
            this.AddNewRoomButton.ShadowDecoration.Parent = this.AddNewRoomButton;
            this.AddNewRoomButton.Size = new System.Drawing.Size(491, 60);
            this.AddNewRoomButton.TabIndex = 4;
            this.AddNewRoomButton.Text = "Add New Room";
            this.AddNewRoomButton.Click += new System.EventHandler(this.AddNewRoomButton_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Animated = true;
            this.DeleteRoomButton.BorderRadius = 30;
            this.DeleteRoomButton.CheckedState.Parent = this.DeleteRoomButton;
            this.DeleteRoomButton.CustomImages.Parent = this.DeleteRoomButton;
            this.DeleteRoomButton.FillColor = System.Drawing.Color.Red;
            this.DeleteRoomButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteRoomButton.ForeColor = System.Drawing.Color.White;
            this.DeleteRoomButton.HoverState.Parent = this.DeleteRoomButton;
            this.DeleteRoomButton.Location = new System.Drawing.Point(632, 625);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.ShadowDecoration.Parent = this.DeleteRoomButton;
            this.DeleteRoomButton.Size = new System.Drawing.Size(491, 60);
            this.DeleteRoomButton.TabIndex = 4;
            this.DeleteRoomButton.Text = "Delete Room";
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // AddRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.DeleteRoomButton);
            this.Controls.Add(this.AddNewRoomButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.RefreshCircleButton);
            this.Controls.Add(this.RoomNoTextBox);
            this.Controls.Add(this.BedComboBox);
            this.Controls.Add(this.RoomTypeComboBox);
            this.Controls.Add(this.RoomsDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRoomsForm";
            this.Load += new System.EventHandler(this.AddRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitCircleButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView RoomsDataGridView;
        private Guna.UI2.WinForms.Guna2ComboBox RoomTypeComboBox;
        private Guna.UI2.WinForms.Guna2TextBox RoomNoTextBox;
        private Guna.UI2.WinForms.Guna2CircleButton RefreshCircleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox BedComboBox;
        private Guna.UI2.WinForms.Guna2TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button AddNewRoomButton;
        private Guna.UI2.WinForms.Guna2Button DeleteRoomButton;
    }
}