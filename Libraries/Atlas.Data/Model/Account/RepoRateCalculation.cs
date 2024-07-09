using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Account
{
	public class RepoRateCalculation : XPLiteObject
	{
		[Key(AutoGenerate = true)]
		public long RepoRateCalculationId { get; set; }

		[Persistent]
		public decimal RepoRate { get; set; }

		[Persistent]
		public decimal Factor { get; set; }

		[Persistent]
		public decimal Adjustment { get; set; }

		[Persistent]
		public decimal FormulaRepoPA { get; set; }

		[Persistent]
		public DateTime EffectiveDate { get; set; }

		[Persistent]
		public DateTime CaptureDate { get; set; }

		[Persistent]
		public bool IsActive { get; set; }

		[Persistent]
		public DateTime CreateDate { get; set; }

		#region Constructors
		public RepoRateCalculation() : base() { }
		public RepoRateCalculation(Session session) : base(session) { }
		#endregion
	}
}
