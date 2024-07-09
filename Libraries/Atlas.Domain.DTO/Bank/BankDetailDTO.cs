using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BankDetailDTO
    {
        [DataMember]
        public Int64 DetailId { get; set; }
        [DataMember]
        public BankDTO Bank { get; set; }
        [DataMember]
        public BankAccountTypeDTO AccountType { get; set; }
        [DataMember]
        public string AccountName { get; set; }
        [DataMember]
        public string AccountNum { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public PER_PersonDTO CreatedBy { get; set; }
        [DataMember]
        public DateTime? CreatedDT { get; set; }
        [DataMember]
        public int PeriodId { get; set; }
        [DataMember]
        public string CardNumber { get; set; }
        [DataMember]
        public string strikeDate1 { get; set; }
        [DataMember]
        public string strikeDate2 { get; set; }
        [DataMember]
        public string strikeDate3 { get; set; }
    }
}
