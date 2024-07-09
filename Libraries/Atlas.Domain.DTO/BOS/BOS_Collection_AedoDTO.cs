using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BOS_Collection_AedoDTO
    {
        [DataMember]
        public Int64 CollectionId { get; set; }
        [DataMember]
        public string TransactionId { get; set; }
        [DataMember]
        public DateTime? ValueDate { get; set; }
        [DataMember]
        public string ContractNo { get; set; }
        [DataMember]
        public string TermId { get; set; }
        [DataMember]
        public DateTime? ActualDate { get; set; }
        [DataMember]
        public int? RetryCount { get; set; }
        [DataMember]
        public string Reason { get; set; }
        [DataMember]
        public decimal? ContactAmt { get; set; }
        [DataMember]
        public string Pan { get; set; }
        [DataMember]
        public int Installment { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public string Mass { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string EmpNo { get; set; }
        [DataMember]
        public int? OrigNoInstallment { get; set; }
        [DataMember]
        public string Future3 { get; set; }
        [DataMember]
        public string Future4 { get; set; }
        [DataMember]
        public string Future5 { get; set; }
        [DataMember]
        public decimal? OriginalLoanAmount { get; set; }
        [DataMember]
        public string SpfValue { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }
        [DataMember]
        public Boolean ProcessStatus { get; set; }

    }
}
