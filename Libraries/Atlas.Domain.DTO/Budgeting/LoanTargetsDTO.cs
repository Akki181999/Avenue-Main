using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Budgeting
{
    public class LoanTargetsDTO
    {
        [DataMember]
        public long LoanTargetId { get; set; }
        [DataMember]
        public long BudgetingId { get; set; }
        [DataMember]
        public int BranchId { get; set; }
        [DataMember]
        public string BranchName { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string TargetMonth { get; set; }
        [DataMember]
        public decimal TargetAmount { get; set; }
        [DataMember]
        public decimal TargetNew { get; set; }
        [DataMember]
        public decimal TargetRevived { get; set; }
        [DataMember]
        public decimal TargetExisting { get; set; }
        [DataMember]
        public decimal TargetTotalLoans { get; set; }
        
    }
}
