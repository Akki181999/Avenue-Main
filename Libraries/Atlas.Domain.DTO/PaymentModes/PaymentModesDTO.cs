using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.PaymentModes
{
    public sealed class PaymentModesDTO
    {
      
        public Int64 PaymentModeId { get; set; }
      
        public string PaymentCode { get; set; }
       
        public string PaymentDescription { get; set; }
      
        public string Type { get; set; }
        
        public bool IsActive { get; set; }

        public bool IsFingerPrintAllowed { get; set; }

        public bool IsCancelLoanAllowed { get; set; }

        public bool IsCardNumberRequired { get; set; }

        public bool UseRefundMode { get; set; }

    }
}
