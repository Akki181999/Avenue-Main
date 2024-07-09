using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.AutoLoan
{
    public class FlashLoanDisbursementMode : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 Id { get; set; }

        [Persistent]
        public Int64 ApplicationId { get; set; }

        [Persistent]
        public Int16 DisbursementModeId { get; set; }

        [Persistent]
        public DateTime CreatedDate { get; set; }

        [Persistent]
        public DateTime? UpdatedDate { get; set; }

        #region Constructor
        public FlashLoanDisbursementMode() : base() { }
        public FlashLoanDisbursementMode(Session session) : base(session) { }
        #endregion
    }
}
