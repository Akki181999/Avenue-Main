using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    public class VMLGRTransaction
    {
      
        public long TransactionId { get; set; }
       
        public long AccountId { get; set; }
       
        public long PersonId { get; set; }
       
        //public DateTime? CalculatedArrearsDate { get; set; }
       
        public string TransactionType { get; set; }
       
        public decimal Fee { get; set; }
       
        public string LGRType { get; set; }
       
        public decimal Amount { get; set; }
       
        public DateTime TransactionDate { get; set; }
       
        public string CreateUser { get; set; }
      
        public DateTime CreateDate { get; set; }

        //public DateTime? AccPacExportDate { get; set; }


        public string PaymentMode { get; set; }
        public List<BOS_ActionDTO> Actions { get; set; }
        public List<VMLGRTransaction> LGRTransHistoryList { get; set; }
    }
}
