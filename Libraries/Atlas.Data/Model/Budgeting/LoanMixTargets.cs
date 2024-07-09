using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Budgeting
{
    public class LoanMixTargets : XPLiteObject
    {

        private long _LoanMixTargetId;
        [Key(AutoGenerate = true)]
        [Persistent]
        public long LoanMixTargetId
        {
            get
            {
                return _LoanMixTargetId;
            }
            set
            {
                _LoanMixTargetId = value;
            }
        }
        private int _BudgetingId;
        [Persistent]
        public int BudgetingId
        {
            get
            {
                return _BudgetingId;
            }
            set
            {
                _BudgetingId = value;
            }
        }
        private int _LoanTerm;
        [Persistent]
        public int LoanTerm
        {
            get
            {
                return _LoanTerm;
            }
            set
            {
                _LoanTerm = value;
            }
        }
        private DateTime _TargetDate;
        [Persistent]
        public DateTime TargetDate
        {
            get
            {
                return _TargetDate;
            }
            set
            {
                _TargetDate = value;
            }
        }
        private decimal _TargetPercentage;
        [Persistent]
        public decimal TargetPercentage
        {
            get
            {
                return _TargetPercentage;
            }
            set
            {
                _TargetPercentage = value;
            }
        }

        public LoanMixTargets() : base() { }
        public LoanMixTargets(Session session) : base(session) { }
    }
}
