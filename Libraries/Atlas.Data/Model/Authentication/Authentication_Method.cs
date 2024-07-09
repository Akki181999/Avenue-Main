using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Authentication
{
    [Serializable]
    [DataContract]
    public sealed class Authentication_Method : XPCustomObject
    {
        private Int64 _MethodId;
        [Key(AutoGenerate = true)]
        [DataMember]
        public Int64 MethodId
        {
            get
            {
                return _MethodId;
            }
            set
            {
                SetPropertyValue("MethodId", ref _MethodId, value);
            }
        }

        private String _Application;
        [DataMember]
        public string Application
        {
            get
            {
                return _Application;
            }
            set
            {
                SetPropertyValue("Application", ref _Application, value);
            }
        }

        private String _MethodType;
        [DataMember]
        public string MethodType
        {
            get
            {
                return _MethodType;
            }
            set
            {
                SetPropertyValue("MethodType", ref _MethodType, value);
            }
        }

        #region Constructors

        public Authentication_Method() : base() { }
        public Authentication_Method(Session session) : base(session) { }

        #endregion
    }
}
