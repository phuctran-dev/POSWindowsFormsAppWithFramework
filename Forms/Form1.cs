using POSWindowsFormsAppWithFramework.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWindowsFormsAppWithFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomePageController controller = new HomePageController();
            addController(controller);
        }

        private void addController(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_HomePage_Click(object sender, EventArgs e)
        {
            HomePageController controller = new HomePageController();
            addController(controller);
        }
    }
}
