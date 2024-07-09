using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Branch
{
    public sealed class TCC_Branch: XPLiteObject
    {
        private Int32 _Id;
        [Key(AutoGenerate = true)]
        public Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                SetPropertyValue("Id", ref _Id, value);
            }
        }

        private int _BranchId;

        
        public int BranchId
        {
            get { return _BranchId; }
            set { SetPropertyValue("BranchId", ref _BranchId, value); }
        }

        private string _MerchantId;
        
        public string MerchantId
        {
            get
            { return _MerchantId; }
            set { SetPropertyValue("MerchantId", ref _MerchantId, value); }
        }
        private string _TerminalId;

        public string TerminalId
        {
            get
            { return _TerminalId; }
            set { SetPropertyValue("TerminalId", ref _TerminalId, value); }
        }
        private bool _IsDefault;
        public bool IsDefault
        {
            get
            { return _IsDefault; }
            set { SetPropertyValue("IsDefault", ref _IsDefault, value); }
        }

        private string _POSMerchant;
        public string POSMerchant
        {
            get
            { return _POSMerchant; }
            set { SetPropertyValue("POSMerchant", ref _POSMerchant, value); }
        }

        public TCC_Branch() : base() { }
        public TCC_Branch(Session session) : base(session) { }
    }
}
