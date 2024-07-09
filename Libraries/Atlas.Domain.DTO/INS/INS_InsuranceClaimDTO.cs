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
    public class INS_InsuranceClaimDTO
    {
        [DataMember]
        public Int32 ClaimNumber { get; set; }

        [DataMember]
        public Int32 PolicyNumber { get; set; }

        [DataMember]
        public decimal ClaimAmount { get; set; }

        [DataMember]
        public int ClaimBy { get; set; }

        [DataMember]
        public decimal ClaimedPaidAmount { get; set; }

        [DataMember]
        public INS_ClaimReasonDTO ClaimReasonId { get; set; }

        [DataMember]
        public DateTime EventDate { get; set; }

        [DataMember]
        public DateTime NotificationDate { get; set; }

        [DataMember]
        public INS_ClaimStatusDTO ClaimStatusId { get; set; }

        [DataMember]
        public INS_ClaimRejectionReasonDTO RejectionReasonId { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }

        [DataMember]
        public int UpdatedBy { get; set; }

        [DataMember]
        public int CreatedBy { get; set; }

        [DataMember]
        public DateTime ClaimStatusDate { get; set; }

        [DataMember]
        public int RelationId { get; set; }

        [DataMember]
        public int BeneficiaryTypeId { get; set; }

        [DataMember]
        public string  EventDescripion { get; set; }

        [DataMember]
        public char ClaimType { get; set; }

        [DataMember]
        public int StatusId { get; set; }
        [DataMember]
        public int PaymentPeriod { get; set; }
        [DataMember]
        public string Claimant { get; set; }
        [DataMember]
        public string ClaimFor { get; set; }

        [DataMember]
        public Int64 NextOfKinId { get; set; }
    }
}
