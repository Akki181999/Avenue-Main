using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class CustomerReferralRewardEarningsDTO
    {
        public long ClientId { get; set; }
        public string IDNumber { get; set; }
        public long ApplicationId { get; set; }
        public long AccountId { get; set; }
        public DateTime DisbursementDate { get; set; }
        public decimal DisbursementAmt { get; set; }
        public decimal RewardAmount { get; set; }
    }
}
