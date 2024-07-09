using Atlas.Domain.DTO;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Budgeting
{
    public class AtlasBudgetingDTO
    {
        [DataMember]
        public long BudgetingId { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public DateTime UploadedDate { get; set; }
        [DataMember]
        public int UploadedBy { get; set; }
        [DataMember]
        public Boolean IsValid { get; set; }
        

    }
}
