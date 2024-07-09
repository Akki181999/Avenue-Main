using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Account
{
    public class InitiateDisbursement : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public long Id { get; set; }

        [Persistent]
        public long ApplicationId { get; set; }
        [Persistent]
        public long AccountId { get; set; }

        [Persistent]
        public int DisbursementModeId { get; set; }
        [Persistent]
        public string NuCardNumber { get; set; }

        [Persistent]
        public string DisbursementStatus { get; set; }
        [Persistent]
        public DateTime CreateDate { get; set; }

        #region Constructors

        public InitiateDisbursement() : base() { }
        public InitiateDisbursement(Session session) : base(session) { }

        #endregion
    }
}