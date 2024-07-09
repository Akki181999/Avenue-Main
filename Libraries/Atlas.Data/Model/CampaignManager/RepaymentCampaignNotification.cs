using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CampaignManager
{
   public class RepaymentCampaignNotification:XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 RepaymentCampaignNotificationId { get; set; }
        [Persistent]
        public Int64 RepaymentId { get; set; }
        [Persistent]
        public Int64 AccountId { get; set; }
        [Persistent]
        public decimal RepaymentAmount { get; set; }
        [Persistent]
        public bool IsProcessed { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public int CreatedBy { get; set; }
        [Persistent]
        public DateTime? UpdatedDate { get; set; }

        #region Constructors
        public RepaymentCampaignNotification() : base() { }
        public RepaymentCampaignNotification(Session session) : base(session) { }
        #endregion
    }
}
