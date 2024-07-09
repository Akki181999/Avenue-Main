using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Log
{
    public class ServiceProviderMasterDTO
    {
        public Int64 ServiceProviderId { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Account { get; set; }
        public Boolean IsActive { get; set; }
        public string ServiceType { get; set; }
    }
}
