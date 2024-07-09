using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atlas.Domain.Model.Account
{
   public sealed class BOS_AtlasCompanyData: XPLiteObject
    {
        private Int64 _CompanyId;
        [Key(AutoGenerate = true)]
        public Int64 CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            {
                SetPropertyValue("CompanyId", ref _CompanyId, value);
            }
        }

        private string _Type;
        
        public String Type
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

        private string _Credit_Provider;
       
        public string Credit_Provider
        {
            get
            {
                return _Credit_Provider;
            }
            set
            {
                SetPropertyValue("Credit_Provider", ref _Credit_Provider, value);
            }
        }

        private string _VAT_Registration_No;
        //[Persistent, Size(20)]
        public string VAT_Registration_No
        {
            get
            {
                return _VAT_Registration_No;
            }
            set
            {
                SetPropertyValue("VAT_Registration_No", ref _VAT_Registration_No, value);
            }
        }

        private string _NCR_Registration_No;
        [Persistent]
        public string NCR_Registration_No
        {
            get
            {
                return _NCR_Registration_No;
            }
            set
            {
                SetPropertyValue("NCR_Registration_No", ref _NCR_Registration_No, value);
            }
        }

        private string _Physical_Address;
        [Persistent]
        public string Physical_Address
        {
            get
            {
                return _Physical_Address;
            }
            set
            {
                SetPropertyValue("Physical_Address", ref _Physical_Address, value);
            }
        }
        private string _Credit_Provider_Address;
        [Persistent]
        public string Credit_Provider_Address
        {
            get
            {
                return _Credit_Provider_Address;
            }
            set
            {
                SetPropertyValue("Credit_Provider_Address", ref _Credit_Provider_Address, value);
            }
        }
        private string _Credit_Provider_ShopNo;
        [Persistent]
        public string Credit_Provider_ShopNo
        {
            get
            {
                return _Credit_Provider_ShopNo;
            }
            set
            {
                SetPropertyValue("Credit_Provider_ShopNo", ref _Credit_Provider_ShopNo, value);
            }
        }
        private string _Credit_Provider_Role;
        [Persistent]
        public string Credit_Provider_Role
        {
            get
            {
                return _Credit_Provider_Role;
            }
            set
            {
                SetPropertyValue("Credit_Provider_Role", ref _Credit_Provider_Role, value);
            }
        }
        private string _Email;
        [Persistent]
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                SetPropertyValue("Email", ref _Email, value);
            }
        }
        private string _BRN_Num;
        [Persistent]
        public string BRN_Num
        {
            get
            {
                return _BRN_Num;
            }
            set
            {
                SetPropertyValue("BRN_Num", ref _BRN_Num, value);
            }
        }
        private Int64? _Telephone_Number;
        [Persistent]
        public Int64    ? Telephone_Number
        {
            get
            {
                return _Telephone_Number;
            }
            set
            {
                SetPropertyValue("Telephone_Number", ref _Telephone_Number, value);
            }
        }

        private string _PostalAddress;
        [Persistent]
        public string PostalAddress
        {
            get
            {
                return _PostalAddress;
            }
            set
            {
                SetPropertyValue("PostalAddress", ref _PostalAddress, value);
            }   
        }


        private DateTime _CreatedDT;
        [Persistent]
        public DateTime CreatedDT
        {
            get
            {
                return _CreatedDT;
            }
            set
            {
                SetPropertyValue("CreatedDT", ref _CreatedDT, value);
            }
        }

        private DateTime _LastEditedDT;
        [Persistent]
        public DateTime LastEditedDT
        {
            get
            {
                return _LastEditedDT;
            }
            set
            {
                SetPropertyValue("LastEditedDT", ref _LastEditedDT, value);
            }
        }

        private Int64 _PrCompanyId;
        public Int64 PrCompanyId
        {
            get
            {
                return _PrCompanyId;
            }
            set
            {
                SetPropertyValue("PrCompanyId", ref _PrCompanyId, value);
            }
        }

        #region Constructors

        public BOS_AtlasCompanyData() : base() { }
        public BOS_AtlasCompanyData(Session session) : base(session) { }

        #endregion
    }
}
