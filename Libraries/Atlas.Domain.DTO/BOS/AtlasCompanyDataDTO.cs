using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    public class AtlasCompanyDataDTO
    {

        public string Type { get; set; }
        public string Credit_Provider { get; set; }
        public string NCR_Registration_No { get; set; }
        public string Physical_Address { get; set; }
        public Int64 Telephone_Number { get; set; }
        public Int64 CompanyId { get; set; }
        public string VAT_Registration_No { get; set; }
        public string Credit_Provider_Address { get; set; }
        public string Credit_Provider_ShopNo { get; set; }
        public string Credit_Provider_Role { get; set; }
        public string Email { get; set; }
        public string BRN_Num { get; set; }
        public string PostalAddress { get; set; }
    }
}
