using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_Action : XPCustomObject
    {
     
        private Int64 _ActionId;
        [Key(AutoGenerate = true)]
        public Int64 ActionId
        {
            get
            {
                return _ActionId;
            }
            set
            {
                SetPropertyValue("ActionId", ref _ActionId, value);
            }
        }

        private String _ActionName;
        public string ActionName
        {
            get
            {
                return _ActionName;
            }
            set
            {
                SetPropertyValue("ActionName", ref _ActionName, value);
            }
        }

        private string _AltText;
        public string AltText
        {
            get
            {
                return _AltText;
            }
            set
            {
                SetPropertyValue("AltText", ref _AltText, value);
            }
        }

        private string _API;
        public string API
        {
            get
            {
                return _API;
            }
            set
            {
                SetPropertyValue("API", ref _API, value);
            }
        }

        #region Constructors

        public BOS_Action() : base() { }
        public BOS_Action(Session session) : base(session) { }

        #endregion
    }
}
