using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BatchJobs
{
    public class NAEDOConvertBatch : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        [Persistent]
        public long BatchId { get; set; }

        [Persistent]
        public long NoOfRecords { get; set; }

        [Persistent]
        public long SuccessCount { get; set; }

        [Persistent]
        public long FailedCount { get; set; }

        [Persistent]
        public DateTime? StartTime { get; set; }

        [Persistent]
        public DateTime? EndTime { get; set; }

        #region Constructors

        public NAEDOConvertBatch() : base() { }
        public NAEDOConvertBatch(Session session) : base(session) { }

        #endregion
    }
}
