using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public class ApplicationCampaignMapping : XPLiteObject
    {
        private Int64 _ApplicationCampaignMappingId;
        [Key(AutoGenerate = true)]
        public Int64 ApplicationCampaignMappingId
        {
            get
            {
                return _ApplicationCampaignMappingId;
            }
            set
            {
                SetPropertyValue("ApplicationCampaignMappingId", ref _ApplicationCampaignMappingId, value);
            }
        }

        private Int64 _ApplicationId;
        public Int64 ApplicationId
        {
            get
            {
                return _ApplicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _ApplicationId, value);
            }
        }

        private Int64 _InstantRewardId;
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

        private Int64? _AccountId;
        public Int64? AccountId
        {
            get
            {
                return _AccountId;
            }
            set
            {
                SetPropertyValue("AccountId", ref _AccountId, value);
            }
        }


        private string _CampaignCode;
        public string CampaignCode
        {
            get
            {
                return _CampaignCode;
            }
            set
            {
                SetPropertyValue("CampaignCode", ref _CampaignCode, value);
            }
        }

        private string _ReferralCode;
        public string ReferralCode
        {
            get
            {
                return _ReferralCode;
            }
            set
            {
                SetPropertyValue("ReferralCode", ref _ReferralCode, value);
            }
        }

        private Int64? _BranchId;
        public Int64? BranchId
        {
            get
            {
                return _BranchId;
            }
            set
            {
                SetPropertyValue("BranchId", ref _BranchId, value);
            }
        }

        private Int64? _EvolutionProductId;
        public Int64? EvolutionProductId
        {
            get
            {
                return _EvolutionProductId;
            }
            set
            {
                SetPropertyValue("EvolutionProductId", ref _EvolutionProductId, value);
            }
        }

        private string _NationalId;
        public string NationalId
        {
            get
            {
                return _NationalId;
            }
            set
            {
                SetPropertyValue("NationalId", ref _NationalId, value);
            }
        }

        private Int64? _ChannelId;
        public Int64? ChannelId
        {
            get
            {
                return _ChannelId;
            }
            set
            {
                SetPropertyValue("ChannelId", ref _ChannelId, value);
            }
        }

        private DateTime? _CheckDate;
        public DateTime? CheckDate
        {
            get
            {
                return _CheckDate;
            }
            set
            {
                SetPropertyValue("CheckDate", ref _CheckDate, value);
            }
        }

        private Int64? _CreatedBy;
        public Int64? CreatedBy
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

        private DateTime? _CreatedDate;
        public DateTime? CreatedDate
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

        private Int64? _UpdateBy;
        public Int64? UpdateBy
        {
            get
            {
                return _UpdateBy;
            }
            set
            {
                SetPropertyValue("UpdateBy", ref _UpdateBy, value);
            }
        }

        private DateTime? _UpdatedDate;
        public DateTime? UpdatedDate
        {
            get
            {
                return _UpdatedDate;
            }
            set
            {
                SetPropertyValue("UpdatedDate", ref _UpdatedDate, value);
            }
        }


        #region Constructors

        public ApplicationCampaignMapping() : base() { }
        public ApplicationCampaignMapping(Session session) : base(session)
        {

        }

        #endregion
    }
}
