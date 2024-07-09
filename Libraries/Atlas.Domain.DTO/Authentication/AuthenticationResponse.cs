using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Authentication
{
    public class AuthenticationResponse
    {
        public Auth_UserDTO User { get; set; }
        public BOS_SessionDTO Session { get; set; }
    }
}
