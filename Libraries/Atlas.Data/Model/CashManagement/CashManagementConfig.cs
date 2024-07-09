using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
    public class CashManagementConfig : XPLiteObject
    {
        private long _configID;

        [Key(AutoGenerate = true)]
        [Persistent]
        public long ConfigID
        {
            get { return _configID; }
            set { _configID = value; }
        }

        private string _key;

        [Persistent]
        public string Key
        {
            get { return _key; }
            set { SetPropertyValue("Key", ref _key, value); }
        }
        private string _value;

        [Persistent]
        public string Value
        {
            get { return _value; }
            set { SetPropertyValue("Value", ref _value, value); }
        }
        public CashManagementConfig() : base() { }
        public CashManagementConfig(Session session) : base(session) { }
    }
}