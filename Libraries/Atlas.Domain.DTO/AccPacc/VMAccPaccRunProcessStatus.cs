using System;

namespace Atlas.Domain.DTO.AccPacc
{
    public class VMAccPaccRunProcessStatus
    {
        public string AccpaccEntity { get; set; }
        public string BatchId { get; set; }
        public string BranchName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? RunDate { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string DetailsUrl { get; set; }
        public string ExportUrl { get; set; }
    }


    public class VMApTransactions
    {
        public string BatchId { get; set; }
        public string BatchEntry { get; set; }
        public string AccpacEntity { get; set; }
        public string TransactionMonth { get; set; }
        public string TransactionGroupDesc { get; set; }
        public string TransactionTypeDesc { get; set; }
        public string AccpacAccount { get; set; }
        public string BranchIdAlms { get; set; }
        public string LoanTypeDesc { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string AccountNo { get; set; }
        public decimal AmountSigned { get; set; }
        public string OffsetAccpacAccount { get; set; }
        public string Description { get; set; }
        public string PaymentMode { get; set; }
    }
}
