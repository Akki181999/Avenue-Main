using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO
{
    public class CreditAssessment_RoleDTO
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 RoleId { get; set; }
        [DataMember]
        public string RoleName { get; set; }
    }
}
