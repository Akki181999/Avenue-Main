using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_Collection_Naedo : XPCustomObject
    {

        private Int64 _CollectionId;
        [Key(AutoGenerate = true)]
        public Int64 CollectionId
        {
            get
            {
                return _CollectionId;
            }
            set
            {
                SetPropertyValue("CollectionId", ref _CollectionId, value);
            }
        }

        private int _ReportType;
        public int ReportType
        {
            get
            {
                return _ReportType;
            }
            set
            {
                SetPropertyValue("ReportType", ref _ReportType, value);
            }
        }

        private string _TranID;
        public string TranID
        {
            get
            {
                return _TranID;
            }
            set
            {
                SetPropertyValue("TranID", ref _TranID, value);
            }
        }

        private string _TTypeID;
        public string TTypeID
        {
            get
            {
                return _TTypeID;
            }
            set
            {
                SetPropertyValue("TTypeID", ref _TTypeID, value);
            }
        }

        private string _MerchantID;
        public string MerchantID
        {
            get
            {
                return _MerchantID;
            }
            set
            {
                SetPropertyValue("MerchantID", ref _MerchantID, value);
            }
        }


        private DateTime? _ActionDate;
        public DateTime? ActionDate
        {
            get
            {
                return _ActionDate;
            }
            set
            {
                SetPropertyValue("ActionDate", ref _ActionDate, value);
            }
        }

        private DateTime? _ProcessDate;
        public DateTime? ProcessDate
        {
            get
            {
                return _ProcessDate;
            }
            set
            {
                SetPropertyValue("ProcessDate", ref _ProcessDate, value);
            }
        }

        private string _ClientRef1;
        public string ClientRef1
        {
            get
            {
                return _ClientRef1;
            }
            set
            {
                SetPropertyValue("ClientRef1", ref _ClientRef1, value);
            }
        }

        private string _ClientRef2;
        public string ClientRef2
        {
            get
            {
                return _ClientRef2;
            }
            set
            {
                SetPropertyValue("ClientRef2", ref _ClientRef2, value);
            }
        }

        private string _HomingAccNo;
        public string HomingAccNo
        {
            get
            {
                return _HomingAccNo;
            }
            set
            {
                SetPropertyValue("HomingAccNo", ref _HomingAccNo, value);
            }
        }

        private string _HomingBranch;
        public string HomingBranch
        {
            get
            {
                return _HomingBranch;
            }
            set
            {
                SetPropertyValue("HomingBranch", ref _HomingBranch, value);
            }
        }

        private int? _AccType;
        public int? AccType
        {
            get
            {
                return _AccType;
            }
            set
            {
                SetPropertyValue("AccType", ref _AccType, value);
            }
        }

        private int _Installment;
        public int Installment
        {
            get
            {
                return _Installment;
            }
            set
            {
                SetPropertyValue("Installment", ref _Installment, value);
            }
        }

        private decimal _Amount;
        public decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                SetPropertyValue("Amount", ref _Amount, value);
            }
        }

        private int? _NoInstalments;
        public int? NoInstalments
        {
            get
            {
                return _NoInstalments;
            }
            set
            {
                SetPropertyValue("NoInstalments", ref _NoInstalments, value);
            }
        }

        private string _RCode;
        public string RCode
        {
            get
            {
                return _RCode;
            }
            set
            {
                SetPropertyValue("RCode", ref _RCode, value);
            }
        }

        private string _QCode;
        public string QCode
        {
            get
            {
                return _QCode;
            }
            set
            {
                SetPropertyValue("QCode", ref _QCode, value);
            }
        }

        private string _ErrorMsg;
        public string ErrorMsg
        {
            get
            {
                return _ErrorMsg;
            }
            set
            {
                SetPropertyValue("ErrorMsg", ref _ErrorMsg, value);
            }
        }

        private Boolean _ProcessStatus;
        public Boolean ProcessStatus
        {
            get
            {
                return _ProcessStatus;
            }
            set
            {
                SetPropertyValue("ProcessStatus", ref _ProcessStatus, value);
            }
        }

        #region Constructors

        public BOS_Collection_Naedo() : base() { }
        public BOS_Collection_Naedo(Session session) : base(session) { }

        #endregion
    }
}
