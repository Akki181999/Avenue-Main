using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
    public class BranchCashReport : XPLiteObject
    {
        private long _branchCashReportId;

        [Key(AutoGenerate = true)]
        [Persistent]
        public long BranchCashReportId
        {
            get { return _branchCashReportId; }
            set { _branchCashReportId = value; }
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

        private DateTime _reportingDate;

        [Persistent]
        public DateTime ReportingDate
        {
            get { return _reportingDate; }
            set { SetPropertyValue("ReportingDate", ref _reportingDate, value); }
        }

        private Decimal _openingBalance;

        [Persistent]
        public Decimal OpeningBalance
        {
            get { return _openingBalance; }
            set { SetPropertyValue("OpeningBalance", ref _openingBalance, value); }
        }

        private Decimal _RepaymentAmount;

        [Persistent]
        public Decimal RepaymentAmount
        {
            get { return _RepaymentAmount; }
            set { SetPropertyValue("RepaymentAmount", ref _RepaymentAmount, value); }
        }

        private Decimal _closingBalance;

        [Persistent]
        public Decimal ClosingBalance
        {
            get { return _closingBalance; }
            set { SetPropertyValue("ClosingBalance", ref _closingBalance, value); }
        }

        private int _nuCardClosingBalanceCount;

        [Persistent]
        public int NuCardClosingBalanceCount
        {
            get { return _nuCardClosingBalanceCount; }
            set { SetPropertyValue("NuCardClosingBalanceCount", ref _nuCardClosingBalanceCount, value); }
        }

        private Decimal _Difference;

        [Persistent]
        public Decimal Difference
        {
            get { return _Difference; }
            set { SetPropertyValue("Difference", ref _Difference, value); }
        }
        private Decimal _userReportedBalance;

        [Persistent]
        public Decimal UserReportedBalance
        {
            get { return _userReportedBalance; }
            set { SetPropertyValue("ReportingDate", ref _userReportedBalance, value); }
        }
        
        private int _userReportedNuCardCount;

        [Persistent]
        public int UserReportedNuCardCount
        {
            get { return _userReportedNuCardCount; }
            set { SetPropertyValue("UserReportedNuCardCount", ref _userReportedNuCardCount, value); }
        }
        private string _comment;

        [Persistent]
        public string Comment
        {
            get { return _comment; }
            set { SetPropertyValue("Comment", ref _comment, value); }
        }

        private int _statusId;

        [Persistent]
        public int StatusId
        {
            get { return _statusId; }
            set { _statusId = value; }
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

        private int _approvedBy;

        [Persistent]
        public int ApprovedBy
        {
            get { return _approvedBy; }
            set { _approvedBy = value; }
        }

        private DateTime? _approvedDate;

        [Persistent]
        public DateTime? ApprovedDate
        {
            get { return _approvedDate; }
            set { SetPropertyValue("ApprovedDate", ref _approvedDate, value); }
        }

        public BranchCashReport() : base() { }
        public BranchCashReport(Session session) : base(session) { }
    }
}
