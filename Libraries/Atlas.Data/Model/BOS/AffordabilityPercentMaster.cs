using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
    public sealed class AffordabilityPercentMaster : XPCustomObject
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

        private Int32 _AffordabilityPercent;

        public Int32 AffordabilityPercent
        {
            get
            {
                return _AffordabilityPercent;
            }
            set
            {
                SetPropertyValue("AffordabilityPercent", ref _AffordabilityPercent, value);
            }
        }

        #region Constructors

        public AffordabilityPercentMaster() : base() { }
        public AffordabilityPercentMaster(Session session) : base(session) { }

        #endregion
    }
}
