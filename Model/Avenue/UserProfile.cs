using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.Avenue
{
    public sealed class UserProfile : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public UserProfile() : base() { }
        public UserProfile(Session session) : base(session) { }
    }
}