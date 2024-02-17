using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POSWindowsFormsAppWithFramework.Data.Constants;
using POSWindowsFormsAppWithFramework.Models.Dto;

namespace POSWindowsFormsAppWithFramework.UserControls
{
    public partial class LoginUC : UserControl
    {
        private readonly System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        private readonly IConfigurationSystem _configurationSystem;
        Dictionary<string, string> accounts = new Dictionary<string, string>();

        public LoginUC()
        {
            InitializeComponent();
            accounts.Add("admin", "admin");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Contains("@"))
            {
                lbl_invalidUsername.Text = AuthenticaticalConstants.INVALID_USERNAME;
                lbl_invalidUsername.Visible = true;
                lbl_invalidUsername.BringToFront();
            }
            else
            {
                lbl_invalidUsername.Visible = false;
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text.Contains(" "))
            {
                lbl_invalidPassword.Text = AuthenticaticalConstants.INVALID_PASSWORD;
                lbl_invalidPassword.Visible = true;
                lbl_invalidPassword.BringToFront();
            }
            else
            {
                lbl_invalidPassword.Visible = false;
            }
        }
        [HttpPost]
        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["POSApis"]);

                var authenticationRequestDto = JsonConvert.SerializeObject(new AuthenticationRequest
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    requestTime = DateTime.Now.ToString("G"),
                });

                var response = await httpClient.PostAsync($"/Account/login", 
                                new StringContent(authenticationRequestDto, Encoding.UTF8, "application/json"));

                lblResult.Visible = true;   
                lblResult.BringToFront();
                lblResult.Text = response.Content.ReadAsStringAsync().Result.ToString();
                t.Interval = 5000;
                t.Tick += T_Tick;
                t.Start();
            }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["POSApis"]);

                var loginAccountDto = JsonConvert.SerializeObject(new AuthenticationRequest
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    requestTime = DateTime.Now.ToString("G"),
                });

                var response = await httpClient.PostAsync($"/Account/register",
                                new StringContent(loginAccountDto, Encoding.UTF8, "application/json"));

                lblResult.Visible = true;
                lblResult.BringToFront();
                lblResult.Text = response.Content.ReadAsStringAsync().Result.ToString();
                t.Interval = 5000;
                t.Tick += T_Tick;
                t.Start();
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer _t = sender as System.Windows.Forms.Timer;
            lblResult.Text = "";
            _t.Stop();
        }
    }
}
