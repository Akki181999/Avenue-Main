using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.SalesRep
{
    public class SalesRep: XPLiteObject
    {
        [Key]
        [Persistent]
        public string AgentCode { get; set; }

        [Persistent]
        public string FirstName { get; set; }

        [Persistent]
        public string LastName { get; set; }


        [Persistent]
        public bool IsActive { get; set; }

        [Persistent]
        public DateTime ModifiedDate { get; set; }

        [Persistent]
        public int ModifiedBy { get; set; }

        [Persistent]
        public SalesRepType Type { get; set; }

        [Persistent]
        public DateTime ActiveInActiveDate { get; set; }

        [Persistent]
        public string ManagerCode { get; set; }


        [Persistent]
        public Char Gender { get; set; }

        [Persistent]
        public DateTime DateEngaged { get; set; }

        [Persistent]
        public string MiddleName { get; set; }

        [Persistent]
        public string IdNumber { get; set; }

        [Persistent]
        public string ConsultantCode { get; set; }

        [Persistent]
        public int GroupId { get; set; }

        #region Constructors

        public SalesRep() : base() { }
        public SalesRep(Session session) : base(session) { }

        #endregion
    }

}
