using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
    public class RegionCashAccountLnk : XPLiteObject
    {
        private long _regionCashAccountLnkId;

        [Key(AutoGenerate = true)]
        [Persistent]
        public long RegionCashAccountLnkId
        {
            get { return _regionCashAccountLnkId; }
            set { _regionCashAccountLnkId = value; }
        }

        private int _branchId;

        [Persistent]
        public int BranchId
        {
            get { return _branchId; }
            set { _branchId = value; }
        }

        private long _branchCashAccountId;

        [Persistent]
        public long BranchCashAccountId
        {
            get { return _branchCashAccountId; }
            set { _branchCashAccountId = value; }
        }

        private long _bankAccountId;

        [Persistent]
        public long BankAccountId
        {
            get { return _bankAccountId; }
            set { SetPropertyValue("BankAccountId", ref _bankAccountId, value); }
        }

        private int _createdBy;

        [Persistent]
        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        private DateTime _createdDate;
        [Persistent]
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { SetPropertyValue("CreateDate", ref _createdDate, value); }
        }

        private int _updatedBy;

        [Persistent]
        public int UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        private DateTime? _updatedDate;

        [Persistent]
        public DateTime? UpdatedDate
        {
            get { return _updatedDate; }
            set { SetPropertyValue("UpdatedDate", ref _updatedDate, value); }
        }

        public RegionCashAccountLnk() : base() { }
        public RegionCashAccountLnk(Session session) : base(session) { }
    }
}
