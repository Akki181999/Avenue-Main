using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class PRD_CompanyDTO
    {
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public bool IsInherit { get; set; }
        public long ConfigKeyId { get; set; }
        public string ConfigValue { get; set; }
        public string ConfigKeyName { get; set; }
    }

    public class PRD_Company_DTO
    {
        public Int64 CompanyId { get; set; }

        public string CompanyName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public Boolean IsActive { get; set; }

        public Int64 CreatedBy { get; set; }

        public Int64 LastUpdatedBy { get; set; }

        public string Credit_Provider { get; set; }

        public string Credit_Provider_Address { get; set; }

        public string Credit_Provider_Role { get; set; }

        public string NCR_Registration_No { get; set; }

        public string VAT_Registration_No { get; set; }
    }
}
