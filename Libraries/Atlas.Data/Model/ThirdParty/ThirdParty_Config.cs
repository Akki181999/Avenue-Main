using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.ThirdParty
{
   public class ThirdParty_Config : XPCustomObject
    {
        private Int32 _ConfigId;
        [Key(AutoGenerate = true)]
        public Int32 ConfigId
        {
            get
            {
                return _ConfigId;
            }
            set
            {
                SetPropertyValue("ConfigId", ref _ConfigId, value);
            }
        }

        private string _UserId;
        [Persistent]
        public string UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                SetPropertyValue("UserId", ref _UserId, value);
            }
        }

        private string _Password;
        [Persistent]
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                SetPropertyValue("Password", ref _Password, value);
            }
        }

        private string _MerchantId;
        [Persistent]
        public string MerchantId
        {
            get
            {
                return _MerchantId;
            }
            set
            {
                SetPropertyValue("MerchantId", ref _MerchantId, value);
            }
        }

        private string _ProfileId;
        [Persistent]
        public string ProfileId
        {
            get
            {
                return _ProfileId;
            }
            set
            {
                SetPropertyValue("ProfileId", ref _ProfileId, value);
            }
        }

        private string _AppId;
        [Persistent]
        public string AppId
        {
            get
            {
                return _AppId;
            }
            set
            {
                SetPropertyValue("AppId", ref _AppId, value);
            }
        }

        private BRN_Branch _BranchId;
        [Persistent("BranchId")]
        public BRN_Branch Branch
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

        private ThirdParty_Master _ThirdPartyId;
        [Persistent("ThirdPartyId")]
        public ThirdParty_Master ThirdParty
        {
            get
            {
                return _ThirdPartyId;
            }
            set
            {
                SetPropertyValue("ThirdPartyId", ref _ThirdPartyId, value);
            }
        }
        #region Constructors

        public ThirdParty_Config() : base() { }
        public ThirdParty_Config(Session session) : base(session) { }

        #endregion
    }
}
