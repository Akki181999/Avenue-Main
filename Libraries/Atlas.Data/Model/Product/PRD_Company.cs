using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Product
{
    public class PRD_Company : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 CompanyId { get; set; }

        [Persistent]
        public string CompanyName { get; set; }

        [Persistent]
        public DateTime CreatedDate { get; set; }

        [Persistent]
        public DateTime? LastUpdatedDate { get; set; }

        [Persistent]
        public Boolean IsActive { get; set; }

        [Persistent]
        public Int64 CreatedBy { get; set; }

        [Persistent]
        public Int64 LastUpdatedBy { get; set; }

        [Persistent]
        public string Credit_Provider { get; set; }

        [Persistent]
        public string Credit_Provider_Address { get; set; }

        [Persistent]
        public string Credit_Provider_Role { get; set; }

        [Persistent]
        public string NCR_Registration_No { get; set; }


        [Persistent]
        public string VAT_Registration_No { get; set; }

        #region Constructors
        public PRD_Company() : base() { }
        public PRD_Company(Session session) : base(session) { }
        #endregion
    }
}
