using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
namespace Atlas.Domain.Model.BOS
{
    public sealed  class BOS_NuCardEventHistory : XPCustomObject
    {
        private Int64 _NuCardEventHistoryId;
        [Key(AutoGenerate = true)]
        public Int64 NuCardEventHistoryId
        {
            get
            {
                return _NuCardEventHistoryId;
            }
            set
            {
                SetPropertyValue("NuCardEventHistoryId", ref _NuCardEventHistoryId, value);
            }
        }

        private Int64 _NuCardId;
        public Int64 NuCardId
        {
            get
            {
                return _NuCardId;
            }
            set
            {
                SetPropertyValue("NuCardId", ref _NuCardId, value);
            }
        }
        private Int64 _BranchId;
        public Int64 BranchId
        {
            get
            {
                return _BranchId;

            }
            set
            {
                SetPropertyValue("BranchId", ref _BranchId, value);
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
        private string _VoucherNumber;
        public string VoucherNumber
        {
            get
            {
                return _VoucherNumber;
            }
            set
            {
                SetPropertyValue("VoucherNumber", ref _VoucherNumber, value);
            }
        }
       
        public BOS_NuCardEventHistory() : base() { }
        public BOS_NuCardEventHistory(Session session) : base(session) { }
    }
}
