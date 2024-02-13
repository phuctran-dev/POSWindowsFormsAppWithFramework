using POSWindowsFormsAppWithFramework.Models;
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
    public partial class BookingTableUC : UserControl
    {
        public System.Windows.Forms.ListBox.ObjectCollection Items { get; }

        List<BookingTableDetail> bookingTables = new List<BookingTableDetail>();
        public BookingTableUC()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookingTableDetail bookingTableDetail = new BookingTableDetail();
            {
                bookingTableDetail.Id = Guid.NewGuid();
                bookingTableDetail.Name = txtName.Text;
                bookingTableDetail.People = int.Parse(txtPeople.Text);
                bookingTableDetail.PhoneNumber = txtPhoneNumber.Text;
                bookingTableDetail.Date = txtDate.Value.ToString("dd/MM/yyyy");
                bookingTableDetail.Time = txtDate.Value.ToString("HH:mm");
                bookingTableDetail.TypeAnniversary = cbbType.Text;
                bookingTableDetail.Note = txtNote.Text;
            }
            bookingTables.Add(bookingTableDetail);
            ClearControls();
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
    }
}
