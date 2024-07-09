using System;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Atlas.Domain.Model.BOS
{
   public class BOS_Collection_Setting : XPCustomObject
    {
        private String _KeyOne;
        [Key(true)]
        public string KeyOne
        {
            get
            {
                return _KeyOne;
            }
            set
            {
                SetPropertyValue("KeyOne", ref _KeyOne, value);
            }
        }

        private String _Value;
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                SetPropertyValue("Value", ref _Value, value);
            }
        }
        #region Constructors

        public BOS_Collection_Setting() : base() { }
        public BOS_Collection_Setting(Session session) : base(session) { }

        #endregion
    }
}
