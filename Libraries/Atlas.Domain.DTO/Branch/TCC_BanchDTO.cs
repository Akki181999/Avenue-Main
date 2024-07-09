using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Branch
{
    public class TCC_BranchDTO
    {
        public int BranchId
        {
            get; 
            set; 
        }
        public string MerchantId
        {
            get;
            set;
        }
       
        public bool IsDefault
        {
            get;
            set;
        }
        public string TerminalId
        {
            get;
            set;
        }
        public string POSMerchant
        {
            get;
            set;
        }
    }
}
