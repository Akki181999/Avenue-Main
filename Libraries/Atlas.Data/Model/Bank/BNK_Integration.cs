using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Bank
{
    public class BNK_Integration : XPLiteObject
    {
        private Int64 _bankId;
        [Key]
        public Int64 BankId
        {
            get
            {
                return _bankId;
            }
            set
            {
                SetPropertyValue("BankId", ref _bankId, value);
            }
        }



        private int _realPayBankId;
        [Persistent, Size(50)]
        public int RealPayBankId
        {
            get
            {
                return _realPayBankId;
            }
            set
            {
                SetPropertyValue("RealPayBankId", ref _realPayBankId, value);
            }
        }

        private string _realPayBankCode;
        [Persistent, Size(20)]
        public string RealPayBankCode
        {
            get
            {
                return _realPayBankCode;
            }
            set
            {
                SetPropertyValue("RealPayBankCode", ref _realPayBankCode, value);
            }
        }

        private int _truIDBankId;
        [Persistent, Size(10)]
        public int TruIDBankId
        {
            get
            {
                return _truIDBankId;
            }
            set
            {
                SetPropertyValue("TruIDBankId", ref _truIDBankId, value);
            }
        }
        private string _truIDBankCode;
        [Persistent, Size(20)]
        [Indexed(Name = "TruIDBankCode")]
        public string TruIDBankCode
        {
            get
            {
                return _truIDBankCode;
            }
            set
            {
                SetPropertyValue("TruIDBankCode", ref _truIDBankCode, value);
            }
        }
        #region Constructors

        public BNK_Integration() : base() { }
        public BNK_Integration(Session session) : base(session) { }

        #endregion
    }

}