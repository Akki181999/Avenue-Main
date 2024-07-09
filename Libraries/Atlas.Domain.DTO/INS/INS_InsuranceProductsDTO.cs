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
    public class INS_InsuranceProductsDTO
    {
        [DataMember]
        public Int32 InsuranceTypeId { get; set; }

        [DataMember]
        public string Admin_id { get; set; }

        [DataMember]
        public String InsurerName { get; set; }

        [DataMember]
        public string ClientId { get; set; }

        [DataMember]
        public string Divisionid { get; set; }

        [DataMember]
        public string Saleschannel { get; set; }

        [DataMember]
        public string DeathIndicator { get; set; }

        [DataMember]
        public decimal CommissionRate { get; set; }

        [DataMember]
        public decimal AdminFee { get; set; }

        [DataMember]
        public decimal OutsourceFee { get; set; }

        [DataMember]
        public decimal MarketingFee { get; set; }

        [DataMember]
        public decimal MgmntFee { get; set; }

        [DataMember]
        public decimal ClaimsFee { get; set; }


        [DataMember]
        public string SubSchemeName { get; set; }

        [DataMember]
        public decimal PriceModel { get; set; }

        [DataMember]
        public char ProductOption { get; set; }

    }
}
