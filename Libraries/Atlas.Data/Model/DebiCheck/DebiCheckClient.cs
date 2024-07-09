using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public sealed class DebiCheckClient : XPLiteObject
    {
        private int _applicationId;
        [Persistent("ApplicationId")]
        public int ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _applicationId, value);
            }
        }
        private string _clientNumber;
        [Persistent("ClientNumber")]
        public string ClientNumber
        {
            get
            {
                return _clientNumber;
            }
            set
            {
                SetPropertyValue("ClientNumber", ref _clientNumber, value);
            }
        }
        private string _clientName;
        [Persistent("ClientName")]
        public string ClientName
        {
            get
            {
                return _clientName;
            }
            set
            {
                SetPropertyValue("ClientName", ref _clientName, value);
            }
        }
        private string _iDType;
        [Persistent("IDType")]
        public string IDType
        {
            get
            {
                return _iDType;
            }
            set
            {
                SetPropertyValue("IDType", ref _iDType, value);
            }
        }

        private string _iDNumber;
        [Persistent("IDNumber")]
        [Key]
        public string IDNumber
        {
            get
            {
                return _iDNumber;
            }
            set
            {
                SetPropertyValue("IDNumber", ref _iDNumber, value);
            }
        }
        private string _cellphoneNumber;
        [Persistent("CellphoneNumber")]
        public string CellphoneNumber
        {
            get
            {
                return _cellphoneNumber;
            }
            set
            {
                SetPropertyValue("CellphoneNumber", ref _cellphoneNumber, value);
            }
        }
        private string _eMail;
        [Persistent("EMail")]
        public string EMail
        {
            get
            {
                return _eMail;
            }
            set
            {
                SetPropertyValue("EMail", ref _eMail, value);
            }
        }
        private int _bankCode;
        [Persistent("BankCode")]
        public int BankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                SetPropertyValue("BankCode", ref _bankCode, value);
            }
        }
        private int _branchCode;
        [Persistent("BranchCode")]
        public int BranchCode
        {
            get
            {
                return _branchCode;
            }
            set
            {
                SetPropertyValue("BranchCode", ref _branchCode, value);
            }
        }
        private int _accountType;
        [Persistent("AccountType")]
        public int AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                SetPropertyValue("AccountType", ref _accountType, value);
            }
        }
        private string _accountNumber;
        [Persistent("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                SetPropertyValue("AccountNumber", ref _accountNumber, value);
            }
        }
        private string _accountHolderName;
        [Persistent("AccountHolderName")]
        public string AccountHolderName
        {
            get
            {
                return _accountHolderName;
            }
            set
            {
                SetPropertyValue("AccountHolderName", ref _accountHolderName, value);
            }
        }
        private string _employeeGroupCode;
        [Persistent("EmployeeGroupCode")]
        public string EmployeeGroupCode
        {
            get
            {
                return _employeeGroupCode;
            }
            set
            {
                SetPropertyValue("EmployeeGroupCode", ref _employeeGroupCode, value);
            }
        }

        private string _description;
        [Persistent("Description")]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetPropertyValue("Description", ref _description, value);
            }
        }

        private string _response;
        [Persistent("Response")]
        public string Response
        {
            get
            {
                return _response;
            }
            set
            {
                SetPropertyValue("Response", ref _response, value);
            }
        }

        private string _status;
        [Persistent("Status")]
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                SetPropertyValue("Status", ref _status, value);
            }
        }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public DateTime? UpdatedDate { get; set; }


        #region Constructors

        public DebiCheckClient() : base() { }
        public DebiCheckClient(Session session) : base(session) { }

        #endregion
    }

}