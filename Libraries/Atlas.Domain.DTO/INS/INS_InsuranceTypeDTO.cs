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
    public class INS_InsuranceTypeDTO
    {
        [DataMember]
        public Int32 InsuranceTypeId { get; set; }
        [DataMember]
        public string InsuranceTypeName { get; set; }
    }
}
