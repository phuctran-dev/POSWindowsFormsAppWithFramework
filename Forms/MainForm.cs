using POSWindowsFormsAppWithFramework.UserControls;
using System;
using System.Windows.Forms;

namespace POSWindowsFormsAppWithFramework
{
    public partial class MainForm : Form
    {
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
            panelMainContainer.Controls.Add (userControl);
            userControl.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
    }
}
