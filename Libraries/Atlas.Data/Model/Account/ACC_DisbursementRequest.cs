using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Account
{
   public class ACC_DisbursementRequest: XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public long DiburseRequestId { get; set; }
        [Persistent]
        public long AccountId { get; set; }
        [Persistent]
        public long ApplicationId { get; set; }
        [Persistent]
        public string responseCode { get; set; }
        [Persistent]
        public decimal DisburseAmount { get; set; }
        [Persistent]
        public DateTime RequestDatetime { get; set; }
        [Persistent]
        public bool IsActive { get; set; }
        [Persistent]
        public int DisbursementModeId { get; set; }
        [Persistent]
        public string Status { get; set; }

        [Persistent]
        public long Createdby { get; set; }

        [Persistent]
        public DateTime CreatedDate { get; set; }

        [Persistent]
        public string  ClientIdNum { get; set; }

        [Persistent]
        public string VoucherNumber { get; set; }

        [Persistent]
        public string RequestType { get; set; }

        [Persistent]
        public Int32 RefundId { get; set; }

        #region Constructors

        public ACC_DisbursementRequest() : base() { }
        public ACC_DisbursementRequest(Session session) : base(session) { }

        #endregion
    }
}
