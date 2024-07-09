using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Budgeting
{
    public class LoanMixTargetsDTO
    {
        [DataMember]
        public long LoanMixTargetId { get; set; }
        [DataMember]
        public int BudgetingId { get; set; }
        [DataMember]
        public int LoanTerm { get; set; }
        [DataMember]
        public DateTime TargetDate { get; set; }
        [DataMember]
        public decimal TargetPercentage { get; set; }
        
    }
    public class VMLoanMixTargets
    {
        public int LoanTerm { get; set; }
        public string TargetDate { get; set; }
        public decimal TargetPercentage { get; set; }
    }
}
