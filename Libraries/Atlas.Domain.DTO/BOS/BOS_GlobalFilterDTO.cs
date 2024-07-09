using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
   public class BOS_GlobalFilterDTO
    {
        public string Object { get; set; }
        public string FilterCondition { get; set; }
        public string ValidationMessge { get; set; }
    }
}
