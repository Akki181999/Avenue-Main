using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Branch
{
    public class DisbursementModeDebitOrderModesMapping : XPLiteObject
    {
        [Key(AutoGenerate = true)]        
        public long DisbursementModeDebitOrderId { get; set; }
        
        [Indexed]
        [Persistent("DebitOrderModeId")]
        public int DebitOrderModeId { get; set; }
        //[Indexed]
        [Persistent]
        public int BranchDisburseModeId { get; set; }


        #region Constructors

        public DisbursementModeDebitOrderModesMapping() : base() { }
        public DisbursementModeDebitOrderModesMapping(Session session) : base(session) { }

        #endregion
    }
}
