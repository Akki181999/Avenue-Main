using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.LGR_Refund
{
   public class LGR_Refund_Master : XPLiteObject
    {
        [Key]
        [Persistent]
        public long RefundId { get; set; }
        [Persistent]
        public Int32 AccountId { get; set; }
        [Persistent]
        public Int32 RepaymentId { get; set; }
        [Persistent]
        public DateTime CreateDate { get; set; }
        [Persistent]
        public Int32 PersonId { get; set; }
        [Persistent]
        public Int32 CreatedBy { get; set; }
        [Persistent]
        public decimal RefundAmount { get; set; }
        [Persistent]
        public string RefundMethod { get; set; }
        [Persistent]
        public Int32 ProcessStatus { get; set; }
        [Persistent]
        public decimal NetPaymentAmount { get; set; }
        [Persistent]
        public string RefundReason { get; set; }

        #region Constructors

        public LGR_Refund_Master() : base() { }
        public LGR_Refund_Master(Session session) : base(session) { }

        #endregion

    }
}
