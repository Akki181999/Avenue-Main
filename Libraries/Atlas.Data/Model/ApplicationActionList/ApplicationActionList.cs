using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.ApplicationActionList
{
    public class ApplicationActionList : XPLiteObject
    {
        private long _actionId { get; set; }
        [Key(AutoGenerate = true)]
        public long ActionId
        {
            get
            {
                return _actionId;
            }
            set
            {
                _actionId = value;
            }
        }

        private string _actionUrl { get; set; }
        public string ActionUrl
        {
            get
            {
                return _actionUrl;
            }
            set
            {
                _actionUrl = value;
            }
        }

        private int _sequenceNum { get; set; }
        public int SequenceNum
        {
            get
            {
                return _sequenceNum;
            }
            set
            {
                _sequenceNum = value;
            }
        }

        private bool _IsActive { get; set; }
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                _IsActive = value;
            }
        }

        #region Constructors

        public ApplicationActionList() : base() { }
        public ApplicationActionList(Session session) : base(session) { }

        #endregion


    }
}
