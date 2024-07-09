using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CampaignManager
{
    public class ReferralRewardReportBatch : XPLiteObject
    {
        #region Constructors
        public ReferralRewardReportBatch() : base() { }
        public ReferralRewardReportBatch(Session session) : base(session) { }
        #endregion

        [Key(AutoGenerate = true)]
        public long ReferralRewardReportBatchId { get; set; }
        [Persistent]
        public bool IsProcessed { get; set; }
        [Persistent]
        public DateTime? StartTime { get; set; }
        [Persistent]
        public DateTime? EndTime { get; set; }
        [Persistent]
        public string ErrorMessage { get; set; }
        [Persistent]
        public string Status { get; set; }
        [Persistent]
        public DateTime ReportGenerationDate { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
    }
}
