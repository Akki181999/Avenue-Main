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
    public class BOS_AppRoleMappingDTO
    {
        [DataMember]
        public List<BOS_AppObjectDTO> AppObject { get; set; }
        [DataMember]
        public List<BOS_RoleDTO> Role { get; set; }
       
    }
}
