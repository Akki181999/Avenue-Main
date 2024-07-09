using Atlas.Domain.DTO.CashManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    public class RepaymentDTO
    {
        public long RepaymentId { get; set; }
        public long AccountId { get; set; }
        public int? CustomerID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentOutstanding { get; set; }
        public string TransactionId { get; set; }
        public int InstallmentNo { get; set; }
        public Decimal Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public string Reason { get; set; }
        public string ExtRefNo { get; set; }
        public Authentication.Auth_UserDTO CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Authentication.Auth_UserDTO ProcessedBy { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string Status { get; set; }
        public decimal UtilizedAmount { set; get; }
        public decimal RefundAmount { set; get; }
        public String Action { set; get; }
        public decimal InstallmentAmount { get; set; }

        public string PaymentCode { get; set; }

        public string Description { get; set; }
        public string TerminalId { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public DateTime? RepaymentDate { get; set; }
        public bool IsEarlySettle { get; set; }
        public int PaidInstallmentNo { get; set; }
        public int? InstallmentSrNo { get; set; } = 0;
        public BankAccountDTO RegionAccount { get; set; }
        public int NumOfInstalments { get; set; }
        public Int64? BranchId { get; set; }

    }
    public class DisputedRepaymentDTO
    {
        public Int64 DisputedRepaymentId { get; set; }
        public Int64 AccountId{ get; set; }
        public string TransactionId { get; set; }
        public string ServiceType{ get; set; }
        public Int32 InstallmentNo { get; set; }
        public RepaymentDTO Repayment { get; set; }
        public Int64 RefundId{ get; set; }
        public Decimal DisputedAmount{ get; set; }
        public int StatusId{ get; set; }
        public Int32 CreatedBy{ get; set; }
        public DateTime CreatedOn{ get; set; }
        public Boolean IsManual{ get; set; }
        public DateTime? ProcessedOn { get; set; }
       
        public Int32 ProcessedBy{ get; set; }

    }
    public class ACC_BalanceTransferDTO
    {
        public Int64 BalanceTransferId { get; set; }
        public Int64 FromAccountId { get; set; }
        public Int64 ToAccountId { get; set; }
        public Int64 RepaymentId { get; set; }
        public Int64 RefundId { get; set; }
        public int PaymentModeId { get; set; }
        public Decimal BalanceTransferAmount { get; set; }
        public int StatusId { get; set; }
       // public Int32 CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ProcessedOn { get; set; }
        //public Int32 ProcessedBy { get; set; }

        public PER_PersonDTO CreatedBy { get; set; }

        public PER_PersonDTO ProcessedBy { get; set; }
        public ACC_AccountDTO FromAccountdetail { get; set; }

    }
}
