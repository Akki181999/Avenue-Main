using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Authentication
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Auth_UserDTO
    {
        [DataMember]
        public Int64 UserId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public PER_PersonDTO PersonId { get; set; }
        //[DataMember]
        //public BRN_BranchDTO HomeBranch { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
