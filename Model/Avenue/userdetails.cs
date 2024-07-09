using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.Avenue
{

    public sealed class userdetails : XPLiteObject
    {
        private Int64 _userdetailsid;
        [Key(AutoGenerate = true)]
        public Int64 userdetailsid
        {
            
                get
                {
                    return _userdetailsid;
                }
                set
                {
                    SetPropertyValue("userdetailsid", ref _userdetailsid, value);
                }
        }

        private Int32 _userid;
        public Int32 userid
        {
            get
            {
                return _userid;
            }
            set
            {
                SetPropertyValue("userid", ref _userid, value);
            }
        }

        private string _nationalid;
        public string nationalid
        {
            get 
            { 
                return _nationalid;
            }

            set 
            { 
                SetPropertyValue("nationalid", ref _nationalid, value); 
            }
        }

        private string _email;
        public string email
        {
            get 
            { 
                return _email; 
            }
            set 
            { 
                SetPropertyValue("email", ref _email, value); 
            }
        }

        private string _firstname;
        public string firstname
        {
            get 
            {
                return _firstname;
                  
            }
            set 
            { 
                SetPropertyValue("firstname",ref _firstname, value); 
            }
        }

        private string _lastname;
        public string lastname
        {
            get 
            { 
                return _lastname; 
            }
            set 
            { 
                SetPropertyValue("lastname", ref _lastname, value); 
            }
        }

        private Int32 _genderid;
        public Int32 genderid
        {
            get 
            { 
                return _genderid; 
            }
            set 
            { 
                SetPropertyValue("genderid",ref _genderid, value); 
            }
        }

        private string _contactnumber;
        public string contactnumber
        {
            get 
            { 
                return _contactnumber; 
            }
            set 
            { 
                SetPropertyValue("contactnumber", ref _contactnumber, value); 
            }
        }

        private DateTime _dateofbirth;
        public DateTime dateofbirth
        {
            get 
            { 
                return _dateofbirth; 
            }
            set 
            { 
                SetPropertyValue("dateofbirth",ref _dateofbirth, value); 
            }
        }

        private string _designation;
        public string designation
        {
            get 
            { 
                return _designation; 
            }
            set 
            { 
                SetPropertyValue("designation", ref _designation, value); 
            }
        }

        private Int32 _departmentid;
        public Int32 departmentid
        {
            get 
            { 
                return _departmentid; 
            }
            set 
            { 
                SetPropertyValue("departmentid", ref _departmentid, value); 
            }
        }

        private Int32 _roleid;
        public Int32 roleid
        {
            get 
            { 
                return _roleid; 
            }
            set 
            { 
                SetPropertyValue("roleid", ref _roleid ,value); 
            }
        }

        private bool _isactive;
        public bool isactive
        {
            get 
            { 
                return _isactive; 
            }
            set 
            { 
                SetPropertyValue("isactive",ref _isactive, value); 
            }
        }

        #region Constructor
        public userdetails() : base() { }

        public userdetails(Session session) : base(session) { }
        #endregion
    }
}