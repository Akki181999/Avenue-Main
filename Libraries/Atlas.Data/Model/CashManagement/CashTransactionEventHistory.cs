using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
    public sealed class CashTransactionEventHistory : XPCustomObject
    {
        private Int64 _CashTransactionEventHistoryId;
        [Key(AutoGenerate = true)]
        public Int64 CashTransactionEventHistoryId
        {
            get
            {
                return _CashTransactionEventHistoryId;
            }
            set
            {
                SetPropertyValue("CashTransactionEventHistoryId", ref _CashTransactionEventHistoryId, value);
            }
        }
        private Int64 _BranchCashTransactionId;
        public Int64 BranchCashTransactionId
        {
            get
            {
                return _BranchCashTransactionId;
            }
            set
            {
                SetPropertyValue("BranchCashTransactionId", ref _BranchCashTransactionId, value);
            }
        }
        private Int64 _BranchCashReportId;
        public Int64 BranchCashReportId
        {
            get
            {
                return _BranchCashReportId;
            }
            set
            {
                SetPropertyValue("BranchCashReportId", ref _BranchCashReportId, value);
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

        private Int32 _Version;
        public Int32 Version
        {
            get
            {
                return _Version;
            }
            set
            {
                SetPropertyValue("Version", ref _Version, value);
            }
        }

        public CashTransactionEventHistory() : base() { }
        public CashTransactionEventHistory(Session session) : base(session) { }
    }
}