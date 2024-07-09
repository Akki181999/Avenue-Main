using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class CPY_CompanyDTO
    {
        [DataMember]
        public Int64 CompanyId { get; set; }
        [DataMember]
        public CPY_CompanyDTO ParentId { get; set; }
        [DataMember]
        public int? EmployerCode { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public PER_PersonDTO CreatedBy { get; set; }
        [DataMember]
        public DateTime? CreatedDT { get; set; }
        [DataMember]
        public DateTime? DeletedDT { get; set; }
        [DataMember]
        public DateTime? LastEditedDT { get; set; }

        #region Get below as needed after mapping

        [DataMember]
        public List<AddressDTO> Addresses { get; set; }
        [DataMember]
        public List<BankDetailDTO> BankDetails { get; set; }
        [DataMember]
        public List<ContactDTO> Contacts { get; set; }
        [DataMember]
        public List<BRN_BranchDTO> Branches { get; set; }
        [DataMember]
        public List<PER_PersonDTO> Persons { get; set; }

        #endregion

        [DataMember]
        public int IndustryId { get; set; }
        [DataMember]
        public string ContactNo { get; set; }
        
        [DataMember]
        public string SupervisorName { get; set; }
        [DataMember]
        public decimal? NetPay { get; set; }
        [DataMember]
        public int SalaryType { get; set; }
        [DataMember]
        public string EmployeeNo { get; set; }
        [DataMember]
        public DateTime? StartDate { get; set; }
        [DataMember]
        public string OccupationCode { get; set; }
        [DataMember]
        public string TelephoneNo { get; set; }
        [DataMember]
        public string CellNo { get; set; }
        [DataMember]
        public int PayDay { get; set; }

        //Copy Application start
        [DataMember]
        public DateTime? ContractEndDate { get; set; }
        [DataMember]
        public string PayDay1 { get; set; }
        [DataMember]
        public string PayDay2 { get; set; }
        [DataMember]
        public string PayDay3 { get; set; }
        [DataMember]
        public int AddressTypeId1 { get; set; }
        [DataMember]
        public int AddressTypeId2 { get; set; }
        [DataMember]
        public int AddressTypeId3 { get; set; }
        //Copy Application end
    }
}
