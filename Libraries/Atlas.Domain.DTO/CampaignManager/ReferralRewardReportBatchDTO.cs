using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class ReferralRewardReportBatchDTO
    {
        public long ReferralRewardReportBatchId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ErrorMessage { get; set; }
        public string Status { get; set; }
        public DateTime ReportGenerationDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
