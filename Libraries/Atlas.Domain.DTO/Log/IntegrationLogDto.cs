using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Log
{
    public class IntegrationLogDto
    {
       
        public Int64 IntegrationLogId { get; set; }

        public String AccountNo { get; set; }

       // public String ClientID { get; set; }
        public String IDNumber { get; set; }

        public String Request { get; set; }

        public String Response { get; set; }

        public String IntegrationType { get; set; }
        public String ApplicationNo { get; set; }
        public String ConsultantName { get; set; }
        public String BranchName { get; set; }
        public DateTime RequestTime { get; set; }
        public String EventName { get; set; }
       // public String Status { get; set; }

    }
}
