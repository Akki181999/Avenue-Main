using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{

    public class InBranchNotificationRequestPayload
    {
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public int NotificationEventId { get; set; }
        public string IDNumber { get; set; }
    }

    public class InBranchNotificationResponse
    {
        public Templates templates { get; set; }
        public long CampaignId { get; set; }
        public List<Placeholders> placeholder { get; set; }
    }
   
    public class Templates
    {
        public string CampaignSMS { get; set; }
        public string CampaignEmail { get; set; }
        public string RewardSMS { get; set; }
        public string RewardEmail { get; set; }
    }

    public class Placeholders
    {
        public string PlaceholderName { get; set; }
        public bool IsCalculatedValue { get; set; }
        public string Value { get; set; }
    }

    public class VMReferAndEarn
    {
        public Int64 ApplicationId { get; set; }

        public Int64 ApplicationClientId { get; set; }

        public string Client_IDNumber { get; set; }

        public string Customer_Name { get; set; }

        public string CampaignCode { get; set; }

        public string Referral_Code { get; set; }

        public string Referral_Name { get; set; }

        public string Referral_IDNumber { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime Application_CreatedDate { get; set; }

        public decimal LoanAmount { get; set; }

        public decimal RewardAmount { get; set; }

        public string AgentCode { get; set; }

        public string Agent_Name { get; set; }

        public List<BOS_ActionDTO> Actions { get; set; }
    }
}

