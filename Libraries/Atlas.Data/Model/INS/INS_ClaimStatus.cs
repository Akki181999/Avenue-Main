using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_ClaimStatus:XPLiteObject
    {
        [Key]
        [Persistent]
        public int ClaimStatusId { get; set; }
        [Persistent]
        public char ClaimStatus { get; set; }
        [Persistent]
        public string Description { get; set; }

        #region Constructors

        public INS_ClaimStatus() : base() { }
        public INS_ClaimStatus(Session session) : base(session) { }

        #endregion
    }
}
