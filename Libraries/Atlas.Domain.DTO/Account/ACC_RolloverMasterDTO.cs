using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Account
{
    public class ACC_RolloverMasterDTO
    {
        [DataMember]
        private int _RolloverId { get; set; }

        [DataMember]
        public string Frequency { get; set; }
        [DataMember]
        public int TotalNoOfInstallments { get; set; }
        [DataMember]
        public int TobeSettledInstallments { get; set; }
        
        [DataMember]
        public int ArrearInstallments { get; set; }

    }
}