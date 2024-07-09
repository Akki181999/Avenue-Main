using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.NuCard
{
    public class NUC_Batch_Audit : XPCustomObject
    {
        private Int64 _AuditId;
        [Key(AutoGenerate = true)]
        public Int64 AuditId
        {
            get { return _AuditId; }
            set { SetPropertyValue("AuditId", ref _AuditId, value); }
        }

        private NUC_Batch _BatchId;
        public NUC_Batch BatchId
        {
            get { return _BatchId; }
            set { SetPropertyValue("BatchId", ref _BatchId, value); }
        }

        private BOS_Action _ActionId;
        public BOS_Action ActionId
        {
            get { return _ActionId; }
            set { SetPropertyValue("ActionId", ref _ActionId, value); }
        }

        private PER_Person _ActionBy;
        [Persistent("ActionBy")]
        [Indexed]
        public PER_Person ActionBy
        {
            get { return _ActionBy; }
            set { SetPropertyValue("ActionBy", ref _ActionBy, value); }
        }
        
        private DateTime _ActionDT;
        [Persistent]
        public DateTime ActionDT
        {
            get { return _ActionDT; }
            set { SetPropertyValue("ActionDT", ref _ActionDT, value); }
        }

        #region Constructors

        public NUC_Batch_Audit() : base() { }
        public NUC_Batch_Audit(Session session) : base(session) { }

        #endregion
    }
}


