using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{

    public sealed class BOS_Menus : XPCustomObject
    {

        private Int64 _MenuId;
        [Key(AutoGenerate = true)]
        public Int64 MenuId
        {
            get
            {
                return _MenuId;
            }
            set
            {
                SetPropertyValue("MenuId", ref _MenuId, value);
            }
        }

        private String _KEY;
        public string Key
        {
            get
            {
                return _KEY;
            }
            set
            {
                SetPropertyValue("Key", ref _KEY, value);
            }
        }

        private String _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                SetPropertyValue("Name", ref _Name, value);
            }
        }


        private String _Category;
        public string Category
        {
            get
            {
                return _Category;
            }
            set
            {
                SetPropertyValue("Category", ref _Category, value);
            }
        }

        private String _API;
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

        private BOS_Object _object;
        [Persistent("ObjectId")]
        public BOS_Object Object
        {
            get
            {
                return _object;
            }
            set
            {
                SetPropertyValue("ObjectId", ref _object, value);
            }
        }

        private String _UIUrl;
        public string UIUrl
        {
            get
            {
                return _UIUrl;
            }
            set
            {
                SetPropertyValue("UIUrl", ref _UIUrl, value);
            }
        }

        private int _Sequence;
        public int Sequence
        {
            get
            {
                return _Sequence;
            }
            set
            {
                SetPropertyValue("Sequence", ref _Sequence, value);
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

        #region Constructors

        public BOS_Menus() : base() { }
        public BOS_Menus(Session session) : base(session) { }

        #endregion
    }

}
