using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class CheckCampaignEligibilityRequestPayload
    {
        public string CampaignCode { get; set; }
        public string ReferralCode { get; set; }
        public long BranchId { get; set; }
        public long EvolutionProductId { get; set; }
        public string NationalId { get; set; }
        public long? ChannelId { get; set; }
        public DateTime Date { get; set; }
        public string CampaignMethod { get; set; }
        public decimal LoanAmount { get; set; }
    }
}
