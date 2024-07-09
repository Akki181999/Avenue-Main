using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_Collection_Aedo : XPCustomObject
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

        private string _TransactionId;
        public string TransactionId
        {
            get
            {
                return _TransactionId;
            }
            set
            {
                SetPropertyValue("TransactionId", ref _TransactionId, value);
            }
        }


        private DateTime? _ValueDate;
        public DateTime? ValueDate
        {
            get
            {
                return _ValueDate;
            }
            set
            {
                SetPropertyValue("ValueDate", ref _ValueDate, value);
            }
        }

        private string _ContractNo;
        public string ContractNo
        {
            get
            {
                return _ContractNo;
            }
            set
            {
                SetPropertyValue("ContractNo", ref _ContractNo, value);
            }
        }

        private string _TermId;
        public string TermId
        {
            get
            {
                return _TermId;
            }
            set
            {
                SetPropertyValue("TermId", ref _TermId, value);
            }
        }

        private DateTime? _ActualDate;
        public DateTime? ActualDate
        {
            get
            {
                return _ActualDate;
            }
            set
            {
                SetPropertyValue("ActualDate", ref _ActualDate, value);
            }
        }

        private int? _RetryCount;
        public int? RetryCount
        {
            get
            {
                return _RetryCount;
            }
            set
            {
                SetPropertyValue("RetryCount", ref _RetryCount, value);
            }
        }

        private string _Reason;
        public string Reason
        {
            get
            {
                return _Reason;
            }
            set
            {
                SetPropertyValue("Reason", ref _Reason, value);
            }
        }

        private decimal? _ContactAmt;
        public decimal? ContactAmt
        {
            get
            {
                return _ContactAmt;
            }
            set
            {
                SetPropertyValue("ContactAmt", ref _ContactAmt, value);
            }
        }

        private string _Pan;
        public string Pan
        {
            get
            {
                return _Pan;
            }
            set
            {
                SetPropertyValue("Pan", ref _Pan, value);
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

        private string _Mass;
        public string Mass
        {
            get
            {
                return _Mass;
            }
            set
            {
                SetPropertyValue("Mass", ref _Mass, value);
            }
        }

        private string _Type;
        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                SetPropertyValue("Type", ref _Type, value);
            }
        }

        private string _EmpNo;
        public string EmpNo
        {
            get
            {
                return _EmpNo;
            }
            set
            {
                SetPropertyValue("EmpNo", ref _EmpNo, value);
            }
        }

        private int? _OrigNoInstallment;
        public int? OrigNoInstallment
        {
            get
            {
                return _OrigNoInstallment;
            }
            set
            {
                SetPropertyValue("OrigNoInstallment", ref _OrigNoInstallment, value);
            }
        }

        private string _Future3;
        public string Future3
        {
            get
            {
                return _Future3;
            }
            set
            {
                SetPropertyValue("Future3", ref _Future3, value);
            }
        }

        private string _Future4;
        public string Future4
        {
            get
            {
                return _Future4;
            }
            set
            {
                SetPropertyValue("Future4", ref _Future4, value);
            }
        }

        private string _Future5;
        public string Future5
        {
            get
            {
                return _Future5;
            }
            set
            {
                SetPropertyValue("Future5", ref _Future5, value);
            }
        }

        private decimal? _OriginalLoanAmount;
        public decimal? OriginalLoanAmount
        {
            get
            {
                return _OriginalLoanAmount;
            }
            set
            {
                SetPropertyValue("OriginalLoanAmount", ref _OriginalLoanAmount, value);
            }
        }

        private string _SpfValue;
        public string SpfValue
        {
            get
            {
                return _SpfValue;
            }
            set
            {
                SetPropertyValue("SpfValue", ref _SpfValue, value);
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

        public BOS_Collection_Aedo() : base() { }
        public BOS_Collection_Aedo(Session session) : base(session) { }

        #endregion
    }
}
