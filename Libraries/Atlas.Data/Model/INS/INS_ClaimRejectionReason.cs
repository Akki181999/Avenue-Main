using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_ClaimRejectionReason: XPLiteObject
    {
        [Key]
        [Persistent]
        public int RejectReasonId { get; set; }
        [Persistent]
        public string RejectCode { get; set; }
        [Persistent]
        public string Description { get; set; }

        #region Constructors

        public INS_ClaimRejectionReason() : base() { }
        public INS_ClaimRejectionReason(Session session) : base(session) { }

        #endregion
    }
}
