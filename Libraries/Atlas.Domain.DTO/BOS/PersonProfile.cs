using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    public class PersonProfile
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string IdNum { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<AddressDTO> AddressDetails { get; set; }
        public List<ContactDTO> Contacts { get; set; }
        public List<BOS_ActionDTO> Actions { get; set; }
    }
}
