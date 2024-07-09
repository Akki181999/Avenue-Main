using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class VMCampaignManager
    {
        public CampaignRewardDetails SelectedCampaign { get; set; }
        public CheckCampaignEligibilityRequestPayload EligibleCampaignDetails { get; set; }
    }
}
