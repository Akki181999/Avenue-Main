using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.INS
{
    public class INS_InsuranceStatusDTO
    {
        
        public int PolicyStatusId { get; set; }
        
        public char PolicyStatus { get; set; }
        
        public string Description { get; set; }
    }
}
