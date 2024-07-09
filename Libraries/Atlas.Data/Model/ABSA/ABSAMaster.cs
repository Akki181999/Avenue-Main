using System;
using System.Collections.Generic;
using System.Linq;
using Atlas.Common.Extensions;
using DevExpress.Xpo;
using Atlas.Domain.Interface;

namespace Atlas.Domain.Model.ABSA
{
    public class ABSAMaster : XPLiteObject
    {
        private string _bankservUserCode;
        [Persistent]
        [Key]
        public string BankservUserCode
        {
            get
            {
                return _bankservUserCode;
            }
            set
            {
                SetPropertyValue("BankservUserCode", ref _bankservUserCode, value);
            }
        }
        private int _userBranch;
        [Persistent]
        public int UserBranch
        {
            get
            {
                return _userBranch;
            }
            set
            {
                SetPropertyValue("UserBranch", ref _userBranch, value);
            }
        }
        private string _userNominatedAccount;
        [Persistent]
        public string UserNominatedAccount
        {
            get
            {
                return _userNominatedAccount;
            }
            set
            {
                SetPropertyValue("UserNominatedAccount", ref _userNominatedAccount, value);
            }
        }
        private int _userCode;
        [Persistent]
        public int UserCode
        {
            get
            {
                return _userCode;
            }
            set
            {
                SetPropertyValue("UserCode", ref _userCode, value);
            }
        }

        private string _userName;
        [Persistent]
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                SetPropertyValue("UserName", ref _userName, value);
            }
        }

        private string _typeOfService;
        [Persistent]
        public string TypeOfService
        {
            get
            {
                return _typeOfService;
            }
            set
            {
                SetPropertyValue("TypeOfService", ref _typeOfService, value);
            }
        }

        private string _recordIdentifier;
        [Persistent]
        public string RecordIdentifier
        {
            get
            {
                return _recordIdentifier;
            }
            set
            {
                SetPropertyValue("RecordIdentifier", ref _recordIdentifier, value);
            }
        }

        private string _dataSetStatus;
        [Persistent]
        public string DataSetStatus
        {
            get
            {
                return _dataSetStatus;
            }
            set
            {
                SetPropertyValue("DataSetStatus", ref _dataSetStatus, value);
            }
        }
        private string _UserReference1;
        [Persistent]
        public string UserReference1
        {
            get
            {
                return _UserReference1;
            }
            set
            {
                SetPropertyValue("UserReference1", ref _UserReference1, value);
            }
        }
        private string _UserReference2;
        [Persistent]
        public string UserReference2
        {
            get
            {
                return _UserReference2;
            }
            set
            {
                SetPropertyValue("UserReference2", ref _UserReference2, value);
            }
        }
        #region Constructors

        public ABSAMaster() : base() { }
        public ABSAMaster(Session session) : base(session) { }

        #endregion
    }
}
