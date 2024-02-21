using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POSWindowsFormsAppWithFramework.Models;
using POSWindowsFormsAppWithFramework.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWindowsFormsAppWithFramework.UserControls
{
    public partial class BookingTableUC : UserControl
    {
        private readonly System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public BookingTableUC()
        {
            InitializeComponent();
        }
        
        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["POSApis"]);

                var bookingTableRequestDto = JsonConvert.SerializeObject(new BookingTableRequest
                {
                    Name = txtName.Text,
                    People = int.Parse(txtPeople.Text),
                    PhoneNumber = txtPhoneNumber.Text,
                    Date = txtDate.Value.ToString("dd/MM/yyyy"),
                    Time = txtDate.Value.ToString("HH:mm"),
                    TypeAnniversary = cbbType.Text,
                    Note = txtNote.Text,
                    requestTime = DateTime.Now.ToString("G"),
                });

                var response = await httpClient.PostAsync("/Booking/create-booking",
                                new StringContent(bookingTableRequestDto, Encoding.UTF8, "application/json"));
                lblResult.Visible = true;
                lblResult.BringToFront();
                lblResult.Text = response.Content.ReadAsStringAsync().Result.ToString();

                if (lblResult.Text == "SUCCESS")
                    ClearControls();

                t.Interval = 5000;
                t.Tick += T_Tick;
                t.Start();
            }
        }

        private void BookingTableUC_Load(object sender, EventArgs e)
        {
            List<string> anniversaryTypes = new List<string>();
            cbbType.DataSource = anniversaryTypes;
        }

        public void ClearControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox)
                {
                    control.ResetText();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer _t = sender as System.Windows.Forms.Timer;
            lblResult.Text = "";
            _t.Stop();
        }
    }
}
