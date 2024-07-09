using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
    public class AutomateRefundReasonMaster : XPLiteObject
    {
        [Key]
        [Persistent]
        public long Id { get; set; }
        [Persistent]
        public string AutomateRefundReason { get; set; }
        [Persistent]
        public bool IsActive { get; set; }

        #region Constructors

        public AutomateRefundReasonMaster() : base() { }
        public AutomateRefundReasonMaster(Session session) : base(session) { }

        #endregion
    }
}