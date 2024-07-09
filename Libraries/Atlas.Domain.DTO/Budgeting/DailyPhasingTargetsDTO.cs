using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Budgeting
{
    public class DailyPhasingTargetsDTO
    {
        [DataMember]
        public long DailyPhasingTargetId { get; set; }
        [DataMember]

        public int BudgetingId { get; set; }
        [DataMember]

        public DateTime TargetDate { get; set; }
        [DataMember]

        public decimal TargetPercentage { get; set; }
        
    }
    public class VMDailyPhasingTargets
    {
        public string TargetDate { get; set; }
        public string TargetDay { get; set; }
        public decimal TargetPercentage { get; set; }
    }
}
