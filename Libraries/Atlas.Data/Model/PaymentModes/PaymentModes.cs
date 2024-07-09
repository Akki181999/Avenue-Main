using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.PaymentModes
{
    public sealed class PaymentModes: XPLiteObject
    {
        [Key]
        [Persistent]
        public Int64 PaymentModeId { get; set; }

        [Persistent]
        public string  PaymentCode { get; set; }

        [Persistent]
        public string PaymentDescription { get; set; }

        [Persistent]
        public string Type { get; set; }

        [Persistent]
        public bool IsActive { get; set; }
        [Persistent]
        public bool IsFingerPrintAllowed { get; set; }
        [Persistent]
        public bool UseDisbursementMode { get; set; }

        [Persistent]
        public bool IsCancelLoanAllowed { get; set; }

        [Persistent]
        public bool IsCardNumberRequired { get; set; }


        [Persistent]
        public bool UseRefundMode { get; set; }

        #region Constructors

        public PaymentModes() : base() { }
        public PaymentModes(Session session) : base(session) { }

        #endregion
    }

    public class AccountPaymentModesMapping : XPLiteObject
    {
        [Key]
        [Persistent]
        public Int64 AccountPaymentModesMappingId { get; set; }

        [Persistent]
        public char LoanType { get; set; }

        [Persistent]
        public PaymentModes PaymentModeId { get; set; }

        [Persistent]
        public bool IsActive { get; set; }

        [Persistent]
        public int DisplayOrder { get; set; }

        public AccountPaymentModesMapping() : base() { }
        public AccountPaymentModesMapping(Session session) : base(session) { }
    }

    public sealed class PaymentModesValidation : XPLiteObject
    {
        [Key]
        [Persistent]
        public int PaymentModesValidationId { get; set; }
        [Persistent]
        public int PaymentModeId { get; set; }
        [Persistent]
        public int ValueDateValidation { get; set; }
        [Persistent]
        public bool IsActive { get; set; }

        #region Constructors

        public PaymentModesValidation() : base() { }
        public PaymentModesValidation(Session session) : base(session) { }

        #endregion
    }
}
