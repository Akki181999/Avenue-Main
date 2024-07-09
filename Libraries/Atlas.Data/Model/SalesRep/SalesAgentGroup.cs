using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.SalesRep
{
    public class SalesAgentGroup : XPLiteObject
    {
        #region Constructors

        public SalesAgentGroup() : base() { }
        public SalesAgentGroup(Session session) : base(session) { }

        #endregion

        [Key]
        [Persistent]
        public int SalesAgentGroupId { get; set; }

        [Persistent]
        public string GroupCode { get; set; }

        [Persistent]
        public string GroupName { get; set; }

        [Persistent]
        public bool IsActive { get; set; }

        [Persistent]
        public DateTime CreatedDate { get; set; }
    }
}