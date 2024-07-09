using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.UserManagement
{
    public class ChangePasswordDTO
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
    }

}
