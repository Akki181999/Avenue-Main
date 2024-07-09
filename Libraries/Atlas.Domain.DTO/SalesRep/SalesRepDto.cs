using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.SalesRep
{
   public sealed class SalesRepDto
    {
       
        public string AgentCode { get; set; }
   
        public string FirstName { get; set; }
    
        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        public Atlas.Domain.DTO.SalesRep.SalesRepTypeDto Type { get; set; }

        public DateTime ActiveInActiveDate { get; set; }

        public string ManagerCode { get; set; }

        public Atlas.Domain.DTO.SalesRep.SalesManagerDto ManagerDetails { get; set; }

        public Char Gender { get; set; }

        public DateTime DateEngaged { get; set; }

        public string MiddleName { get; set; }

        public string IdNumber { get; set; }

        public string ConsultantCode { get; set; }

        public int GroupId { get; set; }

    }

    public sealed class SalesManagerDto
    {
        public string AgentCode { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        public SalesRepTypeDto Type { get; set; }

        public DateTime ActiveInActiveDate { get; set; }

        public Char Gender { get; set; }

        public DateTime DateEngaged { get; set; }

        public string MiddleName { get; set; }

        public string IdNumber { get; set; }
    }

}
