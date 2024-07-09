using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Account
{
   public class ACC_DebitOrderRequest :XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public long DebitOrderRequestId { get; set; }
        [Persistent]
        public long AccountId { get; set; }
        [Persistent]
        public long ApplicationId { get; set; }
        [Persistent]
        public string responseCode { get; set; }
        [Persistent]
        public string ContractNumber { get; set; }
        [Persistent]
        public DateTime RequestDatetime { get; set; }
        [Persistent]
        public decimal ContractAmount { get; set; }
        public bool IsActive { get; set; }
        [Persistent]
        public int DebitOrderModeId { get; set; }
        [Persistent]
        public string Status { get; set; }

        [Persistent]
        public long Createdby { get; set; }
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public string ClientIdNum { get; set; }
        [Persistent]
        public string MerchantId { get; set; }
        [Persistent]
        public string DebitOrderType { get; set; }
        #region Constructors

        public ACC_DebitOrderRequest() : base() { }
        public ACC_DebitOrderRequest(Session session) : base(session) { }

        #endregion
    }
}
