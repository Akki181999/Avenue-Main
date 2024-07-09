using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Atlas.Domain.DTO.Branch;
using Atlas.Domain.DTO.Nucard;
using Newtonsoft.Json;

namespace Atlas.Domain.DTO.Commapy
{
    public class CompanyDTO
    {
        [DataMember]
        public Int64 CompanyId { get; set; }
        [DataMember]
        public string CompanyName { get; set; }        
        [DataMember]
        public bool IsActive { get; set; }
    }

    public class BrandDTO
    {
        [DataMember]
        public Int64 BrandId { get; set; }
        [DataMember]
        public string BrandName { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
