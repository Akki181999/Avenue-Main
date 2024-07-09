using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.AncillaryProduct
{
    public class PRD_AncillaryProduct : XPLiteObject
    {
        private long _ancillaryProductId;
        [Key]
        public long AncillaryProductId
        {
            get
            {
                return _ancillaryProductId;
            }
            set
            {
                SetPropertyValue("AncillaryProductId", ref _ancillaryProductId, value);
            }
        }

        private string _productName;
        [Persistent, Size(100)]
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                SetPropertyValue("ProductName", ref _productName, value);
            }
        }

        #region Constructors

        public PRD_AncillaryProduct() : base() { }
        public PRD_AncillaryProduct(Session session) : base(session) { }

        #endregion
    }
}
