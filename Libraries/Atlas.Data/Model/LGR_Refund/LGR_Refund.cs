using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.LGR_Refund
{
     public class LGR_Refund : XPLiteObject
    {
        [Key]
        [Persistent]
        public Int64 RefundId { get; set; }
        [Persistent]
        public Int64 AccountId { get; set; }
        [Persistent]
        public DateTime CreateDate { get; set; }
        [Persistent]
        public decimal RefundAmount { get; set; }
        [Persistent]
        public bool BitIsManual { get; set; }
        [Persistent]
        public Int64? PaymentModeId { get; set; }
        [Persistent]
        public DateTime? UpdatedDate { get; set; }
        [Persistent]
        public Int64 StatusId { get; set; }
        [Persistent]
        public Int64? PersonId { get; set; }
        [Persistent]
        public string RefundReason { get; set; }
        [Persistent]
        public bool IsAutomateRefund { get; set; }


        #region Constructors

        public LGR_Refund() : base() { }
        public LGR_Refund(Session session) : base(session) { }

        #endregion
    }
}
