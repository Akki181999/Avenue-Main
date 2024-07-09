using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Account
{
    public class EarlySettlementOfferDTO
    {
        public Int64 EarlySettlementOfferId { get; set; }
        public Int64 AccountId { get; set; }
        public DateTime OfferDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public Int64 RepaymentId { get; set; }
        public Decimal VAPPayableAmount { get; set; }
        public Decimal LoanPayableAmount { get; set; }
        public Decimal TotalPayableAmount { get; set; }
    }

    public class EarlySettlementOfferDetailsDTO
    {
        public Int64 EarlySettlementOfferDetailsId { get; set; }
        public String Description { get; set; }
        public Int64 EarlySettlementOfferId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Int64 DurationInDays { get; set; }
        public Int64 NoOfInstalments { get; set; }
        public Decimal Repay { get; set; }
        public Decimal Capital { get; set; }
        public Decimal Interest { get; set; }
        public Decimal InitFee { get; set; }
        public Decimal ServFee { get; set; }
        public Decimal Premium { get; set; }
        public Decimal VAT { get; set; }
        public Decimal VAPAmount { get; set; }
    }
}
