using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Log
{
    public class GetScoreCount : XPLiteObject
    {
        private Int64 _getScoreCountId;
        [Key(AutoGenerate = true)]
        public Int64 GetScoreCountId
        {
            get
            {
                return _getScoreCountId;
            }
            set
            {
                SetPropertyValue("GetScoreCountId", ref _getScoreCountId, value);
            }
        }

        private String _applicationId;
        [Persistent]
        public String ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _applicationId, value);
            }
        }

        private String _type;
        [Persistent]
        public String Type
        {
            get
            {
                return _type;
            }
            set
            {
                SetPropertyValue("_type", ref _type, value);
            }
        }

        private String _status;
        [Persistent]
        public String Status
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

        public GetScoreCount() : base() { }
        public GetScoreCount(Session session) : base(session) { }
    }
}
