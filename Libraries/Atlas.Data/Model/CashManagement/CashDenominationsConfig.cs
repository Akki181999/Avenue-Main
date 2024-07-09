using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
    public class CashDenominationsConfig : XPLiteObject
    {
        private long _cashDenominationsConfigId;

        [Key(AutoGenerate = true)]
        [Persistent]
        public long CashDenominationsConfigId
        {
            get { return _cashDenominationsConfigId; }
            set { _cashDenominationsConfigId = value; }
        }

        private string _description;

        [Persistent]
        public string Description
        {
            get { return _description; }
            set { SetPropertyValue("Description", ref _description, value); }
        }

        private decimal _value;
        [Persistent]
        public decimal Value
        {
            get { return _value; }
            set { SetPropertyValue("Value", ref _value, value); }
        }       

        public CashDenominationsConfig() : base() { }
        public CashDenominationsConfig(Session session) : base(session) { }
    }
}