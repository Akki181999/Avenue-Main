using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_WorkFlowService : XPCustomObject
    {

        private Int64 _WorkFlowServiceId;
        [Key(AutoGenerate = true)]
        public Int64 WorkFlowServiceId
        {
            get
            {
                return _WorkFlowServiceId;
            }
            set
            {
                SetPropertyValue("WorkFlowServiceId", ref _WorkFlowServiceId, value);
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

        private BOS_Action _action;
        [Persistent("ActionId")]
        public BOS_Action Action
        {
            get
            {
                return _action;
            }
            set
            {
                SetPropertyValue("ActionId", ref _action, value);
            }
        }

        private BOS_Status _newstatus;
        [Persistent("NewStatusId")]
        public BOS_Status NewStatus
        {
            get
            {
                return _newstatus;
            }
            set
            {
                SetPropertyValue("NewStatusId", ref _newstatus, value);
            }
        }

        private String _API;
        [Persistent("API")]
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

        private String _transitionFunction;
        public string TransitionFunction
        {
            get
            {
                return _transitionFunction;
            }
            set
            {
                SetPropertyValue("TransitionFunction", ref _transitionFunction, value);
            }
        }
        // private BOS_Status _CheckType;
        private string _CheckType;
        [Persistent("CheckType")]
       // public BOS_Status CheckType
            public string CheckType
        {
            get
            {
                return _CheckType;
            }
            set
            {
                SetPropertyValue("CheckType", ref _CheckType, value);
            }
        }

        [Persistent]
        public int WorkFlowCode { get; set; }

        [Persistent]
        public string Event { get; set; }
        #region Constructors

        public BOS_WorkFlowService() : base() { }
        public BOS_WorkFlowService(Session session) : base(session) { }

        #endregion
    }
}
