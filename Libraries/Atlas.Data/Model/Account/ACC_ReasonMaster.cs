using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{

    public sealed class ACC_ReasonMaster : XPLiteObject
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

        private string _ReasonCode;
        [Persistent]
        public string ReasonCode
        {
            get
            {
                return _ReasonCode;
            }
            set
            {
                SetPropertyValue("ReasonCode", ref _ReasonCode, value);
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





        #region Constructors

        public ACC_ReasonMaster() : base() { }
        public ACC_ReasonMaster(Session session) : base(session) { }

        #endregion
    }
}
