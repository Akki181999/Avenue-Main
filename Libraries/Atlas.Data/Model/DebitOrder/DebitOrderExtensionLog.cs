using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebitOrder
{
    public class DebitOrderExtensionLog : XPLiteObject
	{
		#region Constructors
		public DebitOrderExtensionLog() : base() { }
		public DebitOrderExtensionLog(Session session) : base(session) { }
		#endregion
		[Key(AutoGenerate = true)]
		public long DebitOrderExtensionLogId { get; set; }
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
