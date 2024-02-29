using POSWindowsFormsAppWithFramework.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POSWindowsFormsAppWithFramework
{
    public partial class MainForm : Form
    {
        public bool isLogin = false;

        public MainForm()
        {
            InitializeComponent();
            LoginUC loginUC = new LoginUC();
            addUserControl(loginUC);
        }
         
        private void addUserControl (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Clear ();
            panelMainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUC loginUC = new LoginUC();
            addUserControl(loginUC);
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderUC orderUC = new OrderUC();
            addUserControl(orderUC);
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            UserControl c = new BookingsUC();
            c.Dock = DockStyle.Top;

            Width = c.Width + Width - ClientSize.Width;
            Height = c.Height + Height - ClientSize.Height;

            Controls.Add(c);
            //BookingsUC bookingsUC = new BookingsUC();
            //addUserControl(bookingsUC);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingsUC bokkingsUC = new BookingsUC();
            addUserControl(bokkingsUC);
        }

        private void RefreshMyForm()
        {
            // Do your data update logic here   
            lblTimeNow.Text = DateTime.Now.ToString("t");
            this.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RefreshMyForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshMyForm();
            timer2.Start();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Close the form
                this.Close();
            }
        }
    }
}
