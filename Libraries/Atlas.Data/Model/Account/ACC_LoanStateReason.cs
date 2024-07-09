using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class ACC_LoanStateReason : XPLiteObject
    {
        private string _code;
        [Key]
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                SetPropertyValue("Code", ref _code, value);
            }
        }

         private string _description;
        [Persistent, Size(100)]
        [Indexed]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetPropertyValue("Description", ref _description, value);
            }
        }

        #region Constructors

        public ACC_LoanStateReason() : base() { }
        public ACC_LoanStateReason(Session session) : base(session) { }

        #endregion
    }
}
