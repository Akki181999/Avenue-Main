using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO
{
    public class LoanRepayment
    {
        public long id { get; set; }
        public decimal RepaymentAmount { get; set; }
        public bool IsManual { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public long CollectionId { get; set; }
        public long CollectionTypeId { get; set; }
        public string ExtRefNo { get; set; }
        public string Description { get; set; }
        public string TerminalId { get; set; }
        public string  PaymentCode { get; set; }
        public DateTime ValueDate { get; set; }
        public bool IsEarlySettlement { get; set; }
        public DateTime enddate { get; set; }
        public decimal DiscountedAmount { get; set; }
        public decimal VapPayableAmount { get; set; }
        public Int32 InstallmentNo { get; set; }
        public Int32 RegionAccount { get; set; }
        public Int32 CancelPaymentMode { get; set; }
        public Decimal IDLPAmount { get; set; }
        public Decimal AdditionalServiceFeeAmount { get; set; }
        public bool IsIDLPAcknowledged { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        // add property BranchId
        public Int64? BranchId { get; set; }
        public string TransactionId { get; set; }

    }

    public class LoanRepaymentList
    {
        public long RepaymentId { get; set; }
        public long AccountId { get; set; }
        public string AccountNo { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public decimal RepaymentAmount { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public string Status { get; set; }      
        public string IsManual { get; set; }
        public string CollectionType { get; set; }
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
    }

    public class LoanRepaymentReversal
    {
        public long id { get; set; }
        public decimal ReversalAmount { get; set; }
        public DateTime? RepaymentDate { get; set; }  
    }
    public class LoanRefundAmount
    {
        public string BankRefCode { get; set; }
        public string ReasonCode { get; set; }
        public int RepaymentId { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTime? RefundDate { get; set; }
        public DateTime? ReverseDate { get; set; }
    }
    public class LoanDisputedRepaymentList
    {

        public long DisputedRepaymentId { get; set; }
        public long RepaymentId { get; set; }
        public long AccountId { get; set; }
        public string AccountNo { get; set; }
        public long RefundId { get; set; }         
        public decimal DisputedAmount { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Status { get; set; }
        public string IsManual { get; set; }
        public string CollectionType { get; set; }
    }
}
