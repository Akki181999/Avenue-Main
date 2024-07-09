using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public class Auth_LoginData
    {
        public string appId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string machineIp { get; set; }
        public string browserInfo { get; set; }
        public bool isFingerPrintCheck { get; set; }
        public bool IsFingerPrintbypass { get; set; }
        public string ServerIpAddress { get; set; }
        public int? CompanyId { get; set; }

    }
}
