using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
    public class BranchCashDenomination : XPLiteObject
    {
        private long _branchCashDenomination;

        [Key(AutoGenerate = true)]
        [Persistent]
        public long BranchCashDenominationId
        {
            get { return _branchCashDenomination; }
            set { _branchCashDenomination = value; }
        }

        private long _BranchCashReportId;
        [Persistent]
        public long BranchCashReportId
        {
            get { return _BranchCashReportId; }
            set { _BranchCashReportId = value; }
        }

        private decimal _DenominationValue;
        [Persistent]
        public decimal DenominationValue
        {
            get { return _DenominationValue; }
            set { SetPropertyValue("DenominationValue", ref _DenominationValue, value); }
        }

        private int _Count;
        [Persistent]
        public int Count
        {
            get { return _Count; }
            set { SetPropertyValue("Count", ref _Count, value); }
        }

        public BranchCashDenomination() : base() { }
        public BranchCashDenomination(Session session) : base(session) { }
    }
}