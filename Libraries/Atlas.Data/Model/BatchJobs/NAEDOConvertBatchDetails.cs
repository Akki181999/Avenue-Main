using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BatchJobs
{
    public class NAEDOConvertBatchDetails : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        [Persistent]
        public long BatchDetailsId { get; set; }

        [Persistent]
        public long BatchId { get; set; }

        [Persistent]
        public long ApplicationId { get; set; }

        [Persistent]
        public long AccountId { get; set; }

        [Persistent]
        public string LoanType { get; set; }

        [Persistent]
        public string Request { get; set; }

        [Persistent]
        public string Response { get; set; }

        [Persistent]
        public string ErrorMessage { get; set; }

        [Persistent]
        public bool IsProcessed { get; set; }

        [Persistent]
        public string Status { get; set; }

        [Persistent]
        public DateTime? CreateDate { get; set; }

        [Persistent]
        public string Comment { get; set; }

        #region Constructors

        public NAEDOConvertBatchDetails() : base() { }
        public NAEDOConvertBatchDetails(Session session) : base(session) { }

        #endregion
    }
}
