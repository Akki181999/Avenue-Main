using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.DebiCheck
{
    public class MandateReportResponseModel
    {
        public class MandateeReport
        {
            public string AccessID { get; set; }
            public string ReportType { get; set; }
            public string DateFrom { get; set; }
            public string DateTo { get; set; }
            public DateTime DateTimeStamp { get; set; }
            public string TokenID { get; set; }
            public string BlockID { get; set; }
        }

        public class ReportDetails
        {
            public string TokenID { get; set; }
            public string BlockID { get; set; }
            public string MandateID { get; set; }
            public string CardAcceptor { get; set; }
            public string MandateStatus { get; set; }
            public string ContractReference { get; set; }
            public string DebtorBank { get; set; }
            public DateTime FirstInstalmentDate { get; set; }
            public DateTime DateLoaded { get; set; }
            public string CreditorBank { get; set; }
            public string Instalment { get; set; }
            public string Instalments { get; set; }
            public string Tracking { get; set; }
            public string Frequency { get; set; }
            public string CollectionDay { get; set; }
            public string InstalmentAmount { get; set; }
            public string MaxCollectionAmount { get; set; }
            public string EntryCode { get; set; }
            public DateTime StartDate { get; set; }
            public string DateAdjustRuleIndicator { get; set; }
            public string DebitValueType { get; set; }
            public string AuthType { get; set; }
            public string ClientRefernce { get; set; }
            public string AdjustmentCategory { get; set; }
            public string AdjustmentAmount { get; set; }
            public string AdjustmentRate { get; set; }
            public string DebtorName { get; set; }
            public string DebtorID { get; set; }
            public string DebtorAccountNumber { get; set; }
            public string DebtorAccountType { get; set; }
            public string DebtorBranchCode { get; set; }
            public string DebtorPhoneNumber { get; set; }
            public string DebtorEmail { get; set; }
            public string MandateReference { get; set; }
            public string MandateRequestTransactionID { get; set; }
            public string EmployerCode { get; set; }
            public string OriginalAmount { get; set; }
            public string TpfValue { get; set; }
            public string TotalAmount { get; set; }
            public string MandateStatusGrouping { get; set; }
        }

        public class ResponseMessage
        {
            public string ResponseCode { get; set; }
            public string ResponseDescription { get; set; }
            public DateTime DateTimeStamp { get; set; }
        }

        public class MandateReportResponseNew
        {
            public MandateeReport MandateReport { get; set; }
            public List<ReportDetails> ReportDetails { get; set; }
            public ResponseMessage responseMessage { get; set; }
        }
    }
}
