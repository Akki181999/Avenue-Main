using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Budgeting
{
    public class AtlasBudgeting : XPLiteObject
    {
        private long _BudgetingId;
        [Key(AutoGenerate = true)]
        [Persistent]
        public long BudgetingId
        {
            get
            {
                return _BudgetingId;
            }
            set
            {
                _BudgetingId = value;
            }
        }
        
        private string _FileName;
        [Persistent]
        public string FileName
        {
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
            }
        }

        private DateTime _UploadedDate;
        [Persistent]
        public DateTime UploadedDate
        {
            get
            {
                return _UploadedDate;
            }
            set
            {
                _UploadedDate = value;
            }
        }

        private int _UploadedBy;
        [Persistent]
        public int UploadedBy
        {
            get
            {
                return _UploadedBy;
            }
            set
            {
                _UploadedBy = value;
            }
        }

        private Boolean _IsValid;
        [Persistent]
        public Boolean IsValid
        {
            get
            {
                return _IsValid;
            }
            set
            {
                _IsValid = value;
            }
        }
        #region Constructors

        public AtlasBudgeting() : base() { }
        public AtlasBudgeting(Session session) : base(session) { }

        #endregion
    }
}
