using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Application_AccountMapping
{
    public sealed class Application_AccountMapping : XPLiteObject
    {
        private long _applicationAccountMappingId { get; set; }
        [Key(AutoGenerate = true)]
        public long ApplicationAccountMappingId
        {
            get
            {
                return _applicationAccountMappingId;
            }
            set
            {
                _applicationAccountMappingId = value;
            }
        }

        private int _applicationId { get; set; }
        public int ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                _applicationId = value;
            }
        }

        private long _accountId { get; set; }
        public long AccountId
        {
            get
            {
                return _accountId;
            }
            set
            {
                _accountId = value;
            }
        }

        private int _accountTypeId { get; set; }
        public int AccountTypeId
        {
            get
            {
                return _accountTypeId;
            }
            set
            {
                _accountTypeId = value;
            }
        }


        private string idnumber { get; set; }
        public string IDNumber
        {
            get
            {
                return idnumber;
            }
            set
            {
                idnumber = value;
            }
        }

        private string firstname { get; set; }
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        private string surname { get; set; }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        private string cellno { get; set; }
        public string CellNo
        {
            get
            {
                return cellno;
            }
            set
            {
                cellno = value;
            }
        }

        private string email { get; set; }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        #region Constructors

        public Application_AccountMapping() : base() { }
        public Application_AccountMapping(Session session) : base(session) { }

        #endregion
    }
}
