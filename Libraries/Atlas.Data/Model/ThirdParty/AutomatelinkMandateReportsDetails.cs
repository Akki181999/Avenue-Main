using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.ThirdParty
{
    public class AutomatelinkMandateReportsDetails : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        [Persistent]
        public int MandateReportId { get; set; }
        [Persistent]
        public string AccessID { get; set; }
        [Persistent]
        public string ReportType { get; set; }
        [Persistent]
        public string DateFrom { get; set; }
        [Persistent]
        public string DateTo { get; set; }
        [Persistent]
        public DateTime DateTimeStamp { get; set; }
        [Persistent]
        public string TokenID { get; set; }
        [Persistent]
        public string BlockID { get; set; }

        public AutomatelinkMandateReportsDetails() : base() { }
        public AutomatelinkMandateReportsDetails(Session session) : base(session) { }
    }
}
