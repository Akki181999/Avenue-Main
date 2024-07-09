using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.PRD_Products
{
    public class PRD_Products:XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 ProductId { get; set; }
        [Persistent]
        public string ProductName { get; set; }
        [Persistent]
        public string ProductDisplayName { get; set; }
        [Persistent]
        public bool IsDiscontinued { get; set; }
        [Persistent]
        public DateTime? DiscontinuedDate { get; set; }
        [Persistent]
        public DateTime ValidFrom { get; set; }
        [Persistent]
        public DateTime? ValidTo { get; set; }
        [Persistent]
        public bool IsActive { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public DateTime? LastUpdatedDate { get; set; }
        [Persistent]
        public Int64 CreatedBy { get; set; }
        [Persistent]
        public Int64? LastUpdatedBy { get; set; }
        [Persistent]
        public string Description { get; set; }
        [Persistent]
        public int WorkFlowCode { get; set; }
        [Persistent]
        public bool IsSFXProduct { get; set; }
        [Persistent]
        public bool? IsDefaultMappingWithBranch { get; set; }
        [Persistent]
        public bool? IsFlashLoan { get; set; }
        [Persistent]
        public bool? IsExpressLoan { get; set; }

        #region Constructor
        public PRD_Products() : base() { }
        public PRD_Products(Session session) : base(session) { }
        #endregion
    }
}
