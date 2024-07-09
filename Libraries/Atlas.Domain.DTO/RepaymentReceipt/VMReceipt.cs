using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.RepaymentReceipt
{
    public sealed class VMReceipt
    {
        public string ReceiptNo { get; set; }
        public DateTime RepaymentDate { get; set; }
        public string BrClLn { get; set; }
        public string Name { get; set; }
        public string CellNo { get; set; }
        public decimal Outstanding { get; set; }
        public decimal AmountReceived { get; set; }
        public int AppId { get; set; }


        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }


        public string Credit_Provider_Role { get; set; }

        public string PaymentMode { get; set; }
        public string PaymentModeHeading { get; set; }

    }
}
