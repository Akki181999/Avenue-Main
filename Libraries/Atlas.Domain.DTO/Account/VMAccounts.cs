using Atlas.Domain.DTO;
using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atlas.Domain.DTO.Account
{
    public class VMAccounts
    {
        public string Type { get; set; }
        public long AccountId { get; set; }
        public string AccountNo { get; set; }
        public long PersonId { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal InstalmentAmount { get; set; }
        public string AccountStatus { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string DetailsUrl { get; set; }
        public string ActionsUrl { get; set; }
        public long? BranchId { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
    }

    public class VMAccountActions
    {
        public long? AccountId { get; set; }
        public List<BOS_ActionDTO> Actions { get; set; }
    }

    public class VMOverdueAccounts 
    {
        public string Type { get; set; }
        public long AccountId { get; set; } 
        public string ClientName { get; set; }
        public string DetailsUrl { get; set; }
        public string ActionsUrl { get; set; }       
        public DateTime? DueDate { get; set; }
        public decimal OverdueAmount { get; set; }
        public decimal Balance { get; set; }
        public string Term { get; set; }
        public string OverdueType { get; set; }
        public string Flagged { get; set; }
        public long? BranchId { get; set; }
    }

    public class VMHandoverAccounts
    {
        public string Type { get; set; }
        public long AccountId { get; set; }
        public string ClientName { get; set; }
        public string DetailsUrl { get; set; }
        public string ActionsUrl { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? HandoverDate { get; set; }
        public decimal Balance { get; set; }
        public string Term { get; set; }
        public long? BranchId { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
    public class VMBalanceTransferAccounts
    {
        public long BalanceTransferId { get; set; }
       
        public long FromAccountId { get; set; }
        public long ToAccountId { get; set; }
        public decimal BalanceTransferAmount { get; set; }
        public long RepaymentId { get; set; }
        public long RefundId { get; set; }
        public string Status { get; set; }
        public int BranchId { get; set; }
        public int CreditBranchid { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ProcessedDate { get; set; }     
      
        public string ProcessedBy { get; set; }
        public long CompanyId { get; set; }
        public string CompanyName { get; set; }

    }

    //Add and Resubmit Instalment start
    public class VMAccountDetailsForAddInstallment
    {
        public string Type { get; set; }
        public long AccountId { get; set; }
        public string AccountStatus { get; set; }
        public int? Failed_Installment_SrNo { get; set; }
        public int? Last_Installment_SrNo { get; set; }
        public decimal Totalinstallment { get; set; }
        public decimal Paid_Installment { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime? Duedate { get; set; }
        public decimal LoanAmount { get; set; }
        public long? BranchId { get; set; }
    }

    public class VMAllScheduleDetails
    {
        public string Type { get; set; }
        public long AccountId { get; set; }
        public string AccountStatus { get; set; }
        public int? Failed_Installment_SrNo { get; set; }
        public int? Last_Installment_SrNo { get; set; }
        public int? Upcoming_Installment_SrNo { get; set; }
        public decimal Totalinstallment { get; set; }
        public decimal Paid_Installment { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime? Duedate { get; set; }
        public DateTime? Upcoming_Duedate { get; set; }
        public decimal LoanAmount { get; set; }
        public long? BranchId { get; set; }
    }

    //Add and Resubmit Instalment end

    //Future VAP Cancel

    public class VMVAPCancelActions
    {
        public long AccountId { get; set; }
        public int VapCancelId { get; set; }
        public int VapCancelStatus { get; set; }
    }
    public class VMFutureVAPCancelDetails
    {
        public long AccountId { get; set; }
        public string Frequency { get; set; }
        public decimal CurrentAccountBalance { get; set; }
        public long TotalNumOfVAPCount { get; set; }
        public int WorkFlowCode { get; set; }

        public long PreviousDueDatePaidVAPCount { get; set; }
        public long PreviousDueDateUnPaidVAPCount { get; set; }
        public long CoolingPeriodVAPCount { get; set; }
        public long FutureCancelVAPCount { get; set; }

        public decimal FutureCancelVAPAmount { get; set; }
        public decimal FutureCancelPaidVAPAmount { get; set; }
        public decimal OutstandingBalance { get; set; }

        public DateTime? UpcomingDueDate { get; set; }
        public long UpcomingDueDateCount { get; set; }
        public int FutureOrAll { get; set; }

        public List<BOS_ActionDTO> Actions { get; set; }
        public int VapCancelStatus { get; set; }

        public int NewTerm { get; set; }
        public decimal NewInstallmentAmount { get; set; }
    }

    public class VMAllVAPCancelDetails
    {
        public long AccountId { get; set; }
        public string Frequency { get; set; }

        public decimal CurrentAccountBalance { get; set; }
        public long TotalNumOfVAPCount { get; set; }
        public long CancelVAPCount { get; set; }
        public int WorkFlowCode { get; set; }

        public long PaidVAPCount { get; set; }
        public long UnPaidVAPCount { get; set; }

        public decimal AllCancelVAPAmount { get; set; }
        public decimal PaidCancelVAPAmount { get; set; }

        public decimal OutstandingBalance { get; set; }
        public DateTime? UpcomingDueDate { get; set; } 

        public long UpcomingDueDateCount { get; set; }
        public int FutureOrAll { get; set; }

        public List<BOS_ActionDTO> Actions { get; set; }
        public int VapCancelStatus { get; set; }

        public int NewTerm { get; set; }
        public decimal NewInstallmentAmount { get; set; }
    }

    public class VMNewtermAndNewInstallmentAmount
    {
        public decimal OutstandingBalance { get; set; }
        public int NewTerm { get; set; }
        public decimal NewInstallmentAmount { get; set; }
    }

    public class VMVapCancelJobDetails
    {
        public long AccountId { get; set; }
    }

    //Future VAP Cancel

}