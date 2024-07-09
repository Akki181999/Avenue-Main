using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Branch
{
   public class DebitOrderModes : XPLiteObject
    {
        [Key]
        [Persistent]
        public long DebitOrderModeId { get; set; }
        [Persistent]
        public string Description { get; set; }

        [Persistent]
        public bool IsActive { get; set; }

        [Persistent]
        public string ServiceProviderName { get; set; }
        #region Constructors

        public DebitOrderModes() : base() { }
        public DebitOrderModes(Session session) : base(session) { }

        #endregion
    }
}
