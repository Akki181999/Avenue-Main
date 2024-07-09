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
    public class BOS_Collection_RealPayDTO
    {
        [DataMember]
        public Int64 CollectionId { get; set; }
        [DataMember]
        public string ProductCode { get; set; }
        [DataMember]
        public DateTime? TransactionDate { get; set; }
        [DataMember]
        public DateTime? TrackingStartDate { get; set; }
        [DataMember]
        public char Status { get; set; }
        [DataMember]
        public string ContractNumber { get; set; }
        [DataMember]
        public string MerchantNumber { get; set; }
        [DataMember]
        public decimal? AmountRequested { get; set; }
        [DataMember]
        public int InstallmentSequence { get; set; }
        [DataMember]
        public decimal? BankStatementRef { get; set; }
        [DataMember]
        public decimal? Total { get; set; }
        [DataMember]
        public string ClientNumber { get; set; }
        [DataMember]
        public string ContractSequence { get; set; }
        [DataMember]
        public decimal AmountCollected { get; set; }
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public string TrackingHits { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }
        [DataMember]
        public Boolean ProcessStatus { get; set; }
    }
}
