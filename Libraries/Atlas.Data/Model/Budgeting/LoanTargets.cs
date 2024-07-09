using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Budgeting
{
    public class LoanTargets : XPLiteObject
    {
        private long _LoanTargetId;
        [Key(AutoGenerate = true)]
        [Persistent]
        public long LoanTargetId
        {
            get
            {
                return _LoanTargetId;
            }
            set
            {
                _LoanTargetId = value;
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

        private int _BranchId;
        [Persistent]
        public int BranchId
        {
            get
            {
                return _BranchId;
            }
            set
            {
                _BranchId = value;
            }
        }
        private DateTime _TargetMonth;
        [Persistent]
        public DateTime TargetMonth
        {
            get
            {
                return _TargetMonth;
            }
            set
            {
                _TargetMonth = value;
            }
        }
        private decimal _TargetAmount;
        [Persistent]
        public decimal TargetAmount
        {
            get
            {
                return _TargetAmount;
            }
            set
            {
                _TargetAmount = value;
            }
        }        
        private decimal _TargetNew;
        [Persistent]
        public decimal TargetNew
        {
            get
            {
                return _TargetNew;
            }
            set
            {
                _TargetNew = value;
            }
        }
        private decimal _TargetRevived;
        [Persistent]
        public decimal TargetRevived
        {
            get
            {
                return _TargetRevived;
            }
            set
            {
                _TargetRevived = value;
            }
        }
        private decimal _TargetExisting;
        [Persistent]
        public decimal TargetExisting
        {
            get
            {
                return _TargetExisting;
            }
            set
            {
                _TargetExisting = value;
            }
        }
        private decimal _TargetTotalLoans;
        [Persistent]
        public decimal TargetTotalLoans
        {
            get
            {
                return _TargetTotalLoans;
            }
            set
            {
                _TargetTotalLoans = value;
            }
        }
        #region Constructors

        public LoanTargets() : base() { }
        public LoanTargets(Session session) : base(session) { }

        #endregion
    }
}
