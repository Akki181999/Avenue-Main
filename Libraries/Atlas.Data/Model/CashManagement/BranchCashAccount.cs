using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
  public  class BranchCashAccount : XPLiteObject
    {
       
        
        private long _branchCashAccountId;
        [Key(AutoGenerate = true)]
        [Persistent]
        public long BranchCashAccountId
        {
            get
            {
                return _branchCashAccountId;
            }
            set
            {
                _branchCashAccountId = value;
            }
        }

        private string _accountNumber;
        [Persistent]
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        private string _accountName;
        [Persistent]
        public string AccountName
        {
            get
            {
                return _accountName;
            }
            set
            {
                _accountName = value;
            }
        }

        private int _branchId;
        [Persistent]
        public int BranchId
        {
            get { return _branchId; }
            set { _branchId = value; }
        }

        private int _createdBy;
        [Persistent]
        public int CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
               _createdBy = value;
            }
        }
        

        private DateTime _createdDT;
        [Persistent]
        public DateTime CreatedDate
        {
            get
            {
                return _createdDT;
            }
            set
            {
                SetPropertyValue("CreateDate", ref _createdDT, value);
            }
        }

        private DateTime? _updatedDT;
        [Persistent]
        public DateTime? UpdatedDate
        {
            get
            {
                return _updatedDT;
            }
            set
            {
                SetPropertyValue("UpdatedDate", ref _updatedDT, value);
            }
        }
        private long _accAccountId;
        [Persistent]
        public long AccAccountId
        {
            get
            {
                return _accAccountId;
            }
            set
            {
                _accAccountId = value;
            }
        }
        private int _updatedBy;
        [Persistent]
        public int UpdatedBy
        {
            get
            {
                return _updatedBy;
            }
            set
            {
                _updatedBy = value;
            }
        }

        public BranchCashAccount() : base() { }
        public BranchCashAccount(Session session) : base(session) { }
    }
}
