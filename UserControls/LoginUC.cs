using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWindowsFormsAppWithFramework.UserControls
{
    public partial class LoginUC : UserControl
    {
        Dictionary<string, string> accounts = new Dictionary<string, string>();

        public void CreateAccount(string username, string password)
        {
            do
            {
                txtResult.Text = "Account Exits Already, Try Again!";
                txtResult.Visible = true;
                txtResult.BringToFront();
            }
            while (CheckAccount(username, null));
        }
        public bool CheckAccount(string username, string password)
        {
            if (accounts.ContainsKey(username) && accounts[username] == password)
                return true;
            return false;
        }

        public LoginUC()
        {
            InitializeComponent();
            accounts.Add("admin", "admin");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Contains("@"))
            {
                lbl_invalidUsername.Text = "Cannot contain @ in username. Please try again !";
                txtResult.Visible = true;
                txtResult.BringToFront();
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckAccount(txtUsername.Text, txtPassword.Text))
                txtResult.Text = "Succesful";
            else
                txtResult.Text = "Failed";
            txtResult.Visible = true;
            txtResult.BringToFront();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CreateAccount(txtUsername.Text, txtPassword.Text);
        }
    }
}
