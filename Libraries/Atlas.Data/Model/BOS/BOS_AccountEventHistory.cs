using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.BOS
{
    public sealed class BOS_AccountEventHistory : XPCustomObject
    {
        private Int64 _AccountEventHistoryId;
        [Key(AutoGenerate = true)]
        public Int64 AccountEventHistoryId
        {
            get
            {
                return _AccountEventHistoryId;
            }
            set
            {
                SetPropertyValue("AccountEventHistoryId", ref _AccountEventHistoryId, value);
            }
        }

        private Int64 _AccountId;
        public Int64 AccountId
        {
            get
            {
                return _AccountId;
            }
            set
            {
                SetPropertyValue("AccountId", ref _AccountId, value);
            }
        }

        private Auth_User _User;
        [Persistent("UserId")]
        public Auth_User User
        {
            get
            {
                return _User;
            }
            set
            {
                SetPropertyValue("UserId", ref _User, value);
            }
        }

        private BOS_Role _Role;
        [Persistent("RoleId")]
        public BOS_Role Role
        {
            get
            {
                return _Role;
            }
            set
            {
                SetPropertyValue("RoleId", ref _Role, value);
            }
        }

        private BOS_Action _Action;
        [Persistent("ActionId")]
        public BOS_Action Action
        {
            get
            {
                return _Action;
            }
            set
            {
                SetPropertyValue("ActionId", ref _Action, value);
            }
        }

        private string _Comment;
        public string Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                SetPropertyValue("Comment", ref _Comment, value);
            }
        }

        private string _FieldsModified;
        public string FieldsModified
        {
            get
            {
                return _FieldsModified;
            }
            set
            {
                SetPropertyValue("FieldsModified", ref _FieldsModified, value);
            }
        }

        private DateTime _ActionDate;
        public DateTime ActionDate
        {
            get
            {
                return _ActionDate;
            }
            set
            {
                SetPropertyValue("ActionDate", ref _ActionDate, value);
            }
        }
        private string _Category;
        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                SetPropertyValue("Category", ref _Category, value);
            }
        }
        private long _RepaymentId;
        public long RepaymentId
        {
            get
            {
                return _RepaymentId;

            }
            set
            {
                SetPropertyValue("RepaymentId", ref _RepaymentId, value);
            }
        }

        [NonPersistent]
        public string DisplayName
        {
            get { return this.Category; }
           
        }

        private Int32 _Version;
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            set
            {
                SetPropertyValue("Verion", ref _Version, value);
            }
        }
        private string _WriteOffReason;
        public string WriteOffReason
        {
            get
            {
                return _WriteOffReason;
            }
            set
            {
                SetPropertyValue("WriteOffReason", ref _WriteOffReason, value);
            }
        }
        private string _CancelReason;
        public string CancelReason
        {
            get
            {
                return _CancelReason;
            }
            set
            {
                SetPropertyValue("CancelReason", ref _CancelReason, value);
            }
        }
        public BOS_AccountEventHistory() : base() { }
        public BOS_AccountEventHistory(Session session) : base(session) { }
    }
}
