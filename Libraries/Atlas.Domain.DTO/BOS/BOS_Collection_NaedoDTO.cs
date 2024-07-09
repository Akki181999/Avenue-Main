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
    public class BOS_Collection_NaedoDTO
    {
        [DataMember]
        public Int64 CollectionId { get; set; }
        [DataMember]
        public int ReportType { get; set; }
        [DataMember]
        public string TranID { get; set; }
        [DataMember]
        public string TTypeID { get; set; }
        [DataMember]
        public string MerchantID { get; set; }
        [DataMember]
        public DateTime? ActionDate { get; set; }
        [DataMember]
        public DateTime? ProcessDate { get; set; }
        [DataMember]
        public string ClientRef1 { get; set; }
        [DataMember]
        public string ClientRef2 { get; set; }
        [DataMember]
        public string HomingAccNo { get; set; }
        [DataMember]
        public string HomingBranch { get; set; }
        [DataMember]
        public int? AccType { get; set; }
        [DataMember]
        public int Installment { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public int? NoInstalments { get; set; }
        [DataMember]
        public string RCode { get; set; }
        [DataMember]
        public string QCode { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }
        [DataMember]
        public Boolean ProcessStatus { get; set; }

    }
}
