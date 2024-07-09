using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.DebiCheck
{
    public class DebiCheckReportBatchDTO
    {
        public Int64 DebiCheckReportBatchId { get; set; }
        public string MerchantNum { get; set; }
        public string ServiceType { get; set; }
        public int ReportType { get; set; }
        public DateTime ReportFromDT { get; set; }
        public DateTime ReportToDT { get; set; }
        public Int64 TokenNum { get; set; }
        public Int64 BlockNum { get; set; }
        public int DebiCheckLoginId { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ReportGenerationDT { get; set; }
        public DateTime CreateDT { get; set; }
        public DateTime StartDT { get; set; }
        public DateTime EndDT { get; set; }
    }
}
