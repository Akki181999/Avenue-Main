using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class DebitOrderCancellationTarcking : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public long TrackingId { get; set; }
        [Persistent]
        public long ApplicationId { get; set; }
        [Persistent]
        public long AccountId { get; set; }
        [Persistent]
        public long DebitOrderId { get; set; }
        [Persistent]
        public int DebitOrderModeId { get; set; }
        [Persistent]
        public string ServiceType { get; set; }
        [Persistent]
        public string TransactionId { get; set; }
        [Persistent]
        public string Response { get; set; }
        [Persistent]
        public string ErrorMessage { get; set; }
        [Persistent]
        public DateTime CreateDate { get; set; }
        [Persistent]
        public DateTime? ProcessingDate { get; set; }
        [Persistent]
        public bool IsProcessed { get; set; }
        [Persistent]
        public string ProcessStatus { get; set; }

        #region Constructors

        public DebitOrderCancellationTarcking() : base() { }
        public DebitOrderCancellationTarcking(Session session) : base(session) { }

        #endregion
    }
}
