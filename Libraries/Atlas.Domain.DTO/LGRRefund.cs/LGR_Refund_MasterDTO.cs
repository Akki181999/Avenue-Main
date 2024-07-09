using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.LGRRefund.cs
{
    public class LGR_Refund_MasterDTO
    {
        public long RefundId { get; set; }
        public Int32 AccountId { get; set; }
        public Int32 RepaymentId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 PersonId { get; set; }
        public Int32 CreatedBy { get; set; }
        public decimal RefundAmount { get; set; }
        public string RefundMethod { get; set; }
        public Int32 ProcessStatus { get; set; }
        public decimal NetPaymentAmount { get; set; }
        public string RefundReason { get; set; }
    }
}
