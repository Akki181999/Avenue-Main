using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public class DebiCheckSuccessTransactions:XPLiteObject
    {
        [Key]
        [Persistent]
        public Int64 SuccessTransId { get; set; }
        [Persistent]
        public string tokenID { get; set; }
        [Persistent]
        public string blockID { get; set; }
        [Persistent]
        public string mandateID { get; set; }
        [Persistent]
        public string mandateRequestTransactionID { get; set; }
        [Persistent]
        public string mandateReference { get; set; }
        [Persistent]
        public string contractReference { get; set; }
        [Persistent]
        public string debtorID { get; set; }
        [Persistent]
        public string debtorBank { get; set; }
        [Persistent]
        public DateTime firstInstalmentDate { get; set; }
        [Persistent]
        public DateTime dateLoaded { get; set; }
        [Persistent]
        public string creditorBank { get; set; }
        [Persistent]
        public decimal instalmentAmount { get; set; }
        [Persistent]
        public DateTime actionDate { get; set; }
        [Persistent]
        public DateTime cycleDate { get; set; }
        [Persistent]
        public string clientReference { get; set; }
        [Persistent]
        public string status { get; set; }
        [Persistent]
        public string statusDescription { get; set; }
        [Persistent]
        public DateTime dateCreated { get; set; }
        [Persistent]
        public string instalment { get; set; }
        [Persistent]
        public string totalInstalments { get; set; }
        [Persistent]
        public string disputable { get; set; }
        [Persistent]
        public string employerCode { get; set; }
        [Persistent]
        public string trackingIndicator { get; set; }

        public DebiCheckSuccessTransactions() : base() { }
        public DebiCheckSuccessTransactions(Session session) : base(session) { }
    }
}
