
namespace Hotel_Managment_System
{
    partial class CheckOutForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitCircleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.RoomsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckOutDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckOutButton = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(522, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Check Out";
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.RoomsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.RoomsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoomsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.RoomsDataGridView.ColumnHeadersHeight = 42;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomsDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.RoomsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RoomsDataGridView.EnableHeadersVisualStyles = false;
            this.RoomsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsDataGridView.Location = new System.Drawing.Point(22, 55);
            this.RoomsDataGridView.Name = "RoomsDataGridView";
            this.RoomsDataGridView.ReadOnly = true;
            this.RoomsDataGridView.RowHeadersVisible = false;
            this.RoomsDataGridView.RowTemplate.Height = 40;
            this.RoomsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoomsDataGridView.Size = new System.Drawing.Size(1153, 459);
            this.RoomsDataGridView.TabIndex = 11;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Animated = true;
            this.NameTextBox.AutoRoundedCorners = true;
            this.NameTextBox.BorderRadius = 17;
            this.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox.DefaultText = "";
            this.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.DisabledState.Parent = this.NameTextBox;
            this.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextBox.FocusedState.Parent = this.NameTextBox;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTextBox.HoverState.Parent = this.NameTextBox;
            this.NameTextBox.Location = new System.Drawing.Point(22, 575);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.PlaceholderText = "";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.ShadowDecoration.Parent = this.NameTextBox;
            this.NameTextBox.Size = new System.Drawing.Size(307, 36);
            this.NameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NameTextBox.TabIndex = 0;
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
            this.RoomNoTextBox.Location = new System.Drawing.Point(363, 575);
            this.RoomNoTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.RoomNoTextBox.Name = "RoomNoTextBox";
            this.RoomNoTextBox.PasswordChar = '\0';
            this.RoomNoTextBox.PlaceholderText = "";
            this.RoomNoTextBox.ReadOnly = true;
            this.RoomNoTextBox.SelectedText = "";
            this.RoomNoTextBox.ShadowDecoration.Parent = this.RoomNoTextBox;
            this.RoomNoTextBox.Size = new System.Drawing.Size(307, 36);
            this.RoomNoTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RoomNoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Room Number";
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.CheckedState.Parent = this.CheckOutDateTimePicker;
            this.CheckOutDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CheckOutDateTimePicker.HoverState.Parent = this.CheckOutDateTimePicker;
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(700, 575);
            this.CheckOutDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CheckOutDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.ShadowDecoration.Parent = this.CheckOutDateTimePicker;
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(308, 36);
            this.CheckOutDateTimePicker.TabIndex = 2;
            this.CheckOutDateTimePicker.Value = new System.DateTime(2021, 5, 3, 11, 30, 4, 238);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(695, 538);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 30);
            this.label10.TabIndex = 34;
            this.label10.Text = "Check Out Date";
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Animated = true;
            this.CheckOutButton.BorderRadius = 30;
            this.CheckOutButton.CheckedState.Parent = this.CheckOutButton;
            this.CheckOutButton.CustomImages.Parent = this.CheckOutButton;
            this.CheckOutButton.FillColor = System.Drawing.Color.Green;
            this.CheckOutButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.CheckOutButton.ForeColor = System.Drawing.Color.White;
            this.CheckOutButton.HoverState.Parent = this.CheckOutButton;
            this.CheckOutButton.Location = new System.Drawing.Point(700, 648);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.ShadowDecoration.Parent = this.CheckOutButton;
            this.CheckOutButton.Size = new System.Drawing.Size(340, 60);
            this.CheckOutButton.TabIndex = 3;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoomNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RoomsDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton ExitCircleButton;
        private Guna.UI2.WinForms.Guna2DataGridView RoomsDataGridView;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox RoomNoTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button CheckOutButton;
    }
}