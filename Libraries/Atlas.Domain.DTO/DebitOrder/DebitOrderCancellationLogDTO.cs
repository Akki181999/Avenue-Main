using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.DebitOrder
{
	public class DebitOrderCancellationLogDTO
    {
		public long DebitOrderCancellationLogId { get; set; }
		public long ApplicationId { get; set; }
		public long AccountId { get; set; }
		public long DebitOrderId { get; set; }
		public long DebitOrderModeId { get; set; }
		public string ServiceType { get; set; }
		public string TransactionId { get; set; }
		public string Response { get; set; }
		public string ErrorMessage { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}
