using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebitOrder
{
    public class Add_Resubmit_InstallmentDetails : XPLiteObject
    {
		#region Constructors
		public Add_Resubmit_InstallmentDetails() : base() { }
		public Add_Resubmit_InstallmentDetails(Session session) : base(session) { }
		#endregion

		[Key(AutoGenerate = true)]
		public long Id { get; set; }

		[Persistent]
		public long AccountId { get; set; }

		[Persistent]
		public int FailedInstallmentSrNo { get; set; }

		[Persistent]
		public int InstallmentSrNo { get; set; }

		[Persistent]
		public DateTime SubmitDate { get; set; }

		[Persistent]
		public string Type { get; set; }

		[Persistent]
		public bool IsIDLP { get; set; }

		[Persistent]
		public DateTime CreatedDate { get; set; }
	}
}
