using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.INS
{

    [Serializable]
    [DataContract(IsReference = true)]
    public class INS_InsuranceDTO
    {
        [DataMember]
        public Int32 InsuranceTypeId { get; set; }

        [DataMember]
        public Int32 PolicyNumber { get; set; }

        [DataMember]
        public Int64 ClientId { get; set; }

        [DataMember]
        public Int64 AccountId { get; set; }

        [DataMember]
        public decimal TotalCoverageAmount { get; set; }

        [DataMember]
        public string PolicyStatus { get; set; }

        [DataMember]
        public DateTime PolicyStatusDate { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public Int64 CreatedBy { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }

        [DataMember]
        public Int64 UpdatedBy { get; set; }

        [DataMember]
        public DateTime PolicyReportedDate { get; set; }

        [DataMember]
        public Int64? VAPAccountId { get; set; }
    }
}
