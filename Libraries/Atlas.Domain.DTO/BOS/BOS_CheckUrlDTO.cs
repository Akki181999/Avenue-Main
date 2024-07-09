using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    public class BOS_CheckUrlDTO
    {
        public string URL { get; set; }
        public string UrlType { get; set; }
        public bool IsActive { get; set; }
    }
}
