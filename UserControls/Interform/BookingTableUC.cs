using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using POSWindowsFormsAppWithFramework.Models.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace POSWindowsFormsAppWithFramework.UserControls
{
    public partial class BookingTableUC : UserControl
    {
        private readonly System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        private IDbConnection _connection;
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

        private async void BookingTableUC_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["POSApis"]);

                var response = await httpClient.GetAsync("/Booking/get-anniversary-type");

                var resultList = JsonConvert.DeserializeObject<List<string>>(await response.Content.ReadAsStringAsync());
                if (response.IsSuccessStatusCode)
                    ClearControls();

                cbbType.DataSource = resultList;
            }
            
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
