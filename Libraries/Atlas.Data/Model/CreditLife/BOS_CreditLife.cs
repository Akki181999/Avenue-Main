using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.CreditLife
{
    public sealed class BOS_CreditLife:XPLiteObject
    {
        private int _CompanyId;

        [Key(AutoGenerate =true)]
        public int CompanyId
        {
            get { return _CompanyId; }
            set { SetPropertyValue("Id", ref _CompanyId, value); }
        }

        private string _Company;
        [Persistent]
        public string Company
        {
            get { return _Company; }
            set {SetPropertyValue("Company",ref _Company ,value); }
        }

        private decimal? _CreditProtectionRatePM;
        [Persistent]
        public decimal? CreditProtectionRatePM
        {
            get { return _CreditProtectionRatePM; }
            set {SetPropertyValue("CreditProtectionRatePM",ref _CreditProtectionRatePM, value); }
        }

        private string _PhoneNo;

        public string PhoneNo
        {
            get { return _PhoneNo; }
            set { SetPropertyValue("PhoneNo",ref _PhoneNo, value); }
        }

        private string _Fax;

        public string Fax
        {
            get { return _Fax; }
            set { SetPropertyValue("Fax", ref _Fax, value); }
        }

        private string _CompanyAddress;

        public string CompanyAddress
        {
            get { return _CompanyAddress; }
            set { SetPropertyValue("CompanyAddress", ref _CompanyAddress, value); }
        }


        #region Constructors

        public BOS_CreditLife() : base() { }
        public BOS_CreditLife(Session session) : base(session) { }

        #endregion
    }
}
