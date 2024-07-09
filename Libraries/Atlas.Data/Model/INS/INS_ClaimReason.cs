using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_ClaimReason:XPLiteObject
    {
        [Key]
        [Persistent]
        public Int64 ClaimReasonId { get; set; }

        [Persistent]
        public char ClaimCode { get; set; }

        [Persistent]
        public string Description { get; set; }

        [Persistent]
        public string Category { get; set; }

        [Persistent]
        public string WaitingPeriod { get; set; }

        #region Constructors

        public INS_ClaimReason() : base() { }
        public INS_ClaimReason(Session session) : base(session) { }

        #endregion
    }
}
