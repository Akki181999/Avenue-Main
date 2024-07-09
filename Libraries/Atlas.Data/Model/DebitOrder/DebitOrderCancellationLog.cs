using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebitOrder
{
   public class DebitOrderCancellationLog : XPLiteObject
	{
		#region Constructors
		public DebitOrderCancellationLog() : base() { }
		public DebitOrderCancellationLog(Session session) : base(session) { }
		#endregion
		[Key(AutoGenerate = true)]
		public long DebitOrderCancellationLogId { get; set; }
		[Persistent]
		public long ApplicationId { get; set; }
		[Persistent]
		public long AccountId { get; set; }
		[Persistent]
		public string Request { get; set; }
		[Persistent]
		public string Response { get; set; }
		[Persistent]
		public string ErrorMessage { get; set; }
		[Persistent]
		public string Status { get; set; }

		[Persistent]
		public string Type { get; set; }
		[Persistent]
		public DateTime CreatedDate { get; set; }
	}
}
