using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public class Campaigns : XPLiteObject
    {
        private Int64 _CampaignId;
        [Key(AutoGenerate = false)]
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

        private string _Name;
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

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetPropertyValue("Description", ref _Description, value);
            }
        }

        private Int64 _EvolutionProductId;
        public Int64 EvolutionProductId
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

        private Int64? _InstantRewardId;
        public Int64? InstantRewardId
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

        private string _EvolutionEventName;
        public string EvolutionEventName
        {
            get
            {
                return _EvolutionEventName;
            }
            set
            {
                SetPropertyValue("EvolutionEventName", ref _EvolutionEventName, value);
            }
        }

        private decimal? _MinLoanAmount;
        public decimal? MinLoanAmount
        {
            get
            {
                return _MinLoanAmount;
            }
            set
            {
                SetPropertyValue("MinLoanAmount", ref _MinLoanAmount, value);
            }
        }

        private Int64 _DistributionListId;
        public Int64 DistributionListId
        {
            get
            {
                return _DistributionListId;
            }
            set
            {
                SetPropertyValue("DistributionListId", ref _DistributionListId, value);
            }
        }

        private bool _IsEnable;
        public bool IsEnable
        {
            get
            {
                return _IsEnable;
            }
            set
            {
                SetPropertyValue("IsEnable", ref _IsEnable, value);
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


        #region Constructors

        public Campaigns() : base() { }
        public Campaigns(Session session) : base(session)
        {

        }

        #endregion

    }
}
