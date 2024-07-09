using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Atlas.Domain.DTO.BOS;
using Newtonsoft.Json;

namespace Atlas.Domain.DTO.Nucard
{
    [Serializable]
    [DataContract(IsReference = true)]
    [JsonObject(IsReference = false)]
    public class NUC_BatchDto
    {
        [DataMember]
        public Int64 BatchId { get; set; }
        [DataMember]
        public PER_PersonDTO CreatedBy { get; set; }
        [DataMember]
        public BRN_BranchDTO TransferredToBranchId { get; set; }
        [DataMember]
        public Int32 NumberOfCards { get; set; }
        [DataMember]
        public BOS_StatusDTO Status { get; set; }
        [DataMember]
        public DateTime? CreatedDate { get; set; }
        [DataMember]
        public string FirstVN { get; set; }
        [DataMember]
        public string LastVN { get; set; }
    }
}
