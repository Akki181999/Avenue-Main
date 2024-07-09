using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.AutoLoan
{
    public sealed class VW_AutoLoanTransaction : XPLiteObject
    {
        [Key(AutoGenerate = false)]
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
        #region Constructor
        public VW_AutoLoanTransaction() : base() { }
        public VW_AutoLoanTransaction(Session session) : base(session) { }
        #endregion

    }
}
