using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Account
{
    public class ACC_ChangeDebitOrderDTO
    {
        public Int64 ChangeDebitOrderId { get; set; }
        public bool ChangeBankDetail { get; set; }
        public bool CreatePaymentPlan { get; set; }
        public Int64 BankDetailId { get; set; }
        public Int64 ApplicationId { get; set; }
        public Int64 AccountId { get; set; }
        public Int64 FrequencyTypeId { get; set; }
        public string PayDay { get; set; }
        public Decimal OutstandingBalance { get; set; }
        public Int64 Term { get; set; }
        public Decimal InstallmentAmount { get; set; }
        public DateTime FirstRepaymentDate { get; set; }
        public string TCCTerminalId { get; set; }
        public Int64 CancelledDebitOrderId { get; set; }
        public Int64 NewDebitOrderId { get; set; }
        public Int64 BranchId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public Int64 StatusId { get; set; }
        public Int64 DebitOrderModeId { get; set; }

    }
}
