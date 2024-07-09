using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Account
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public int DebitOrderModeId { get; set; }
        public int DebitOrderId { get; set; }
        public string ServiceType { get; set; }
        public string TransactionId { get; set; }
    }
}
