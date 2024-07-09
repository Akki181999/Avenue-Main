using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_CustomerHistory : XPCustomObject
    {
        private Int64 _CustomerHistoryId;
        [Key(AutoGenerate = true)]
        public Int64 CustomerHistoryId
        {
            get
            {
                return _CustomerHistoryId;
            }
            set
            {
                SetPropertyValue("CustomerHistoryId", ref _CustomerHistoryId, value);
            }
        }

        private Int32 _ClientId;
        public Int32 ClientId
        {
            get
            {
                return _ClientId;
            }
            set
            {
                SetPropertyValue("ClientId", ref _ClientId, value);
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

        public BOS_CustomerHistory() : base() { }
        public BOS_CustomerHistory(Session session) : base(session) { }
    }
}
