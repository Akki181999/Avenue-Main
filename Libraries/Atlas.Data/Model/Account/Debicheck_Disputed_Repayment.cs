using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public sealed class Debicheck_Disputed_Repayment : XPLiteObject
    {
        [Persistent("AccountId")]
        public int AccountId { get; set; }

        [Key(AutoGenerate = false)]
        [Persistent("RepaymentId")]
        public int RepaymentId { get; set; }

        [Persistent("RequestTransactionId")]
        public string RequestTransactionId { get; set; }

        [Persistent("InstalmentNum")]
        public int InstalmentNum { get; set; }

        [Persistent("DisputedDate")]
        public DateTime DisputedDate { get; set; }

        public Debicheck_Disputed_Repayment() : base() { }
        public Debicheck_Disputed_Repayment(Session session) : base(session) { }
    }
}
