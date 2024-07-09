using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Quotation
{
    public class NewQuotationBreakup : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public int ID { get; set; }
        public int QUOTATIONID { get; set; }
        public decimal LOANAMOUNT { get; set; }
        public decimal INITFEE { get; set; }
        public decimal INITFEEVAT { get; set; }
        public decimal SERVFEE { get; set; }
        public decimal SERVFEEVAT { get; set; }
        public decimal INSPREMIUM { get; set; }
        public decimal INTEREST { get; set; }
        public decimal VAPSALE { get; set; }
        public decimal VAPFUNERAL { get; set; }
        public decimal VAPVAT { get; set; }
        public decimal VAPCOST { get; set; }
        public decimal VAPCOSTVAT { get; set; }
        public decimal VAPFUNCOST { get; set; }
        public decimal BASESERVICEFEE { get; set; }
        public decimal BASEVATRATE { get; set; }
        public decimal BASEINTRESTRATE { get; set; }
        public string FOR_INITIATIONFEE { get; set; }
        public int NUMOFINSTALLMENT { get; set; }
        public string PAYFREQ { get; set; }
        public int APPLICATIONID { get; set; }
        public decimal repaymentamount { get; set; }

        public NewQuotationBreakup() : base() { }
        public NewQuotationBreakup(Session session) : base(session) { }

    }
}
