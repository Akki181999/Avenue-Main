using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CampaignManager
{
    public class ReferralRewardReportDTO
    {
		public long ReferralRewardReportId { get; set; }
		public long ReferralRewardReportBatchId { get; set; }
		public long ApplicationId { get; set; }
		public long DisbursementModeId { get; set; }
		public long DebitOrderModeId { get; set; }
		public string NuCardVoucherNumber { get; set; }
		public decimal? ReferralAmount { get; set; }
		public long AccountId { get; set; }
		public bool IsProcessed { get; set; }
		public string ErrorMessage { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}
