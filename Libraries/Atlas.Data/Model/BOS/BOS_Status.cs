using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{

    public sealed class BOS_Status : XPCustomObject
    {

        private Int64 _StatusId;
        [Key(AutoGenerate = true)]
        public Int64 StatusId
        {
            get
            {
                return _StatusId;
            }
            set
            {
                SetPropertyValue("StatusId", ref _StatusId, value);
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

        #region Constructors

        public BOS_Status() : base() { }
        public BOS_Status(Session session) : base(session) { }

        #endregion
    }
}
