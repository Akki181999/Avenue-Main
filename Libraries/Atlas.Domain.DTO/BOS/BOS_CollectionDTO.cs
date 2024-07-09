using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
  public  class BOS_CollectionDTO
    {
        public List<AEDODTO> Aedo { get; set; }
        public List<NEADODTO> Neado { get; set; }
        public List<RPayDTO> Rpay { get; set; }

    }
    public class AEDODTO
    {

        public string transaction_id { get; set; }
        public string value_date { get; set; }
        public string contract_no { get; set; }
        public string term_id { get; set; }
        public string actual_date { get; set; }
        public string retry_count { get; set; }
        public string reason { get; set; }
        public decimal contact_amt { get; set; }
        public string pan { get; set; }
        public int instalment { get; set; }
        public decimal amount { get; set; }
        public string mass { get; set; }
        public string type { get; set; }
        public string emp_no { get; set; }
        public int orig_no_install { get; set; }
        public string future3 { get; set; }
        public string future4 { get; set; }
        public string future5 { get; set; }
        public decimal original_loan_amount { get; set; }
        public string spf_value { get; set; }


    }
    public class NEADODTO

    {
        public string ReportType { get; set; }
        public string TranID { get; set; }
        public string TTypeID { get; set; }
        public string MerchantID { get; set; }
        public string ActionDate { get; set; }
        public string ProcessDate { get; set; }
        public string ClientRef1 { get; set; }
        public string ClientRef2 { get; set; }
        public string HomingAccNo { get; set; }
        public string HomingBranch { get; set; }
        public string AccType { get; set; }
        public string Instalment { get; set; }
        public string Amount { get; set; }
        public string NoInstalments { get; set; }
        public string RCode { get; set; }
        public string QCode { get; set; }

    }
    public class RPayDTO
    {
        public string productCode { get; set; }
        public string transactionDate { get; set; }
        public string trackingStartDate { get; set; }
        public string status { get; set; }
        public string contractNumber { get; set; }
        public string merchantNumber { get; set; }
        public string amountRequested { get; set; }
        public string installmentSequence { get; set; }
        public decimal bankStatementRef { get; set; }
        public string total { get; set; }
        public string clientNumber { get; set; }
        public string contractSequence { get; set; }
        public string amountCollected { get; set; }
        public string result { get; set; }
        public string trackingHits { get; set; }

    }
}
