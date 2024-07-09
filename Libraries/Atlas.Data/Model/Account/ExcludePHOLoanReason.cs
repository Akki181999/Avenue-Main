using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
   public sealed  class ExcludePHOLoanReason:XPLiteObject
    {
        [Key]
        [Persistent]
        public string Code { get; set; }
        [Persistent]
        public string Description { get; set; }

        #region Constructors

        public ExcludePHOLoanReason() : base() { }
        public ExcludePHOLoanReason(Session session) : base(session) { }

        #endregion
    }
}
