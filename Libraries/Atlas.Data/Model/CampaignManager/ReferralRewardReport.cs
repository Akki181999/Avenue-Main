using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CampaignManager
{
    public class ReferralRewardReport : XPLiteObject
    {
        #region Constructors
        public ReferralRewardReport() : base() { }
        public ReferralRewardReport(Session session) : base(session) { }
		#endregion

		[Key(AutoGenerate = true)]
		public long ReferralRewardReportId { get; set; }
		[Persistent]
		public long ReferralRewardReportBatchId { get; set; }
		[Persistent]
		public long ApplicationId { get; set; }
		[Persistent]
		public long DisbursementModeId { get; set; }
		[Persistent]
		public long DebitOrderModeId { get; set; }
		[Persistent]
		public string NuCardVoucherNumber { get; set; }
		[Persistent]
		public decimal? ReferralAmount { get; set; }
		[Persistent]
		public long AccountId { get; set; }
		[Persistent]
		public bool IsProcessed { get; set; }
		[Persistent]
		public string ErrorMessage { get; set; }
		[Persistent]
		public string Status { get; set; }
		[Persistent]
		public DateTime CreatedDate { get; set; }
		[Persistent]
		public DateTime? UpdatedDate { get; set; }

	}
}
