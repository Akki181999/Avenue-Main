using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public sealed class DebiCheckMandate : XPLiteObject
    {

        private long _debiCheckMandateId;
        [Key(AutoGenerate = true)]
        [Persistent("DebiCheckMandateId")]
        public long DebiCheckMandateId
        {
            get
            {
                return _debiCheckMandateId;
            }
            set
            {
                SetPropertyValue("DebiCheckMandateId", ref _debiCheckMandateId, value);
            }
        }

        private long _applicationId;
        [Persistent("ApplicationId")]
        public long ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _applicationId, value);
            }
        }

        private string _mandateType;
        [Persistent("MandateType")]
        public string MandateType
        {
            get
            {
                return _mandateType;
            }
            set
            {
                SetPropertyValue("MandateType", ref _mandateType, value);
            }
        }
        private string _transactionType;
        [Persistent("TransactionType")]
        public string TransactionType
        {
            get
            {
                return _transactionType;
            }
            set
            {
                SetPropertyValue("TransactionType", ref _transactionType, value);
            }
        }
        private string _mandateActionDate;
        [Persistent("MandateActionDate")]
        public string MandateActionDate
        {
            get
            {
                return _mandateActionDate;
            }
            set
            {
                SetPropertyValue("MandateActionDate", ref _mandateActionDate, value);
            }
        }
        private string _frequencyCode;
        [Persistent("FrequencyCode")]
        public string FrequencyCode
        {
            get
            {
                return _frequencyCode;
            }
            set
            {
                SetPropertyValue("FrequencyCode", ref _frequencyCode, value);
            }
        }
        private int _collectionDay;
        [Persistent("CollectionDay")]
        public int CollectionDay
        {
            get
            {
                return _collectionDay;
            }
            set
            {
                SetPropertyValue("CollectionDay", ref _collectionDay, value);
            }
        }
        private string _debitSequenceType;
        [Persistent("DebitSequenceType")]
        public string DebitSequenceType
        {
            get
            {
                return _debitSequenceType;
            }
            set
            {
                SetPropertyValue("DebitSequenceType", ref _debitSequenceType, value);
            }
        }
        private string _adjustmentCategory;
        [Persistent("AdjustmentCategory")]
        public string AdjustmentCategory
        {
            get
            {
                return _adjustmentCategory;
            }
            set
            {
                SetPropertyValue("AdjustmentCategory", ref _adjustmentCategory, value);
            }
        }
        private double _adjustmentAmount;
        [Persistent("AdjustmentAmount")]
        public double AdjustmentAmount
        {
            get
            {
                return _adjustmentAmount;
            }
            set
            {
                SetPropertyValue("AdjustmentAmount", ref _adjustmentAmount, value);
            }
        }
        private string _adjustmentRate;
        [Persistent("AdjustmentRate")]
        public string AdjustmentRate
        {
            get
            {
                return _adjustmentRate;
            }
            set
            {
                SetPropertyValue("AdjustmentRate", ref _adjustmentRate, value);
            }
        }
        private string _trackingYN;
        [Persistent("TrackingYN")]
        public string TrackingYN
        {
            get
            {
                return _trackingYN;
            }
            set
            {
                SetPropertyValue("TrackingYN", ref _trackingYN, value);
            }
        }
        private string _trackingCode;
        [Persistent("TrackingCode")]
        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }
            set
            {
                SetPropertyValue("TrackingCode", ref _trackingCode, value);
            }
        }
        private string _clientNumber;
        [Persistent("ClientNumber")]
        public string ClientNumber
        {
            get
            {
                return _clientNumber;
            }
            set
            {
                SetPropertyValue("ClientNumber", ref _clientNumber, value);
            }
        }
        private string _contractNumber;
        [Persistent("ContractNumber")]
        public string ContractNumber
        {
            get
            {
                return _contractNumber;
            }
            set
            {
                SetPropertyValue("ContractNumber", ref _contractNumber, value);
            }
        }
        private string _firstCollectionDate;
        [Persistent("FirstCollectionDate")]
        public string FirstCollectionDate
        {
            get
            {
                return _firstCollectionDate;
            }
            set
            {
                SetPropertyValue("FirstCollectionDate", ref _firstCollectionDate, value);
            }
        }
        private double _firstCollectionAmount;
        [Persistent("FirstCollectionAmount")]
        public double FirstCollectionAmount
        {
            get
            {
                return _firstCollectionAmount;
            }
            set
            {
                SetPropertyValue("FirstCollectionAmount", ref _firstCollectionAmount, value);
            }
        }
        private string _instalmentStartDate;
        [Persistent("InstalmentStartDate")]
        public string InstalmentStartDate
        {
            get
            {
                return _instalmentStartDate;
            }
            set
            {
                SetPropertyValue("InstalmentStartDate", ref _instalmentStartDate, value);
            }
        }
        private double _instalmentAmount;
        [Persistent("InstalmentAmount")]
        public double InstalmentAmount
        {
            get
            {
                return _instalmentAmount;
            }
            set
            {
                SetPropertyValue("InstalmentAmount", ref _instalmentAmount, value);
            }
        }
        private double _maximumAmount;
        [Persistent("MaximumAmount")]
        public double MaximumAmount
        {
            get
            {
                return _maximumAmount;
            }
            set
            {
                SetPropertyValue("MaximumAmount", ref _maximumAmount, value);
            }
        }
        private int _numberOfInstalments;
        [Persistent("NumberOfInstalments")]
        public int NumberOfInstalments
        {
            get
            {
                return _numberOfInstalments;
            }
            set
            {
                SetPropertyValue("NumberOfInstalments", ref _numberOfInstalments, value);
            }
        }
        private long _contractSequence;
        [Persistent("ContractSequence")]
        public long ContractSequence
        {
            get
            {
                return _contractSequence;
            }
            set
            {
                SetPropertyValue("ContractSequence", ref _contractSequence, value);
            }
        }
        private string _status;
        [Persistent("Status")]
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                SetPropertyValue("Status", ref _status, value);
            }
        }
        private DateTime _createDate;
        [Persistent("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                SetPropertyValue("CreateDate", ref _createDate, value);
            }
        }

        private string _description;
        [Persistent("Description")]
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

        private string _response;
        [Persistent("Response")]
        public string Response
        {
            get
            {
                return _response;
            }
            set
            {
                SetPropertyValue("Response", ref _response, value);
            }
        }

        private int _branchId;
        [Persistent("BranchId")]
        public int BranchId
        {
            get
            {
                return _branchId;
            }
            set
            {
                SetPropertyValue("BranchId", ref _branchId, value);
            }
        }

        private long _accountId;
        [Persistent("AccountId")]
        public long AccountId
        {
            get
            {
                return _accountId;
            }
            set
            {
                SetPropertyValue("AccountId", ref _accountId, value);
            }
        }

        private string _transactionId;
        [Persistent("TransactionId")]
        public string TransactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                SetPropertyValue("TransactionId", ref _transactionId, value);
            }
        }

        private string _mandateId;
        [Persistent("MandateId")]
        public string MandateId
        {
            get
            {
                return _mandateId;
            }
            set
            {
                SetPropertyValue("MandateId", ref _mandateId, value);
            }
        }

        private string _request;
        [Persistent("Request")]
        public string Request
        {
            get
            {
                return _request;
            }
            set
            {
                SetPropertyValue("Request", ref _request, value);
            }
        }

        private char? _LoanType;
        [Persistent("LoanType")]
        public char? LoanType
        {
            get
            {
                return _LoanType;
            }
            set
            {
                SetPropertyValue("LoanType", ref _LoanType, value);
            }
        }

        private Boolean _IsAdhoc;
        [Persistent("IsAdhoc")]
        public Boolean IsAdhoc
        {
            get
            {
                return _IsAdhoc;
            }
            set
            {
                SetPropertyValue("IsAdhoc", ref _IsAdhoc, value);
            }
        }

        private string _thirdpartystatus;
        [Persistent("Thirdpartystatus")]
        public string thirdpartystatus
        {
            get
            {
            
                return _thirdpartystatus;
            }
            set
            {
                SetPropertyValue("Thirdpartystatus", ref _thirdpartystatus, value);
            }
        }

        #region Constructors

        public DebiCheckMandate() : base() { }
        public DebiCheckMandate(Session session) : base(session) { }

        #endregion
    }
}
