using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public class CampaignRewards : XPLiteObject
    {
        private Int64 _InstantRewardId;
        [Key(AutoGenerate = false)]
        public Int64 InstantRewardId
        {
            get
            {
                return _InstantRewardId;
            }
            set
            {
                SetPropertyValue("InstantRewardId", ref _InstantRewardId, value);
            }
        }

        private Int64 _CampaignId;
        public Int64 CampaignId
        {
            get
            {
                return _CampaignId;
            }
            set
            {
                SetPropertyValue("CampaignId", ref _CampaignId, value);
            }
        }

        private string _RewardType;
        public string RewardType
        {
            get
            {
                return _RewardType;
            }
            set
            {
                SetPropertyValue("RewardType", ref _RewardType, value);
            }
        }

        private string _RewardName;
        public string RewardName
        {
            get
            {
                return _RewardName;
            }
            set
            {
                SetPropertyValue("RewardName", ref _RewardName, value);
            }
        }

        private string _RewardDescription;
        public string RewardDescription
        {
            get
            {
                return _RewardDescription;
            }
            set
            {
                SetPropertyValue("RewardDescription", ref _RewardDescription, value);
            }
        }

        private decimal? _Amount;
        public decimal? Amount
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

        private DateTime _ValidFrom;
        public DateTime ValidFrom
        {
            get
            {
                return _ValidFrom;
            }
            set
            {
                SetPropertyValue("ValidFrom", ref _ValidFrom, value);
            }
        }

        private DateTime? _ValidTill;
        public DateTime? ValidTill
        {
            get
            {
                return _ValidTill;
            }
            set
            {
                SetPropertyValue("ValidTill", ref _ValidTill, value);
            }
        }

        private Int64 _PayoutModeId;
        public Int64 PayoutModeId
        {
            get
            {
                return _PayoutModeId;
            }
            set
            {
                SetPropertyValue("PayoutModeId", ref _PayoutModeId, value);
            }
        }

        private string _PayoutMode;
        public string PayoutMode
        {
            get
            {
                return _PayoutMode;
            }
            set
            {
                SetPropertyValue("PayoutMode", ref _PayoutMode, value);
            }
        }

        private Int64 _CreatedBy;
        public Int64 CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                SetPropertyValue("CreatedBy", ref _CreatedBy, value);
            }
        }

        private DateTime _CreatedDate;
        public DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                SetPropertyValue("CreatedDate", ref _CreatedDate, value);
            }
        }

        private Int64? _ThirdPartyVoucherId;
        public Int64? ThirdPartyVoucherId
        {
            get
            {
                return _ThirdPartyVoucherId;
            }
            set
            {
                SetPropertyValue("ThirdPartyVoucherId", ref _ThirdPartyVoucherId, value);
            }
        }

        private bool? _IsAmountInPerc;
        public bool? IsAmountInPerc
        {
            get
            {
                return _IsAmountInPerc;
            }
            set
            {
                SetPropertyValue("IsAmountInPerc", ref _IsAmountInPerc, value);
            }
        }


        #region Constructors
        public CampaignRewards() : base() { }
        public CampaignRewards(Session session) : base(session) { }
        #endregion
    }
}
