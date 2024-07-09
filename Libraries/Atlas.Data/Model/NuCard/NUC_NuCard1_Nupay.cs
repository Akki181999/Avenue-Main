using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.NuCard
{
    public class NUC_NuCard1_Nupay : XPCustomObject
    {
        private string _SequenceNum;
        [Key(AutoGenerate = false)]
        public string SequenceNum
        {
            get { return _SequenceNum; }
            set { SetPropertyValue("SequenceNum", ref _SequenceNum, value); }
        }

        private string _TrackingNum;
        public string TrackingNum
        {
            get { return _TrackingNum; }
            set { SetPropertyValue("TrackingNum", ref _TrackingNum, value); }
        }

        private string _CardNum;
        public string CardNum
        {
            get { return _CardNum; }
            set { SetPropertyValue("CardNum", ref _CardNum, value); }
        }

        private string _Source;
        public string Source
        {
            get { return _Source; }
            set { SetPropertyValue("Source", ref _Source, value); }
        }

        private DateTime _ExpiryDT;
        public DateTime ExpiryDT
        {
            get { return _ExpiryDT; }
            set { SetPropertyValue("ExpiryDT", ref _ExpiryDT, value); }
        }

        #region Constructors

        public NUC_NuCard1_Nupay() : base() { }
        public NUC_NuCard1_Nupay(Session session) : base(session) { }

        #endregion
    }
}
