using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POSWindowsFormsAppWithFramework.Models
{
    public class BookingTableDetail
    {
        public string BookingId {  get; set; }
        public string Name { get; set; }
        public int People { get; set; }
        public string PhoneNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string TypeAnniversary {  get; set; }
        public string Note {  get; set; }


    }
}
