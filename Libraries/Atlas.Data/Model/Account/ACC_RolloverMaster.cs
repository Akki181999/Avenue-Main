using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public sealed class ACC_RolloverMaster : XPLiteObject
    {
        private int _RolloverId;
        [Key]
        public int RolloverId
        {
            get
            {
                return _RolloverId;
            }
            set
            {
                SetPropertyValue("RolloverId", ref _RolloverId, value);
            }
        }

        private string _Frequency;
        [Persistent, Size(20)]
        public string Frequency
        {
            get
            {
                return _Frequency;
            }
            set
            {
                SetPropertyValue("Frequency", ref _Frequency, value);
            }
        }

        private int _TotalNoOfInstallments;
        [Persistent]
        public int TotalNoOfInstallments
        {
            get
            {
                return _TotalNoOfInstallments;
            }
            set
            {
                SetPropertyValue("TotalNoOfInstallments", ref _TotalNoOfInstallments, value);
            }
        }
        private int _TobeSettledInstallments;
        [Persistent]
        public int TobeSettledInstallments
        {
            get
            {
                return _TobeSettledInstallments;
            }
            set
            {
                SetPropertyValue("TobeSettledInstallments", ref _TobeSettledInstallments, value);
            }
        }


   

        private int _ArrearInstallments;
        [Persistent]
        public int ArrearInstallments
        {
            get
            {
                return _ArrearInstallments;
            }
            set
            {
                SetPropertyValue("ArrearInstallments", ref _ArrearInstallments, value);
            }
        }

        public int CompanyId { get; set; }
        #region Constructors

        public ACC_RolloverMaster() : base() { }
        public ACC_RolloverMaster(Session session) : base(session) { }

        #endregion
    }
}