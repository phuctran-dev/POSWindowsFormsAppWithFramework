﻿using Newtonsoft.Json;
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
            DataGridViewColumn currentColumn = tblBookings.Columns[tblBookings.CurrentCell.ColumnIndex];
            DataGridViewRow currentRow2= tblBookings.Rows[tblBookings.CurrentRow.Index];

            using (var httpClient = new HttpClient())
            {
                DataGridViewRow currentRow = tblBookings.CurrentRow;
                
                var bookingTableRequestDto = JsonConvert.SerializeObject(new BookingTableRequest
                {

                    Name = currentRow.Cells[3].Value.ToString(),
                    PhoneNumber = currentRow.Cells[5].Value.ToString(),
                    Date = currentRow.Cells[6].Value.ToString(),
                    Time = currentRow.Cells[7].Value.ToString(),
                    requestTime = DateTime.Now.ToString("G"),
                });
                var deleteRequest = new HttpRequestMessage
                {
                    Content = new StringContent(JsonConvert.SerializeObject(bookingTableRequestDto),
                    Encoding.UTF8, "application/json"),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(ConfigurationManager.AppSettings["POSApis"] + "/Booking/delete-booking")
                };

                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["POSApis"]);

                //var response = await httpClient.DeleteAsync("/Booking/delete-booking",
                //    new StringContent(bookingTableRequestDto, Encoding.UTF8, "application/json"));
                //var data = response.Content.ReadAsStringAsync().Result.ToString();

                var response = httpClient.SendAsync(deleteRequest).Result;

                barCircleProgressBar.Visible = false;
            }
        }
    }
}
