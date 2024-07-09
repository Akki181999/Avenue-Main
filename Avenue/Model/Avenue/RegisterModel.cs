using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.Avenue
{
    public class RegisterModel 
    {
        public Int32 UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}