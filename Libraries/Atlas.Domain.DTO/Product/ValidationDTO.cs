using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
  public  class ValidationDTO
    {
      public  string Idnum { get; set; }
      public  decimal currentloanamount { get; set; }
      public  long AccountId { get; set; }
      public  string Spname { get; set; }
      public  string Paraminput { get; set; }
      public  string DBtype { get; set; }
      public string Paramoutput { get; set; }
      public int ApplicationId { get; set; }
        public decimal PayableAmount { get; set; }
        public int BranchId { get; set; }
        public int ClientId { get; set; }
        public string AccountNo { get; set; }
        public int BankId { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public long RollOverAccountId { get; set; }
        public string NuCardNumber { get; set; }
        public long ParentFlashLoanAccountId { get; set; }
    }
}
