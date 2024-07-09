using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CampaignManager
{
    public class ReferAndEarnView
    {
        #region Constructors
        public ReferAndEarnView() { }
        #endregion

        public Int64 ApplicationId { get; set; }

        public Int64 ApplicationClientId { get; set; }

        public string Client_IDNumber { get; set; }

        public string Customer_Name { get; set; }

        public string CampaignCode { get; set; }

        public string Referral_Code { get; set; }

        public string Referral_Name { get; set; }

        public string Referral_IDNumber { get; set; }
        
        public DateTime LoanDate { get; set; }

        public DateTime Application_CreatedDate { get; set; }

        public decimal LoanAmount { get; set; }

        public decimal RewardAmount { get; set; }

        public string AgentCode { get; set; }

        public string Agent_Name { get; set; }
    }
}
