using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Budgeting
{
    public class DailyPhasingTargets : XPLiteObject
    {

        private long _DailyPhasingTargetId;
        [Key(AutoGenerate = true)]
        [Persistent]
        public long DailyPhasingTargetId
        {
            get
            {
                return _DailyPhasingTargetId;
            }
            set
            {
                _DailyPhasingTargetId = value;
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

        public DailyPhasingTargets() : base() { }
        public DailyPhasingTargets(Session session) : base(session) { }
    }
}
