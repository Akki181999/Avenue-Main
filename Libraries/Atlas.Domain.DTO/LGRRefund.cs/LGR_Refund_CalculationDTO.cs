using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.LGRRefund.cs
{
    public class LGR_Refund_CalculationDTO
    {
        public string RefundId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string TransactionGroup { get; set; }
        public string TransactionType { get; set; }
        [JsonProperty("DR/CR")]
        [Column(Name = "DR/CR")]
        public string DRCR { get; set; }
        public decimal? Amount { get; set; }
        public string AllowRefund { get; set; }
        public decimal? RefundAllocation { get; set; }
        public string RefundStatus { get; set; }
        public int RefundPaymentModeId { get; set; }
        public bool bitIsManual { get; set; }
    }
}
