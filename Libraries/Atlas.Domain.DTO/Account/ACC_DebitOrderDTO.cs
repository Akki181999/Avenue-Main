using System;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO.Account
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class ACC_DebitOrderDTO
    {
        [DataMember]
        public Int64 DebitOrderId { get; set; }
        [DataMember]
        public Int64 AccountId { get; set; }
        [DataMember]
        public string responseCode { get; set; }
        [DataMember]
        public string pAN { get; set; }
        [DataMember]
        public string transactionID { get; set; }
        [DataMember]
        public string approvalCode { get; set; }
        [DataMember]
        public Decimal contractAmount { get; set; }
        [DataMember]
        public string accountNumber { get; set; }
        [DataMember]
        public string accountType { get; set; }
        [DataMember]
        public string tracking { get; set; }
        [DataMember]
        public string adjRule { get; set; }
        [DataMember]
        public string frequency { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public string ContractNumber { get; set; }
        [DataMember]
        public bool IsExist { get; set; }
        [DataMember]
        public bool IsCancel { get; set; }
        [DataMember]
        public string ServiceType { get; set; }

        [DataMember]
        public DateTime CancelDate { get; set; }

        [DataMember]
        public string Request { get; set; }

        [DataMember]
        public string Response { get; set; }

        [DataMember]
        public string RequestTransactionId { get; set; }

        [DataMember]
        public string ThirdPartyCancel { get; set; } 

        [DataMember]
        public bool IsAdhoc { get; set; }

        [DataMember]
        public bool IsExternalMandate { get; set; }

        [DataMember]
        public string ServiceProvider { get; set; }

        //Future VAP Cancel
        [DataMember]
        public bool IsVAPCancel { get; set; }
    }
}