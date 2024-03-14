using Newtonsoft.Json;
using POSWindowsFormsAppWithFramework.Models;
using POSWindowsFormsAppWithFramework.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POSWindowsFormsAppWithFramework.UserControls
{
    public partial class BookingsUC : UserControl
    {
        private readonly string apiUrl = ConfigurationManager.AppSettings["PSG.Booking.Api"];
        public BookingsUC()
        {
            InitializeComponent();
        }

        private async void BookingsUC_Load(object sender, EventArgs e)
        {
            if ( tblBookings.SelectedRows.Count == 0 || tblBookings.SelectedCells.Count == 0)
            {
                btnDeleteBooking.Enabled = false;
                btnEdit.Enabled = false;
            }

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(apiUrl);

                var response = await httpClient.GetAsync("get-all-bookings");
                var data = response.Content.ReadAsStringAsync().Result.ToString();

                barCircleProgressBar.Visible = false;
                List<BookingTableDetail> bookingTableList = JsonConvert.DeserializeObject<List<BookingTableDetail>>(data);
                tblBookings.DataSource = bookingTableList;
            }
        }

        private void gunabtnAddBookingTable_Click(object sender, EventArgs e)
        {
            CreateBookingTableUC createBookingTableUC = new CreateBookingTableUC();
            Controls.Add(createBookingTableUC);
            createBookingTableUC.BringToFront();
        }

        private async void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            tblBookings.Refresh();
            using (var httpClient = new HttpClient())
            {
                barCircleProgressBar.Visible = true;
                httpClient.BaseAddress = new Uri(apiUrl);

                string bookingId = tblBookings.Rows[tblBookings.CurrentRow.Index].Cells[3].Value.ToString();

                var bookingIdDto = new HttpRequestMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(bookingId),
                    Encoding.UTF8, "application/json"),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(apiUrl + $"delete-booking/{bookingId}")
                };
                var response = await httpClient.SendAsync(bookingIdDto);
                barCircleProgressBar.Visible = false;
                tblBookings.Refresh();
                BookingsUC bookingsUC = new BookingsUC();
                bookingsUC.Refresh();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BookingsUC bookingsUC = new BookingsUC();
            bookingsUC.Refresh();
        }

        private void tblBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblBookings.SelectedRows.Count != 0 || tblBookings.SelectedCells.Count != 0)
            {
                if(tblBookings.Rows[tblBookings.CurrentRow.Index].Cells[3].Value?.ToString() != null)
                {
                    btnDeleteBooking.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
