using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.DebiCheck
{
    public class DebiCheckCancelReasonDTO
    {
        public long CancelReasonId { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string CancellationCodeType { get; set; }
    }
}
