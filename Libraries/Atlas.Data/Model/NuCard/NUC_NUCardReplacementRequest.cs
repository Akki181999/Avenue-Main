using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.NuCard
{
  public  class NUC_NUCardReplacementRequest: XPLiteObject
    {
        [Key(AutoGenerate = true)]
        [Persistent]
        public int CardReplaceId { get; set; }
        [Persistent]
        public long ClientId { get; set; }
        [Persistent]
        public string NationalId { get; set; }
        [Persistent]
        public string OldVoucherNumber { get; set; }
        [Persistent]
        public string NewVoucherNumber { get; set; }
        [Persistent]
        public int DebitOrderModeId { get; set; }
        [Persistent]
        public decimal CardFees { get; set; }
        [Persistent]
        public string CellNumber { get; set; }
        [Persistent]
        public string TerminalId { get; set; }
        [Persistent]
        public int StatusId { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public long Createdby { get; set; }
        [Persistent]
        public DateTime ChangeStatusdate { get; set; }
        [Persistent]
        public long Changeby { get; set; }
        [Persistent]
        public int ReasonId { get; set; }
        [Persistent]
        public string Status { get; set; }
        public long BranchId { get; set; }
        public NUC_NUCardReplacementRequest() : base() { }
        public NUC_NUCardReplacementRequest(Session session) : base(session) { }

    }
}
