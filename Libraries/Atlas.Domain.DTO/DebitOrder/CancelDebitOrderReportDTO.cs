using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.DebitOrder
{
    public class CancelDebitOrderReportDTO
    {
		public long CancelDebitOrderReportId { get; set; }
		public long CancelDebitOrderReportBatchId { get; set; }
		public long ApplicationId { get; set; }
		public long DisbursementModeId { get; set; }
		public long DebitOrderModeId { get; set; }
		public long AccountId { get; set; }
		public string TransactionId { get; set; }
		public string ErrorMessage { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}
