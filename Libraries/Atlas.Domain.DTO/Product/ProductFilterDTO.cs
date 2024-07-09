using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class ProductFilterDTO
    {
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
        public int FrequencyTypeId { get; set; }
        public decimal GrossSalary { get; set; }
        public int NLRScore { get; set; }
        public decimal LoanAmount { get; set; }
        public bool IsVAPChecked { get; set; }
        public bool IsInsuranceRequired { get; set; }
        public int Age { get; set; }
        public int CountryId { get; set; }
        public long? RolloverAccountId { get; set; }
        public bool IsRollOverVAP { get; set; }
        public string NationalId { get; set; }
        public string Gender { get; set; }
    }
}
