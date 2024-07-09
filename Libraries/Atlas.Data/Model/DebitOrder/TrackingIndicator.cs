using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.DebitOrder
{
    public class TrackingIndicator : XPLiteObject
    {
		[Key(AutoGenerate = true)]
		public long TrackingIndicatorId { get; set; }

		[Persistent]
		public string Frequency { get; set; }

		[Persistent]
		public int NoOfTerms { get; set; }

		[Persistent]
		public int Preload { get; set; }

		[Persistent]
		public string Indicator { get; set; }
		
		[Persistent]
		public DateTime CreatedDate { get; set; }

		[Persistent]
		public DateTime UpdatedDate { get; set; }

		#region Constructors
		public TrackingIndicator() : base() { }
		public TrackingIndicator(Session session) : base(session) { }
		#endregion
	}
}
