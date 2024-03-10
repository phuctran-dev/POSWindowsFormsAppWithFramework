using Newtonsoft.Json;
using POSWindowsFormsAppWithFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWindowsFormsAppWithFramework.UserControls
{
    public partial class BookingsUC : UserControl
    {
        public BookingsUC()
        {
            InitializeComponent();
        }

        private async void BookingsUC_Load(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["POSApis"]);

                var response = await httpClient.GetAsync("/Booking/get-all-bookings");
                var data = JsonConvert.DeserializeObject<List<BookingTableDetail>>(response.Content.ReadAsStringAsync().Result);
                barCircleProgressBar.Visible = false;
                tblBookings.DataSource = data;
            }
        }

        private void gunabtnAddBookingTable_Click(object sender, EventArgs e)
        {
            CreateBookingTableUC createBookingTableUC = new CreateBookingTableUC();
            Controls.Add(createBookingTableUC);
            createBookingTableUC.BringToFront();
        }
    }
}
