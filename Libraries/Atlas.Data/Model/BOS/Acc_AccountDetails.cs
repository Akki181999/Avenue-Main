using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
    public class Acc_AccountDetails
    {
        public int Period { get; set; }
        public string Status { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal InstalmentAmount { get; set; }
        public int NumOfInstalments { get; set; }
        public string Comment { get; set; }
        public decimal RepayAmount { get; set; }

    }
}
