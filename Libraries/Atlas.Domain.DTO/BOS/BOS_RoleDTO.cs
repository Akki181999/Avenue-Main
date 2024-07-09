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
    public class BOS_RoleDTO
    {
        [DataMember]
        public Int64 RoleId { get; set; }
        [DataMember]
        public string RoleName { get; set; }

        [DataMember]
        public bool IsCalenderValidationEnable { get; set; }

        [DataMember]
        public bool IsMultipleCompany { get; set; }
    }
}
