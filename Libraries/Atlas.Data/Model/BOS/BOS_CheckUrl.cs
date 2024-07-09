using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
    public class BOS_CheckUrl : XPCustomObject
    {
        
        private Int64 _CheckUrlId;
        [Key(AutoGenerate = true)]
        public Int64 CheckUrlId
        {
            get
            {
                return _CheckUrlId;
            }
            set
            {
                SetPropertyValue("CheckUrlId", ref _CheckUrlId, value);
            }
        }

        private string _URL;
        [Persistent]
        public string URL
        {
            get
            {
                return _URL;
            }
            set
            {
                SetPropertyValue("URL", ref _URL, value);
            }
        }


        //public string UrlType { get; set; }
        private string _UrlType;
        [Persistent]
        public string UrlType
        {
            get
            {
                return _UrlType;
            }
            set
            {
                SetPropertyValue("UrlType", ref _UrlType, value);
            }
        }


        //public bool IsActive { get; set; }
        private bool _IsActive;
        [Persistent]
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                SetPropertyValue("IsActive", ref _IsActive, value);
            }
        }

        //public string APIKey { get; set; }
        private string _APIKey;
        [Persistent]
        public string APIKey
        {
            get
            {
                return _APIKey;
            }
            set
            {
                SetPropertyValue("APIKey", ref _APIKey, value);
            }
        }

        public BOS_CheckUrl() : base() { }
        public BOS_CheckUrl(Session session) : base(session) { }
    }
}
