namespace POSWindowsFormsAppWithFramework
{
    partial class MainForm
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
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMain.BorderRadius = 15;
            this.panelMain.Controls.Add(this.panelMainContainer);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(8, 7);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1051, 724);
            this.panelMain.TabIndex = 0;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContainer.Location = new System.Drawing.Point(140, 57);
            this.panelMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(911, 667);
            this.panelMainContainer.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnBooking);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 667);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(4, 526);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(133, 123);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Sign Out";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReport.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnReport.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(4, 395);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(133, 123);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBooking.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBooking.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnBooking.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(3, 265);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(133, 123);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Booking";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrder.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnOrder.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(4, 134);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(133, 123);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogin.Checked = true;
            this.btnLogin.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(3, 4);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 123);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(497, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "12:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnReport;
        private System.Windows.Forms.Panel panelMainContainer;
    }
}

