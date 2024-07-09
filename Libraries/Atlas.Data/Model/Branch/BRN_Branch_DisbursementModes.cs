using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Branch
{
    public class BRN_Branch_DisbursementModes:XPLiteObject
    {
        [Key(AutoGenerate = true)]
      
        public long BranchDisburseModeId { get; set; }
        [Persistent]
        public Int64 BranchId { get; set; }
        [Persistent]
        public Int32 DisbursementModeId { get; set; }
        [Persistent]
        public Boolean IsCardRequired { get; set; }

        #region Constructors

        public BRN_Branch_DisbursementModes() : base() { }
        public BRN_Branch_DisbursementModes(Session session) : base(session) { }

        #endregion
    }
}
