using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.ThirdParty
{
   public class ThirdParty_Master: XPCustomObject
    {
        private Int64 _ThirdPartyId;
        [Key(AutoGenerate = true)]
        public Int64 ThirdPartyId
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
        private string _Description;
        [Persistent]
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetPropertyValue("Description", ref _Description, value);
            }
        }
        public ThirdParty_Master() : base() { }
        public ThirdParty_Master(Session session) : base(session) { }

    }
}
