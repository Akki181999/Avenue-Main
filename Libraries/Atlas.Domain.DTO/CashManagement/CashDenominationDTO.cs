using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CashManagement
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class CashDenominationDTO
    {

        [DataMember]
        public long CashDenominationsConfigID { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Value { get; set; }
    }
}
