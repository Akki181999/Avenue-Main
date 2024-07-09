using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class CampaignRewardDetails
    {
        public long CampaignId { get; set; }
        public string CampaignCode { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDescription { get; set; }
        public string EvolutionEventName { get; set; }
        public bool IsCampaignEnable { get; set; }
        public long? InstantRewardId { get; set; }
        public string RewardName { get; set; }
        public string RewardDescription { get; set; }
        public decimal? Amount { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public long DistributionListId { get; set; }
        public decimal? MinLoanAmount { get; set; }
        public long PayoutModeId { get; set; }
        public string PayoutMode { get; set; }
        public string RewardType { get; set; }
        public long? ThirdPartyVoucherId { get; set; }
        public bool? IsAmountInPerc { get; set; }
        public string CampaignSMS { get; set; }
        public string CampaignEmail { get; set; }
        public string RewardSMS { get; set; }
        public string RewardEmail { get; set; }
        public List<Placeholders> placeholders { get; set; }
    }
}
