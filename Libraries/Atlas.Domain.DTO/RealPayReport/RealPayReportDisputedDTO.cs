using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.RealPayReport
{
    public class RealPayReportDisputedDTO
    {
        public struct ReportDisputedKey
        {
            public string TransactionId { get; set; }
            public string ContractRef { get; set; }
            public string ServiceType { get; set; }
            public DateTime ValueDT { get; set; }
            public DateTime SuccessDT { get; set; }
        }

        public ReportDisputedKey ReportSuccess;
        public DateTime StartDT { get; set; }
        public string ContractNum { get; set; }
        public decimal ContractAmount { get; set; }
        public int InstalmentNum { get; set; }
        public decimal InstalmentAmount { get; set; }
        public string EmployerCode { get; set; }
        public string TrackingIndicator { get; set; }
        public int Frequency { get; set; }
        public string Pan { get; set; }
        //public int TerminalNum { get; set; }
        public string TerminalNum { get; set; }
        public string CardAcceptor { get; set; }
        public string InstitutionId { get; set; }
        public string IdNumber { get; set; }
    }
}
