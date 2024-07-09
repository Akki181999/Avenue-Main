using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_InsuranceType : XPLiteObject
    {
        private Int32 _InsuranceTypeId;   
        [Key]
        [Persistent]
        public Int32 InsuranceTypeId { get; set; }
      
        private String _InsuranceTypeName;
        [Persistent]
        public string InsuranceTypeName
        {
            get;

            set;
           
        }

        #region Constructors

        public INS_InsuranceType() : base() { }
        public INS_InsuranceType(Session session) : base(session) { }

        #endregion
    }
}
