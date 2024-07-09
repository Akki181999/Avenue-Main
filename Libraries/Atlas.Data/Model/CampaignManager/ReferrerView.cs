using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CampaignManager
{
    public class ReferrerView
    {
        #region Constructors
        public ReferrerView() { }
        #endregion

        public string ReferralCode { get; set; }
        public string CustomerName { get; set; }
        public string IDNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
