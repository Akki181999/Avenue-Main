using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class IDLPDiscount:XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 IDLPDiscountId { get; set; }
        [Persistent]
        public Int64 AccountId { get; set; }
        [Persistent]
        public string RequestEvent { get; set; }
        [Persistent]
        public Int16 IDLPDiscountType { get; set; }
        [Persistent]
        public Int16 AdditionalServiceFeeDiscountType { get; set; }
        [Persistent]
        public decimal? IDLPDiscountValue { get; set; }
        [Persistent]
        public decimal? AdditionalServiceFeeDiscountValue { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public DateTime? UpdatedDate { get; set; }
        [Persistent]
        public Int64 IntCreatedBy { get; set; }
        [Persistent]
        public Int64? IntUpdatedBy { get; set; }
        [Persistent]
        public Int64 StatusId  { get; set; }
        [Persistent]
        public string ReasonCode { get; set; }

        #region Constructors
        public IDLPDiscount() : base() { }
        public IDLPDiscount(Session session) : base(session) { }
        #endregion

    }
}
