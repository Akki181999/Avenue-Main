using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
    public class BOS_StateTransitionRule : XPCustomObject
    {
        private Int64 _StateTransitionRuleId;
        [Key(AutoGenerate = true)]
        public Int64 StateTransitionRuleId
        {
            get
            {
                return _StateTransitionRuleId;
            }
            set
            {
                SetPropertyValue("StateTransitionRuleId", ref _StateTransitionRuleId, value);
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

        private String _SubObject;
        [Persistent("SubObject")]
        public string SubObject
        {
            get
            {
                return _SubObject;
            }
            set
            {
                SetPropertyValue("SubObject", ref _SubObject, value);
            }
        }

        private BOS_Status _status;
        [Persistent("StatusId")]
        public BOS_Status Status
        {
            get
            {
                return _status;
            }
            set
            {
                SetPropertyValue("StatusId", ref _status, value);
            }
        }

        private string _Check;
        [Persistent("Check")]
        public string Check
        {
            get
            {
                return _Check;
            }
            set
            {
                SetPropertyValue("Check", ref _Check, value);
            }
        }

        private string _Name;
        [Persistent("Name")]
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
    }
}
