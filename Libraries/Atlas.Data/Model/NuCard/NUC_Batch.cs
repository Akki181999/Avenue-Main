using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.NuCard
{
    public class NUC_Batch : XPCustomObject
    {
        private Int64 _BatchId;
        [Key(AutoGenerate = true)]
        public Int64 BatchId
        {
            get { return _BatchId; }
            set { SetPropertyValue("BatchId", ref _BatchId, value); }
        }

        private PER_Person _CreatedBy;
        [Persistent("CreatedBy")]
        [Indexed]
        public PER_Person CreatedBy
        {
            get { return _CreatedBy; }
            set { SetPropertyValue("CreatedBy", ref _CreatedBy, value); }
        }

        private BRN_Branch _TransferredToBranchId;
        [Persistent("TransferredToBranchId")]
        public BRN_Branch TransferredToBranchId
        {
            get { return _TransferredToBranchId; }
            set { SetPropertyValue("TransferredToBranchId", ref _TransferredToBranchId, value); }
        }

        private Int64 _NumberOfCards;
        [Persistent("NumberOfCards")]
        public Int64 NumberOfCards
        {
            get { return _NumberOfCards; }
            set { SetPropertyValue("NumberOfCards", ref _NumberOfCards, value); }
        }

        private BOS_Status _Status;
        [Persistent]
        public BOS_Status Status
        {
            get { return _Status; }
            set { SetPropertyValue("Status", ref _Status, value); }
        }
        
        private DateTime? _CreatedDate;
        [Persistent]
        public DateTime? CreatedDate
        {
            get { return _CreatedDate; }
            set { SetPropertyValue("CreatedDate", ref _CreatedDate, value); }
        }

        private string _FirstVN;
        [Persistent]
        public string FirstVN
        {
            get { return _FirstVN; }
            set { SetPropertyValue("FirstVN", ref _FirstVN, value); }
        }

        private string _LastVN;
        [Persistent]
        public string LastVN
        {
            get { return _LastVN; }
            set { SetPropertyValue("LastVN", ref _LastVN, value); }
        }

        #region Constructors

        public NUC_Batch() : base() { }
        public NUC_Batch(Session session) : base(session) { }

        #endregion
    }
}

