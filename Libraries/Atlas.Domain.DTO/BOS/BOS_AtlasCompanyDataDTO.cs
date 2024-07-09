using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BOS_AtlasCompanyDataDTO
    {
        [DataMember]
        public Int64 CompanyId { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Credit_Provider { get; set; }
        [DataMember]
        public string VAT_Registration_No { get; set; }
        [DataMember]
        public string NCR_Registration_No { get; set; }
        [DataMember]
        public string Physical_Address { get; set; }
        [DataMember]
        public string Credit_Provider_Address { get; set; }
        [DataMember]
        public string Credit_Provider_ShopNo { get; set; }
        [DataMember]
        public string Credit_Provider_Role { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string BRN_Num { get; set; }
        [DataMember]
        public Int64? Telephone_Number { get; set; }
        [DataMember]
        public string PostalAddress { get; set; }
        [DataMember]
        public DateTime CreatedDT { get; set; }
        [DataMember]
        public DateTime LastEditedDT { get; set; }
    }
}
