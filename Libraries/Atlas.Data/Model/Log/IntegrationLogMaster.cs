using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Log
{
    public class IntegrationLogMaster : XPLiteObject
    {
        
        private String _integrationType;
        [Persistent]
        [Key]
        public String IntegrationType
        {
            get
            {
                return _integrationType;
            }
            set
            {
                SetPropertyValue("IntegrationType", ref _integrationType, value);
            }
        }

        private Boolean _status;
        [Persistent]
        public Boolean Status
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
        public IntegrationLogMaster() : base() { }
        public IntegrationLogMaster(Session session) : base(session) { }
    }
}
