using Atlas.Domain.DTO.Authentication;
using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.UserManagement
{
    public class StaffUsersDTO
    {
        public PER_PersonDTO person { get; set; }
        public Auth_UserDTO authUser { get; set; }
        public List<BOS_AuthorizationDTO> authorization { get; set; }
        public string appId { get; set; }
        public bool IsALMSUser { get; set; }
        public string Password { get; set; }
        public List<BOS_ActionDTO> Actions { get; set; }
     
    }

 
}
