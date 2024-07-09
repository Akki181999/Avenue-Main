using Atlas.Domain.DTO.PaymentModes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Branch
{
    public sealed class BRN_Branch_DisbursementModesDTO
    {


        public Int32 DisbursementModeId { get; set; }

        public string Description { get; set; }
        public Boolean IsCardRequired { get; set; }

        public List<DebitOrderModesDTO> allowedDebitOrder { get; set; }
    }

    public class DebitOrderModesDTO
    {
        public int DebitOrderModeId { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int MaxRetryCount { get; set; }
        public int AttemptCount { get; set; }
        public bool IsActive { get; set; }
        public string ServiceProviderName { get; set; }
    }

    public class DisbursementModeDTO
    {
        public int DisbursementModeId { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public VoucherDetails VoucherDetails { get; set; }
        public int MaxRetryCount { get; set; }
        public int AttemptCount { get; set; }
    }

    public class VoucherDetails { }

}
