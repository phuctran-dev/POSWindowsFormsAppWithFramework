namespace POSWindowsFormsAppWithFramework.UserControls
{
    partial class BookingsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunabtnAddBookingTable = new Guna.UI2.WinForms.Guna2Button();
            this.tblBookings = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAnniversaryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBooking = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.barCircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBar.DefaultText = "";
            this.txtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBar.Location = new System.Drawing.Point(3, 78);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.PasswordChar = '\0';
            this.txtSearchBar.PlaceholderText = "";
            this.txtSearchBar.SelectedText = "";
            this.txtSearchBar.Size = new System.Drawing.Size(602, 27);
            this.txtSearchBar.TabIndex = 1;
            // 
            // gunabtnAddBookingTable
            // 
            this.gunabtnAddBookingTable.BorderRadius = 15;
            this.gunabtnAddBookingTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnAddBookingTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnAddBookingTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnAddBookingTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnAddBookingTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunabtnAddBookingTable.FillColor = System.Drawing.Color.MidnightBlue;
            this.gunabtnAddBookingTable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnAddBookingTable.ForeColor = System.Drawing.Color.White;
            this.gunabtnAddBookingTable.Location = new System.Drawing.Point(0, 0);
            this.gunabtnAddBookingTable.Margin = new System.Windows.Forms.Padding(6);
            this.gunabtnAddBookingTable.Name = "gunabtnAddBookingTable";
            this.gunabtnAddBookingTable.Size = new System.Drawing.Size(197, 45);
            this.gunabtnAddBookingTable.TabIndex = 2;
            this.gunabtnAddBookingTable.Text = "ADD";
            this.gunabtnAddBookingTable.Click += new System.EventHandler(this.gunabtnAddBookingTable_Click);
            // 
            // tblBookings
            // 
            this.tblBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnPeople,
            this.columnPhone,
            this.columnDate,
            this.columnTime,
            this.columnAnniversaryType,
            this.columnStatus});
            this.tblBookings.Location = new System.Drawing.Point(7, 120);
            this.tblBookings.Name = "tblBookings";
            this.tblBookings.Size = new System.Drawing.Size(602, 475);
            this.tblBookings.TabIndex = 4;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "Name";
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            // 
            // columnPeople
            // 
            this.columnPeople.DataPropertyName = "People";
            this.columnPeople.HeaderText = "People";
            this.columnPeople.Name = "columnPeople";
            this.columnPeople.Width = 50;
            // 
            // columnPhone
            // 
            this.columnPhone.DataPropertyName = "Phone";
            this.columnPhone.HeaderText = "Phone";
            this.columnPhone.Name = "columnPhone";
            // 
            // columnDate
            // 
            this.columnDate.DataPropertyName = "Date";
            this.columnDate.HeaderText = "Date";
            this.columnDate.Name = "columnDate";
            this.columnDate.Width = 80;
            // 
            // columnTime
            // 
            this.columnTime.DataPropertyName = "Time";
            this.columnTime.HeaderText = "Time";
            this.columnTime.Name = "columnTime";
            this.columnTime.Width = 80;
            // 
            // columnAnniversaryType
            // 
            this.columnAnniversaryType.DataPropertyName = "AnniversaryType";
            this.columnAnniversaryType.HeaderText = "Anniversary Type";
            this.columnAnniversaryType.Name = "columnAnniversaryType";
            // 
            // columnStatus
            // 
            this.columnStatus.DataPropertyName = "Status";
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.btnDeleteBooking);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.gunabtnAddBookingTable);
            this.panel1.Location = new System.Drawing.Point(618, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 235);
            this.panel1.TabIndex = 5;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button3.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(0, 135);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(6);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(197, 45);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "DUPLICATE";
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BorderRadius = 15;
            this.btnDeleteBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteBooking.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Location = new System.Drawing.Point(0, 90);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(197, 45);
            this.btnDeleteBooking.TabIndex = 6;
            this.btnDeleteBooking.Text = "DELETE";
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 45);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(6);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(197, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "EDIT";
            // 
            // barCircleProgressBar
            // 
            this.barCircleProgressBar.Animated = true;
            this.barCircleProgressBar.AnimationSpeed = 0.5F;
            this.barCircleProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.barCircleProgressBar.FillThickness = 15;
            this.barCircleProgressBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCircleProgressBar.ForeColor = System.Drawing.Color.White;
            this.barCircleProgressBar.Location = new System.Drawing.Point(351, 274);
            this.barCircleProgressBar.Minimum = 0;
            this.barCircleProgressBar.Name = "barCircleProgressBar";
            this.barCircleProgressBar.ProgressThickness = 15;
            this.barCircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.barCircleProgressBar.Size = new System.Drawing.Size(50, 50);
            this.barCircleProgressBar.TabIndex = 23;
            this.barCircleProgressBar.Text = "guna2CircleProgressBar1";
            this.barCircleProgressBar.Value = 40;
            this.barCircleProgressBar.Visible = false;
            // 
            // BookingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.barCircleProgressBar);
            this.Controls.Add(this.tblBookings);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.panel1);
            this.Name = "BookingsUC";
            this.Size = new System.Drawing.Size(821, 598);
            this.Load += new System.EventHandler(this.BookingsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBar;
        private Guna.UI2.WinForms.Guna2Button gunabtnAddBookingTable;
        private System.Windows.Forms.DataGridView tblBookings;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBooking;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar barCircleProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAnniversaryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
    }
}
