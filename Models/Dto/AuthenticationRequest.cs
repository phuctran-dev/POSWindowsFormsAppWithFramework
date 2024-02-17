using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWindowsFormsAppWithFramework.Models.Dto
{
    public class AuthenticationRequest : Account
    {
        public string requestTime {  get; set; }
    }
}
