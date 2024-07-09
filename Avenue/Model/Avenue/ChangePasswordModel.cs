using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.Avenue
{
   
    public class ChangePasswordModel 
    {
        public Int32 UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}