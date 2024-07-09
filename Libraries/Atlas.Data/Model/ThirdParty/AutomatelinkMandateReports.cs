using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.ThirdParty
{
    public class AutomatelinkMandateReports : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        [Persistent]
        public int ReportDetailId { get; set; }
        [Persistent]
        public string TokenID { get; set; }
        [Persistent]
        public string BlockID { get; set; }
        [Persistent]
        public string MandateID { get; set; }
        [Persistent]
        public string CardAcceptor { get; set; }
        [Persistent]
        public string MandateStatus { get; set; }
        [Persistent]
        public string ContractReference { get; set; }
        [Persistent]
        public string DebtorBank { get; set; }
        [Persistent]
        public DateTime FirstInstalmentDate { get; set; }
        [Persistent]
        public DateTime DateLoaded { get; set; }
        [Persistent]
        public string CreditorBank { get; set; }
        [Persistent]
        public string Instalment { get; set; }
        [Persistent]
        public string Instalments { get; set; }
        [Persistent]
        public string Tracking { get; set; }
        [Persistent]
        public string Frequency { get; set; }
        [Persistent]
        public string CollectionDay { get; set; }
        [Persistent]
        public string InstalmentAmount { get; set; }
        [Persistent]
        public string MaxCollectionAmount { get; set; }
        [Persistent]
        public string EntryCode { get; set; }
        [Persistent]
        public DateTime StartDate { get; set; }
        [Persistent]
        public string DateAdjustRuleIndicator { get; set; }
        [Persistent]
        public string DebitValueType { get; set; }
        [Persistent]
        public string AuthType { get; set; }
        [Persistent]
        public string ClientRefernce { get; set; }
        [Persistent]
        public string AdjustmentCategory { get; set; }
        [Persistent]
        public string AdjustmentAmount { get; set; }
        [Persistent]
        public string AdjustmentRate { get; set; }
        [Persistent]
        public string DebtorName { get; set; }
        [Persistent]
        public string DebtorID { get; set; }
        [Persistent]
        public string DebtorAccountNumber { get; set; }
        [Persistent]
        public string DebtorAccountType { get; set; }
        [Persistent]
        public string DebtorBranchCode { get; set; }
        [Persistent]
        public string DebtorPhoneNumber { get; set; }
        [Persistent]
        public string DebtorEmail { get; set; }
        [Persistent]
        public string MandateReference { get; set; }
        [Persistent]
        public string MandateRequestTransactionID { get; set; }
        [Persistent]
        public string EmployerCode { get; set; }
        [Persistent]
        public string OriginalAmount { get; set; }
        [Persistent]
        public string TpfValue { get; set; }
        [Persistent]
        public string TotalAmount { get; set; }
        [Persistent]
        public string MandateStatusGrouping { get; set; }
        [Persistent]
        public string IsProcessed { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        [Persistent]
        public string ResponseDescription { get; set; }
        public int MandateReportId { get; set; }

        public AutomatelinkMandateReports() : base() { }
        public AutomatelinkMandateReports(Session session) : base(session) { }
    }
}
