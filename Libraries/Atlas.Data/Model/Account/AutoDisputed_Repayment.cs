using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public sealed class AutoDisputed_Repayment : XPLiteObject
    {
        [Persistent("AccountId")]
        public int AccountId { get; set; }

        [Key(AutoGenerate = false)]
        [Persistent("RepaymentId")]
        public int RepaymentId { get; set; }

        [Persistent("TransactionId")]
        public int TransactionId { get; set; }

        [Persistent("NumInstallments")]
        public string NumInstallments { get; set; }

        public AutoDisputed_Repayment() : base() { }
        public AutoDisputed_Repayment(Session session) : base(session) { }
    }
}
