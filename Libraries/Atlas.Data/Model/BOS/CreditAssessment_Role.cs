using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
    public class CreditAssessment_Role : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 Id { get; set; }
        [Persistent]
        public Int64 RoleId { get; set; }
        [Persistent]
        public String RoleName { get; set; }

        public CreditAssessment_Role() : base() { }
        public CreditAssessment_Role(Session session) : base(session) { }
    }
}
