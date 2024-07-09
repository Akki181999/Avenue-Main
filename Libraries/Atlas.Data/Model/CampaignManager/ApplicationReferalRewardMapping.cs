using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CampaignManager
{
    public class ApplicationReferalRewardMapping : XPLiteObject
    {
        #region Constructors
        public ApplicationReferalRewardMapping() : base() { }
        public ApplicationReferalRewardMapping(Session session) : base(session) { }
        #endregion

        [Key(AutoGenerate = true)]
        public Int64 ApplicationReferalRewardMappingId { get; set; }
        
        [Persistent]
        public Int64 ApplicationId { get; set; }

        [Persistent]
        public string NationalId { get; set; }

        [Persistent]
        public Int64 CampaignId { get; set; }

        [Persistent]
        public string ReferralCode { get; set; }

        [Persistent]
        public decimal RewardAmount { get; set; }

        [Persistent]
        public Int64 CreatedBy { get; set; }

        [Persistent]
        public DateTime CreatedDate { get; set; }

        [Persistent]
        public Int64? UpdateBy { get; set; }

        [Persistent]
        public DateTime? UpdatedDate { get; set; }

        [Persistent]
        public bool? IsAmountInPerc { get; set; }

        [Persistent]
        public decimal CalculatedRewardAmount { get; set; }

        [Persistent]
        public Boolean IsRewardLoaded { get; set; }
    }
}
