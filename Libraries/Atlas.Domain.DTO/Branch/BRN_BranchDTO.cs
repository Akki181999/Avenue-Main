using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Atlas.Domain.DTO.Branch;
using Atlas.Domain.DTO.Nucard;
using Newtonsoft.Json;

namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract(IsReference = false)]
    public class BRN_BranchDTO
    {
        [DataMember]
        public Int64 BranchId { get; set; }
        [DataMember]
        public CPY_CompanyDTO Company { get; set; }
        [DataMember]
        public NUC_NuCardProfileDTO DefaultNuCardProfile { get; set; }
        [DataMember]
        public RegionDTO Region { get; set; }
        [DataMember]
        public string LegacyBranchNum { get; set; }
        [DataMember]
        public DateTime? OpenDT { get; set; }
        [DataMember]
        public DateTime? CloseDT { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public PER_PersonDTO CreatedBy { get; set; }
        [DataMember]
        public PER_PersonDTO DeletedBy { get; set; }
        [DataMember]
        public DateTime? CreatedDT { get; set; }
        [DataMember]
        public string BranchName { get; set; }
        [DataMember]
        public string Email_Address { get; set; }
        [DataMember]
        public PER_PersonDTO Person { get; set; }
        [DataMember]
        public bool IsClosed { get; set; }
        [DataMember]
        public bool NotifyCustomer { get; set; } = true;
        [DataMember]
        public string AccPacBranchCode { get; set; }
        [DataMember]
        public string Weekends { get; set; }
        [DataMember]
        public decimal? FirstInterestRate { get; set; }
        [DataMember]
        public decimal? SecondInterestRate { get; set; }
        [DataMember]
        public bool IsQuoteApprovalRequired { get; set; }
        [DataMember]
        public Int64 CompanyId { get; set; }
        [DataMember]
        public Int32 BrandId { get; set; }
        [DataMember]
        public string QuoteApprovalRequiredTo { get; set; }
        [DataMember]
        public bool IsOCRBranch { get; set; }
    }

    public class BRN_Branchdto
    {

        public long? BranchId { get; set; }

        public string BranchName { get; set; }

        public long? CompanyId { get; set; }

        public List<BRN_Branch_DisbursementModesDTO> DisbursementModes{get; set;}
    }

    
}
