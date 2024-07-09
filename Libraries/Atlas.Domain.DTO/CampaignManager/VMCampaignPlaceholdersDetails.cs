using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class VMCampaignPlaceholdersDetails
    {
            public decimal LoanAmount { get; set; }
            public decimal DisburseAmount { get; set; }
            public int BranchId { get; set; }
            public int DisbursementId { get; set; }
            public string NuCardNumber { get; set; }
            public int DisbursementModeId { get; set; }
            public int ProductId { get; set; }
            public int CompanyId { get; set; }
            public int BankId { get; set; }
            public int ClientId { get; set; }
            public int AccountId { get; set; }
            public string IDNumber { get; set; }
            public string CellNo { get; set; }
            public int DebitOrderModeId { get; set; }
            public decimal TotalInstallment { get; set; }
            public DateTime? FirstRepayDate { get; set; }
            public decimal RewardAmount { get; set; }
            public string CustomerFirstname { get; set; }
            public string CustomerLastName { get; set; }
            public string CustomerEmail { get; set; }
            public long ApplicationId { get; set; }
            public DateTime? DueDate { get; set; }
            public DateTime LoanOpenDate { get; set; }
            public string AccountNo { get; set; }

        //Referrer
        public string ReferralCode { get; set; }
        public string ReferrerCellNo { get; set; }
        public int ReferrerLatestApplicationId { get; set; }

    }
}