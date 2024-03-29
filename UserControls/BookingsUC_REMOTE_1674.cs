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
            using (var httpClient = new HttpClient())
            {
                DataGridViewRow currentRow = tblBookings.CurrentRow;
                int currentRowIndex = tblBookings.CurrentRow.Index;
                int currentCellIndex = tblBookings.CurrentCell.ColumnIndex;

                var bookingTableRequestDto = JsonConvert.SerializeObject(new BookingTableRequest
                {

                    Name = tblBookings.Rows[currentRowIndex].Cells[4].Value?.ToString(),
                    PhoneNumber = tblBookings.Rows[currentRowIndex].Cells[6].Value?.ToString(),
                    Date = tblBookings.Rows[currentRowIndex].Cells[7].Value?.ToString(),
                    Time = tblBookings.Rows[currentRowIndex].Cells[8].Value?.ToString(),
                    requestTime = DateTime.Now.ToString("G"),
                });

                var bookingTableRequestDtoNoJson = new BookingTableRequest
                {

                    Name = tblBookings.Rows[currentRowIndex].Cells[4].Value?.ToString(),
                    PhoneNumber = tblBookings.Rows[currentRowIndex].Cells[6].Value?.ToString(),
                    Date = tblBookings.Rows[currentRowIndex].Cells[7].Value?.ToString(),
                    Time = tblBookings.Rows[currentRowIndex].Cells[8].Value?.ToString(),
                    requestTime = DateTime.Now.ToString("G"),
                };

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

                //var response = await httpClient.SendAsync(deleteRequest);
                var response2 = await httpClient.DeleteAsync(httpClient.BaseAddress
                    + "Booking/delete-booking" + $"/{bookingTableRequestDtoNoJson.Name}" +
                    $"-{bookingTableRequestDtoNoJson.PhoneNumber}" +
                    $"-{bookingTableRequestDtoNoJson.Date.Replace("/", "")}");
                barCircleProgressBar.Visible = false;
            }
        }
    }
}
