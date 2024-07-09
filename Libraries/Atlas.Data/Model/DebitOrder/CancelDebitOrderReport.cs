using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebitOrder
{
    public class CancelDebitOrderReport:XPLiteObject
    {
		#region Constructors
		public CancelDebitOrderReport() : base() { }
		public CancelDebitOrderReport(Session session) : base(session) { }
		#endregion

		[Key(AutoGenerate = true)]
		public long CancelDebitOrderReportId { get; set; }
		[Persistent]
		public long CancelDebitOrderReportBatchId { get; set; }
		[Persistent]
		public long ApplicationId { get; set; }
		[Persistent]
		public long DisbursementModeId { get; set; }
		[Persistent]
		public long DebitOrderModeId { get; set; }
		[Persistent]
		public long AccountId { get; set; }
		[Persistent]
		public string TransactionId { get; set; }
		[Persistent]
		public string ErrorMessage { get; set; }
		[Persistent]
		public string Status { get; set; }
		[Persistent]
		public DateTime CreatedDate { get; set; }
		[Persistent]
		public DateTime? UpdatedDate { get; set; }
	}
}
