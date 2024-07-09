using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public class INS_ProcessReason : XPLiteObject
    {
        [Key]
        [Persistent]
        public int ProcessReasonId { get; set; }

        [Persistent]
        public string Description { get; set; }

        #region Constructors

        public INS_ProcessReason() : base() { }
        public INS_ProcessReason(Session session) : base(session) { }

        #endregion
    }
}
