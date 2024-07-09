using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
  
    public sealed class BOS_Role : XPCustomObject
    {

        private Int64 _RoleId;
        [Key(AutoGenerate = true)]
        public Int64 RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                SetPropertyValue("RoleId", ref _RoleId, value);
            }
        }

        private String _RoleName;
        public string RoleName
        {
            get
            {
                return _RoleName;
            }
            set
            {
                SetPropertyValue("RoleName", ref _RoleName, value);
            }
        }

        private bool _IsCalenderValidationEnable;
        public bool IsCalenderValidationEnable
        {
            get
            {
                return _IsCalenderValidationEnable;
            }
            set
            {
                SetPropertyValue("IsCalenderValidationEnable", ref _IsCalenderValidationEnable, value);
            }
        }

        private bool _IsMultipleCompany;
        public bool IsMultipleCompany
        {
            get
            {
                return _IsMultipleCompany;
            }
            set
            {
                SetPropertyValue("IsMultipleCompany", ref _IsMultipleCompany, value);
            }
        }

        #region Constructors

        public BOS_Role() : base() { }
        public BOS_Role(Session session) : base(session) { }

        #endregion
    }
}
