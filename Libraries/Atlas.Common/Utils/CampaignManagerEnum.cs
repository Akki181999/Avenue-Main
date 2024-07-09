using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Common.Utils
{
    public class CampaignManagerEnum
    {
        public enum EvolutionEvent
        {
            [Description("Manager Approval")]
            Manager_Approval = 4,
            [Description("Transfer Funds")]
            Transfer_Funds = 5,
            [Description("Loan Cancel")]
            Loan_Cancel = 6,
            [Description("Transfer Funds - Load Nucard")]
            Transfer_Funds_Nucard = 7,
            //Referrer
            [Description("Transfer Funds - Referrer")]
            Transfer_Funds_Referrer = 8
        }

        public enum CampaignCategory
        {
            NOTIFICATION,
            SENTVOUCHER,
            LOADREWARDAMOUNT,
            CAMPAIGN_ELLIGIBILITY_CHECKER,
            REFERRAL_ELLIGIBILITY_CHECKER
        }

        public enum Placeholders
        {
            [Description("{loan_amount}")]
            loan_amount,
            [Description("{contact_number}")]
            contact_number,
            [Description("{installment_amount}")]
            installment_amount,
            [Description("{due_date}")]
            due_date,
            [Description("{reward_amount}")]
            reward_amount,
            [Description("{firstname}")]
            firstname,
            [Description("{lastname}")]
            lastname,
            [Description("{application_no}")]
            application_no,
            [Description("{loan_account_no}")]
            loan_account_no,
            [Description("{loan_open_date}")]
            loan_open_date,
            [Description("{client_id}")]
            client_id
        }

        public enum PlaceholdersReferrals
        {
            [Description("{loan_amount_referrer}")]
            loan_amount_referrer,
            [Description("{contact_number_referrer}")]
            contact_number_referrer,
            [Description("{installment_amount_referrer}")]
            installment_amount_referrer,
            [Description("{due_date_referrer}")]
            due_date_referrer,
            [Description("{reward_amount_referrer}")]
            reward_amount_referrer,
            [Description("{firstname_referrer}")]
            firstname_referrer,
            [Description("{lastname_referrer}")]
            lastname_referrer,
            [Description("{application_no_referrer}")]
            application_no_referrer,
            [Description("{loan_account_no_referrer}")]
            loan_account_no_referrer,
            [Description("{loan_open_date_referrer}")]
            loan_open_date_referrer,
            [Description("{client_id_referrer}")]
            client_id_referrer
        }

        public enum SendNotificationTo
        {
            REWARD,
            CAMPAIGN
        }
    }
}
