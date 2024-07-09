using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Branch
{
    public class PRD_Brand: XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 BrandId { get; set; }
        [Persistent]
        public String BrandName { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public Boolean IsActive { get; set; }
        [Persistent]
        public Int64 CreatedBy { get; set; }
        [Persistent]
        public String Credit_Provider { get; set; }
        [Persistent]
        public String Credit_Provider_Address { get; set; }
        [Persistent]
        public String Credit_Provider_Role { get; set; }
        [Persistent]
        public String NCR_Registration_No { get; set; }
        [Persistent]
        public String VAT_Registration_No { get; set; }

        #region Constructors

        public PRD_Brand() : base() { }
        public PRD_Brand(Session session) : base(session) { }

        #endregion
    }
}
