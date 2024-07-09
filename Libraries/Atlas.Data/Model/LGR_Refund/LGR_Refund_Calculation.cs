using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.LGR_Refund
{
    public class LGR_Refund_Calculation 
    {
        
        public long TransactionId { get; set; }
       
        public Int32 AccountId { get; set; }

        public Int32 PersonId { get; set; }
        public Int32 TransactionTypeId { get; set; }
        public string TransactionTypeDesc { get; set; }
        public Int32 TypeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 PaymentModeId { get; set; }
        public Int32 ACC_ScheduleId { get; set; }
        public Boolean IsfinancialTransaction { get; set; }
        public Int32 LGR_TransTypeGroupId { get; set; }
        public string GroupDesc { get; set; }
        public Int32 PriorityId { get; set; }
        public Int32 RepaymentId { get; set; }
        public Int32 RefundId { get; set; }
        public string TransactionCategory { get; set; }
        public decimal TranAmount { get; set; }
        public decimal PaymentTotal { get; set; }
        public decimal PaymentOffsetTotal { get; set; }
        public decimal NetPaymentTotal { get; set; }
        public Boolean AllowRefund { get; set; }
        public decimal RefundAllocation { get; set; }
        public Int32 RefundPriorityId { get; set; }
        public Int32 RefundProcessesStatus { get; set; }
        public Int32 RefundPaymentModeId { get; set; }
        public bool bitIsManual { get; set; }
    }
}
