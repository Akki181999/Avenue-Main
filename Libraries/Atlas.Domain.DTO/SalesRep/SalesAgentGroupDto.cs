using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.SalesRep
{
    public class SalesAgentGroupDto
    {
        public int SalesAgentGroupId { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
