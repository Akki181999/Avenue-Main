using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public class DebiCheckMandateReport : XPLiteObject
    {
        [Key(AutoGenerate =true)]
        [Persistent]
        public long MandateReportId { get; set; }

        [Persistent]
        public string Code { get; set; }

        [Persistent]
        public string Description { get; set; }

        [Persistent]
        public string ReportCode { get; set; }

        public DebiCheckMandateReport() : base() { }
        public DebiCheckMandateReport(Session session) : base(session) { }
    }
}
