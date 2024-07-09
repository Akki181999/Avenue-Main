using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{

    public sealed class ErrorMessages : XPCustomObject
    {

        private Int64 _Id;
        [Key(AutoGenerate = true)]
        public Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                SetPropertyValue("Id", ref _Id, value);
            }
        }

        private String _ErrorCode;
        public string ErrorCode
        {
            get
            {
                return _ErrorCode;
            }
            set
            {
                SetPropertyValue("ErrorCode", ref _ErrorCode, value);
            }
        }

        private String _Description;
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


        private String _ErrorMessage;
        public string ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }
            set
            {
                SetPropertyValue("ErrorMessage", ref _ErrorMessage, value);
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

        private String _ErrorPrefix;
        public string ErrorPrefix
        {
            get
            {
                return _ErrorPrefix;
            }
            set
            {
                SetPropertyValue("ErrorPrefix", ref _ErrorPrefix, value);
            }
        }

        #region Constructors

        public ErrorMessages() : base() { }
        public ErrorMessages(Session session) : base(session) { }

        #endregion
    }
}
