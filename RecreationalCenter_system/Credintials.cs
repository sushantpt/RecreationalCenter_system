using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*this class is used to store xml credintials of employee (as properties of this class) for system login*/
namespace RecreationalCenter_system
{
    public class Credintials
    {
        public string usrFullName { get; set; }
        public string usrName { get; set; }
        public string usrEmail { get; set; }
        public string usrPhoneNo { get; set; }
        public string usrAddress { get; set; }
        public string usrNewPwd { get; set; }
        public string confirmPwd { get; set; }
    }
}
