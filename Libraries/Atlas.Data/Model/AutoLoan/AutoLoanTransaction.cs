using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.AutoLoan
{
    public class AutoLoanTransaction: XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 TransactionId { get; set; }
        [Persistent]
        public Int64 ApplicationId { get; set; }
        [Persistent]
        public Int64 AccountId { get; set; }
        [Persistent]
        public Int64 ParentFlashLoanAccountId { get; set; }
        [Persistent]
        public Int64 BranchId { get; set; }
        [Persistent]
        public Int16 DisbursementModeId { get; set; }
        [Persistent]
        public Int16 DebitOrderModeId { get; set; }
        [Persistent]
        public Decimal Amount { get; set; }
        [Persistent]
        public string Status { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public DateTime? UpdatedDate { get; set; }
        [Persistent]
        public string Remark { get; set; }

        #region Constructor
        public AutoLoanTransaction() : base() { }
        public AutoLoanTransaction(Session session) : base(session) { }
        #endregion
    }
}
