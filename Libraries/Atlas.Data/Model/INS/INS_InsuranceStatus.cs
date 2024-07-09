using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_InsuranceStatus:XPLiteObject
    {
        [Key]
        [Persistent]
        public int PolicyStatusId { get; set; }
        [Persistent]
        public char PolicyStatus { get; set; }
        [Persistent]
        public string Description { get; set; }

        #region Constructors

        public INS_InsuranceStatus() : base() { }
        public INS_InsuranceStatus(Session session) : base(session) { }

        #endregion
    }
}
