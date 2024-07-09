using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DayEndReport
{
    public sealed class DayEndReport : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        [Persistent]
        public long DayEndReportId { get; set; }

        [Persistent]
        public int BranchId { get; set; }

        [Persistent]
        public string Description { get; set; }

        [Persistent]
        public int Status { get; set; }

        [Persistent]
        public decimal SystemReportedValue { get; set; }

        [Persistent]
        public decimal UserReportedValue { get; set; }

        [Persistent]
        public int CreatedBy { get; set; }

        [Persistent]
        public DateTime? CreatedDT { get; set; }

        [Persistent]
        public int ApprovedBy { get; set; }

        [Persistent]
        public DateTime? ApprovedDT { get; set; }

        [Persistent]
        public string Comment { get; set; }

        [Persistent]
        public string ApprovalComment { get; set; }

        #region Constructors

        public DayEndReport() : base() { }
        public DayEndReport(Session session) : base(session) { }

        #endregion
    }
}
