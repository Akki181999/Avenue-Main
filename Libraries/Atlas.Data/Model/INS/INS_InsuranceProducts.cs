using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_InsuranceProducts : XPObject
    {
        private Int32 _InsuranceTypeId;        
        public Int32 InsuranceTypeId
        {
            get
            {
                return _InsuranceTypeId;
            }
            set
            {
                SetPropertyValue("InsuranceTypeId", ref _InsuranceTypeId, value);
            }
        }

        private String _Admin_id;
        public string Admin_id
        {
            get
            {
                return _Admin_id;
            }
            set
            {
                SetPropertyValue("Admin_id", ref _Admin_id, value);
            }
        }

        private String _InsurerName;
        public string InsurerName
        {
            get
            {
                return _InsurerName;
            }
            set
            {
                SetPropertyValue("InsurerName", ref _InsurerName, value);
            }
        }

        private String _Clientid;
        public string ClientId
        {
            get
            {
                return _Clientid;
            }
            set
            {
                SetPropertyValue("ClientId ", ref _Clientid, value);
            }
        }

        private String _Divisionid;
        public string Divisionid
        {
            get
            {
                return _Divisionid;
            }
            set
            {
                SetPropertyValue("Divisionid", ref _Divisionid, value);
            }
        }

        private String _Saleschannel;
        public string Saleschannel
        {
            get
            {
                return _Saleschannel;
            }
            set
            {
                SetPropertyValue("Saleschannel", ref _Saleschannel, value);
            }
        }

        private String _DeathIndicator;
        public string DeathIndicator
        {
            get
            {
                return _DeathIndicator;
            }
            set
            {
                SetPropertyValue("DeathIndicator", ref _DeathIndicator, value);
            }
        }

        private decimal _CommissionRate;
        public decimal CommissionRate
        {
            get
            {
                return _CommissionRate;
            }
            set
            {
                SetPropertyValue("CommissionRate", ref _CommissionRate, value);
            }
        }

        private decimal _AdminFee;
        public decimal AdminFee
        {
            get
            {
                return _AdminFee;
            }
            set
            {
                SetPropertyValue("AdminFee", ref _AdminFee, value);
            }
        }

        private decimal _OutsourceFee;
        public decimal OutsourceFee
        {
            get
            {
                return _OutsourceFee;
            }
            set
            {
                SetPropertyValue("OutsourceFee", ref _OutsourceFee, value);
            }
        }

        private decimal _MarketingFee;
        public decimal MarketingFee
        {
            get
            {
                return _MarketingFee;
            }
            set
            {
                SetPropertyValue("MarketingFee", ref _MarketingFee, value);
            }
        }

        private decimal _MgmntFee;
        public decimal MgmntFee
        {
            get
            {
                return _MgmntFee;
            }
            set
            {
                SetPropertyValue("MgmntFee", ref _MgmntFee, value);
            }
        }

        private decimal _ClaimsFee;
        public decimal ClaimsFee
        {
            get
            {
                return _ClaimsFee;
            }
            set
            {
                SetPropertyValue("ClaimsFee", ref _ClaimsFee, value);
            }
        }

        private string _SubSchemeName;
        public string SubSchemeName
        {
            get
            {
                return _SubSchemeName;
            }
            set
            {
                SetPropertyValue("SubSchemeName", ref _SubSchemeName, value);
            }
        }

        private decimal _PriceModel;
        public decimal PriceModel
        {
            get
            {
                return _PriceModel;
            }
            set
            {
                SetPropertyValue("PriceModel", ref _PriceModel, value);
            }
        }

        private char _ProductOption;
        public char ProductOption
        {
            get
            {
                return _ProductOption;
            }
            set
            {
                SetPropertyValue("ProductOption", ref _ProductOption, value);
            }
        }
    }
}
