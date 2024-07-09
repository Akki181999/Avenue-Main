using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Account
{
    public class AutoWriteOff_Accounts : XPLiteObject
    {
        private Int64 _autoWriteOff_Accounts_Id;
        [Key(AutoGenerate = true)]
        public Int64 AutoWriteOff_Accounts_Id
        {
            get
            {
                return _autoWriteOff_Accounts_Id;
            }
            set
            {
                SetPropertyValue("AutoWriteOff_Accounts_Id", ref _autoWriteOff_Accounts_Id, value);
            }
        }

        private Int64 _autoWriteOffId;
        public Int64 AutoWriteOffId
        {
            get
            {
                return _autoWriteOffId;
            }
            set
            {
                SetPropertyValue("AutoWriteOffId", ref _autoWriteOffId, value);
            }
        }

        private Int64 _accountId;
        public Int64 AccountId
        {
            get
            {
                return _accountId;
            }
            set
            {
                SetPropertyValue("AccountId", ref _accountId, value);
            }
        }

        private Decimal _amount;
        public Decimal Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                SetPropertyValue("Amount", ref _amount, value);
            }
        }

        private string _status;
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                SetPropertyValue("Status", ref _status, value);
            }
        }

        private DateTime _processDate;
        [Persistent]
        public DateTime ProcessDate
        {
            get
            {
                return _processDate;
            }
            set
            {
                SetPropertyValue("ProcessDate", ref _processDate, value);
            }
        }

        #region Constructors
        public AutoWriteOff_Accounts() : base() { }
        public AutoWriteOff_Accounts(Session session) : base(session) { }
        #endregion
    }
}
