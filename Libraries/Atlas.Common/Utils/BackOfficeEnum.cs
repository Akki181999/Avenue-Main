using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Atlas.Common.Utils
{
    public class BackOfficeEnum
    {
        public enum NewStatus
        {

            [Description("EDITED")]
            EDITED = 1,
            [Description("SUBMITTED")]
            SUBMITTED = 2,
            [Description("VERIFICATION")]
            VERIFICATION = 3,
            [Description("REJECTED")]
            REJECTED = 4,
            [Description("ACTIVE")]
            ACTIVE = 5,
            [Description("STATUS_AFD_CALCULATED")]
            STATUS_AFD_CALCULATED = 6,
            [Description("STATUS_QUOTATION_GENERATED")]
            STATUS_QUOTATION_GENERATED = 7,
            [Description("STATUS_CLIENT_FINGER_PRINT_CAPTURED")]
            STATUS_CLIENT_FINGER_PRINT_CAPTURED = 8,
            [Description("STATUS_QUOTATION_PRINTED")]
            STATUS_QUOTATION_PRINTED = 9,
            [Description("STATUS_QUOTATION_SUBMITTED")]
            STATUS_QUOTATION_SUBMITTED = 10,
            [Description("STATUS_CONSULTANT_FINGER_PRINT_CAPTURED")]
            STATUS_CONSULTANT_FINGER_PRINT_CAPTURED = 11,
            [Description("STATUS_BRANCH_MANAGER_FINGER_PRINT_CAPTURED")]
            STATUS_BRANCH_MANAGER_FINGER_PRINT_CAPTURED = 12,
            [Description("STATUS_DEBIT_ORDER_CREATED")]
            STATUS_DEBIT_ORDER_CREATED = 13,
            [Description("STATUS_NUCARD_LOADED")]
            STATUS_NUCARD_LOADED = 14,
            [Description("STATUS_DISBURSED")]
            STATUS_DISBURSED = 15,
            [Description("OPEN")]
            OPEN = 40,
            [Description("STATUS_CLOSED")]
            STATUS_CLOSED = 80,
            [Description("REPAYMENT_PROCESSED")]
            REPAYMENT_PROCESSED = 17,
            [Description("REPAYMENT_REVERSED")]
            REPAYMENT_REVERSED = 18,
            [Description("REPAYMENT_REFUNDED")]
            REPAYMENT_REFUNDED = 19,
            [Description("REPAYMENT_AWAITING")]
            REPAYMENT_AWAITING = 43,
            [Description("DISPUTED_REPAYMENT_REVERSED")]
            DISPUTED_REPAYMENT_REVERSED = 24,
            [Description("INSURANCE_CLAIMED")]
            INSURANCE_CLAIMED = 81,
            [Description("CLAIM_PROCESSED")]
            CLAIM_PROCESSED = 82,
            [Description("CLAIM_CANCELLED")]
            CLAIM_CANCELLED = 83,
            [Description("CLAIM_PAID")]
            CLAIM_PAID = 84,
            [Description("CLAIM_REJECTED")]
            CLAIM_REJECTED = 85,
            [Description("CLAIM_INITIATED")]
            CLAIM_INITIATED = 86,
            [Description("NUPAY_FILE_PROCESSED")]
            NUPAY_FILE_PROCESSED = 53,
            [Description("NUCARD_BATCH_TRANSFERRED")]
            NUCARD_BATCH_TRANSFERRED = 54,
            [Description("NUCARD_BATCH_ACCEPTED")]
            NUCARD_BATCH_ACCEPTED = 55,
            [Description("NUCARD_BATCH_REJECTED")]
            NUCARD_BATCH_REJECTED = 56,

            // Added for LoanCancel
            [Description("LOAN_CANCELLED")]
            LOAN_CANCELLED = 94,
            [Description("CL_REPAYMENT")]
            CL_REPAYMENT = 66,
            [Description("CL_PROCESS_REPAYMENT")]
            CL_PROCESS_REPAYMENT = 67,
            [Description("CL_CANCEL_DEBITORDER")]
            CL_CANCEL_DEBITORDER = 63,
            [Description("CL_DEBIT_NUCARD")]
            CL_DEBIT_NUCARD = 64,
            [Description("CL_VAP_REPAYMENT")]
            CL_VAP_REPAYMENT = 65,
            // till here - Added for LoanCancel

            [Description("WO_Repayment")]
            WriteOffRepaymentCreated = 96,
            [Description("WO_PROCESS_REPAYMENT")]
            WriteOffRepaymentProcessed = 97,
            [Description("DAYEND_SUBMITTED")]
            DAYEND_SUBMITTED = 103,
            [Description("DAYEND_APPROVED")]
            DAYEND_APPROVED = 104,
           
			[Description("PRE_APPLICATION")]
            PRE_APPLICATION = -1,

            [Description("CONTINUE_PRE_APPLICATION")]
            CONTINUE_PRE_APPLICATION = -2,

            [Description("UPDATED")]
            UPDATED = -3,
            [Description("AGREEMENT_SIGNED_DIGITALLY")]
            AGREEMENT_SIGNED_DIGITALLY = 50,
            [Description("AGREEMENT_SIGNED_MANAULLY")]
            AGREEMENT_SIGNED_MANAULLY = 51,
            [Description("STATUS_DISBURSEMENT_INITIATED")]
            STATUS_DISBURSEMENT_INITIATED = 98,
            [Description("STATUS_AUTO_DISBURSEMENT_INITIATED")]
            STATUS_AUTO_DISBURSEMENT_INITIATED = 99,
            [Description("STATUS_DEBIT_ORDER_APPROVED")]
            STATUS_DEBIT_ORDER_APPROVED = 101,
            [Description("STATUS_DEBIT_ORDER_REJECTED")]
            STATUS_DEBIT_ORDER_REJECTED = 102,
            [Description("CHANGE_BANKDETAIL")]
            CHANGE_BANKDETAIL = 105,
            [Description("SAVE_DISBURSEMENT")]
            SAVE_DISBURSEMENT = 174,
            [Description("NUCARD_DEBITORDER_CREATED")]
            NUCARD_DEBITORDER_CREATED = 175,
            [Description("STATUS_CONSULTANT_OTP_CAPTURED")]
            STATUS_CONSULTANT_OTP_CAPTURED = 165,
            [Description("STATUS_BRANCH_MANAGER_OTP_CAPTURED")]
            STATUS_BRANCH_MANAGER_OTP_CAPTURED = 166,
            [Description("CONSULTANT_VERIFICATION_DONE")]
            CONSULTANT_VERIFICATION_DONE = 176,
            [Description("MANAGER_VERIFICATION_DONE")]
            MANAGER_VERIFICATION_DONE = 177,
            [Description("INITIATE_DISBURSEMENT")]
            INITIATE_DISBURSEMENT = 167,
            [Description("NUCARD_ACCOUNT_CREATED")]
            NUCARD_ACCOUNT_CREATED = 168,
            [Description("ISSUE_NUCARD")]
            ISSUE_NUCARD = 169,
            [Description("LOAD_AMOUNT")]
            LOAD_AMOUNT = 170,
            [Description("CREATE_INSURANSE")]
            CREATE_INSURANSE = 171,
            [Description("STATUS_ROLLOVER_ACCOUNTS")]
            STATUS_ROLLOVER_ACCOUNTS = 172,
            [Description("STATUS_ACCOUNT_ACTIVE")]
            STATUS_ACCOUNT_ACTIVE = 173,
            [Description("STATUS_ACCEPTED")]
            STATUS_ACCEPTED = 110,
            [Description("STATUS_ABSA_FAILED")]
            STATUS_ABSA_FAILED = 111,
            [Description("SURPLUS_FAILED")]
            SURPLUS_FAILED = -11,
            [Description("APPROVED")]
            APPROVED = 180,
            [Description("APPLICATION_DEBITORDER_APPROVED")]
            APPLICATION_DEBITORDER_APPROVED = 178,
            [Description("VAPCANCEL_REPAYMENT")]
            VAPCANCEL_REPAYMENT = 181,            
            [Description("Written Off")]
            WRITTEN_OFF = 95,
            [Description("VAPCANCEL_PROCESS_REPAYMENT")]
            VAPCANCEL_PROCESS_REPAYMENT = 182,
            [Description("REPAYMENTS_SYCNED")]
            REPAYMENTS_SYCNED = 179,
            [Description("UNAPPROVED")]
            UNAPPROVED = 190,
            [Description("Verified")]
            Verified = 93,
            [Description("CONSOLIDATION_LOAN_CREDITED")]
            CONSOLIDATION_LOAN_CREDITED = 191,
            [Description("CONSOLIDATION_TRANSFER_REQUESTED")]
            CONSOLIDATION_TRANSFER_REQUESTED = 192,
            [Description("INACTIVE")]
            INACTIVE = 193,
            [Description("HANDOVERREPAYCREATED")]
            HANDOVERREPAYCREATED =183,
            [Description("HANDOVERREPAYPROCCESSED")]
            HANDOVERREPAYPROCCESSED = 184,
            [Description("STATUS_CUSTOMER_ROLLOVER_ACCEPTED")]
            STATUS_CUSTOMER_ROLLOVER_ACCEPTED = 195,
            [Description("PENDING")]
            PENDING = 25,
            [Description("DUPLICATE")]
            DUPLICATE = 26,
            [Description("NUCARD_CAPTURE_CLIENT_FINGERPRINT")]
            NUCARD_CAPTURE_CLIENT_FINGERPRINT = 196,
            [Description("NUCARD_BATCH_DLINKBRANCH")]
            NUCARD_BATCH_DLINKBRANCH = 197,
            [Description("NUCARD_BATCH_LINKBRANCH")]
            NUCARD_BATCH_LINKBRANCH = 198,
            [Description("DIGITAL_AGREEMENT_CAPTURE_FINGER_PRINT")]
            DIGITAL_AGREEMENT_CAPTURE_FINGER_PRINT = 201,
            [Description("MANUAL_AGREEMENT_CAPTURE_FINGER_PRINT")]
            MANUAL_AGREEMENT_CAPTURE_FINGER_PRINT = 202,

            [Description("CUSTOMER_CAPTURE_CONSULTANT_FINGERPRINT")]
            CUSTOMER_CAPTURE_CONSULTANT_FINGERPRINT = 203,
            [Description("STATUS_CUSTOMER_CONSULTANT_FINGERPRINT_CAPTURED")]
            STATUS_CUSTOMER_CONSULTANT_FINGERPRINT_CAPTURED = 204,
            [Description("DISPUTEDCREATED")]
            DISPUTED_CREATED = 155,
            [Description("DISPUTEDPROCESSED")]
            DISPUTED_PROCESSED = 156,
            [Description("NUCARD_REPLACE_REQUEST")]
            NUCARD_REPLACE_REQUEST = 205,
            [Description("NUCARD_REPLACE_APPROVE")]
            NUCARD_REPLACE_APPROVE = 206,
            [Description("NUCARD_REPLACE_REJECT")]
            NUCARD_REPLACE_REJECT = 207,
            [Description("BALANCETRANSFER_INITIATED")]
            BALANCETRANSFER_INITIATED = 188,
            [Description("BALANCETRANSFER_PROCESSED")]
            BALANCETRANSFER_PROCESSED = 189,
            [Description("NUCARD_REPLACE_ALLOCATE")]
            NUCARD_REPLACE_ALLOCATE = 208,
            [Description("ABSA_FAILED_SWITCH")]
            ABSA_FAILED_SWITCH = 210,
            [Description("ADHOC_Generate_DebitOrder")]
            ADHOC_Generate_DebitOrder = 211,
            [Description("ADHOC_Generate_DebitOrder_Approved")]
            ADHOC_Generate_DebitOrder_Approved = 212,
            [Description("APPLICATION_CLIENT_ACCEPTANCE_FAMILY")]
            APPLICATION_CLIENT_ACCEPTANCE_FAMILY = 213,
            [Description("AGREEMENT_SIGNED_DIGITALLY_FAMILY")]
            AGREEMENT_SIGNED_DIGITALLY_FAMILY = 214,
            [Description("AGREEMENT_SIGNED_MANAULLY_FAMILY")]
            AGREEMENT_SIGNED_MANAULLY_FAMILY = 215,
            
            [Description("REQUEST_FOR_APPROVAL")]
            REQUEST_FOR_APPROVAL = 216,

            [Description("REQUEST_FOR_APPROVAL")]
            CREDITSCORE_APPROVAL = 217,
            [Description("AUTO_FLASHLOAN_DISBURSEMENT_PENDING")]
            AUTO_FLASHLOAN_DISBURSEMENT_PENDING = 221,
            [Description("REFUND_PROCESSED")]
            REFUND_PROCESSED = 223,
            [Description("REFUND_REVERSED")]
            REFUND_REVERSED = 224,
            [Description("STATUS_AUTO_REFUND_DISBURSEMENT_INITIATED")]
            STATUS_AUTO_REFUND_DISBURSEMENT_INITIATED = 225,
            [Description("STATUS_REFUND_DISBURSEMENT_INITIATED")]
            STATUS_REFUND_DISBURSEMENT_INITIATED = 226,
            [Description("REFUND_LOADNUCARD_FAILED")]
            REFUND_LOADNUCARD_FAILED = 227,
            [Description("POSTVERIFICATION")]
            POSTVERIFICATION = -4
        }

        public enum Action
        {
            [Description("VIEW")]
            VIEW = 1,
            [Description("EDIT")]
            EDIT = 2,
            [Description("NEW")]
            NEW = 3,
            [Description("COPY")]
            COPY = 4,
            [Description("UPDATE")]
            UPDATE = 5,
            [Description("SUBMIT")]
            SUBMIT = 6,
            [Description("VERIFY")]
            VERIFY = 7,
            [Description("REJECT_SUBMITTED")]
            REJECT_SUBMITTED = 8,
            [Description("AVS_CHECK")]
            AVS_CHECK = 9,
            [Description("CHECK_DIGIT")]
            CHECK_DIGIT = 10,
            [Description("SWIPE")]
            SWIPE = 11,
            [Description("AUTHORISE")]
            AUTHORISE = 12,
            [Description("REJECT_VERIFICATION")]
            REJECT_VERIFICATION = 13,
            [Description("NEW_APPLICATION")]
            NEW_APPLICATION = 14,
            [Description("APPLICATION_AFD_CALCULATE")]
            APPLICATION_AFD_CALCULATE = 15,
            [Description("APPLICATION_GENERATE_QUOTATION")]
            APPLICATION_GENERATE_QUOTATION = 16,
            [Description("APPLICATION_CAPTURE_CLIENT_FINGER_PRINT")]
            APPLICATION_CAPTURE_CLIENT_FINGER_PRINT = 17,
            [Description("APPLICATION_PRINT_QUOTATION")]
            APPLICATION_PRINT_QUOTATION = 18,
            [Description("APPLICATION_SUBMIT_QUOTATION")]
            APPLICATION_SUBMIT_QUOTATION = 19,
            [Description("APPLICATION_CAPTURE_CONSULTANT_FINGER_PRINT")]
            APPLICATION_CAPTURE_CONSULTANT_FINGER_PRINT = 20,
            [Description("APPLICATION_CAPTURE_BRANCH_MANAGER_FINGER_PRINT")]
            APPLICATION_CAPTURE_BRANCH_MANAGER_FINGER_PRINT = 21,
            [Description("APPLICATION_LOAD_NUCARD")]
            APPLICATION_LOAD_NUCARD = 22,
            [Description("APPLICATION_GET_CREDITSCORE")]
            APPLICATION_GET_CREDITSCORE = 23,
            [Description("ACCOUNT_REPAY")]
            ACCOUNT_REPAY = 24,
            [Description("APPLICATION_CLIENT_ACCEPTANCE")]
            APPLICATION_CLIENT_ACCEPTANCE = 25,
            [Description("REPAYMENT_PROCESS")]
            REPAYMENT_PROCESS = 26,
            [Description("REPAYMENT_REVERSE")]
            REPAYMENT_REVERSE = 27,
            [Description("REPAYMENT_REFUND")]
            REPAYMENT_REFUND = 28,
            [Description("BIN_CHECK")]
            BIN_CHECK = 29,
            [Description("APPLICATION_PRINT_AGREEMENT")]
            APPLICATION_PRINT_AGREEMENT = 40,
            [Description("NUCARD_SWIPE")]
            NUCARD_SWIPE = 41,
            [Description("NUCARD_REISSUE_CARD")]
            NUCARD_REISSUE_CARD = 42,
            [Description("NUCARD_BLOCK_CARD")]
            NUCARD_BLOCK_CARD = 43,
            [Description("PRINT_LOAN_STATEMENT")]
            PRINT_LOAN_STATEMENT = 45,
            [Description("PRINT_PAID_UP_LETTER")]
            PRINT_PAID_UP_LETTER = 46,
            [Description("INSURANCE_CLAIM")]
            INSURANCE_CLAIM = 47,
            [Description("CLAIM_PROCESS")]
            CLAIM_PROCESS = 48,
            [Description("CLAIM_CANCEL")]
            CLAIM_CANCEL = 49,
            [Description("CLAIM_PAID")]
            CLAIM_PAID = 50,
            [Description("CLAIM_REJECT")]
            CLAIM_REJECT = 51,
            [Description("ADD_USER_ROLE")]
            ADD_USER_ROLE = 52,
            [Description("RESET_PASSWORD")]
            RESET_PASSWORD = 53,
            [Description("FETCH_FP_DETAILS")]
            FETCH_FP_DETAILS = 54,
            [Description("SAVE_BRANCHDETAILS")]
            SAVE_BRANCHDETAILS = 55,
            [Description("SAVE_AFFORDABILITYPERCENT")]
            SAVE_AFFORDABILITYPERCENT = 56,
            [Description("SAVE_TCCTERMINALS")]
            SAVE_TCCTERMINALS = 57,
            [Description("SAVE_THIRDPARTYCONFIG")]
            SAVE_THIRDPARTYCONFIG = 58,
            [Description("ACTIVATE_BRANCH")]
            ACTIVATE_BRANCH = 59,
            [Description("SIGN_AGREEMENT_DIGITALLY")]
            SIGN_AGREEMENT_DIGITALLY = 60,
            [Description("SIGN_AGREEMENT_MANUALLY")]
            SIGN_AGREEMENT_MANUALLY = 61,
            [Description("PRINT_ATLAS_COPY")]
            PRINT_ATLAS_COPY = 62,
            [Description("PROCESS_NUPAY_FILE")]
            PROCESS_NUPAY_FILE = 63,
            [Description("TRANSFER_NUCARD_BATCH")]
            TRANSFER_NUCARD_BATCH = 64,
            [Description("ACCEPT_NUCARD_BATCH")]
            ACCEPT_NUCARD_BATCH = 65,
            [Description("REJECT_NUCARD_BATCH")]
            REJECT_NUCARD_BATCH = 66,
            [Description("CANCEL_TRANSFER_NUCARD_BATCH")]
            CANCEL_TRANSFER_NUCARD_BATCH = 67,
            [Description("WrittenOff")]
            WrittenOff = 68,
            [Description("CANCEL_APPLICATION")]
            CANCEL_APPLICATION = 69,
            [Description("RESET")]
            RESET = 70,
            [Description("Initiate_WriteOff")]
            Initiate_WriteOff = 71,
            [Description("DEFER")]
            DEFER = 73,
            [Description("LOAN_CANCEL")]
            LOAN_CANCEL = 74,
            [Description("LOAN_CANCEL_CONTINUE")]
            LOAN_CANCEL_CONTINUE = 75,
            [Description("WRITEOFF_CONTINUE")]
            WRITEOFF_CONTINUE = 76,
            [Description("APPLICATION_CAPTURE_CLIENT_OTP_VERIFY")]
            APPLICATION_CAPTURE_CLIENT_OTP_VERIFY = 72,
            [Description("APPLICATION_CAPTURE_OTP_VERIFY")]
            APPLICATION_CAPTURE_OTP_VERIFY = 77,
            [Description("APPLICATION_CAPTURE_BRANCH_MANAGER_OTP_VERIFY")]
            APPLICATION_CAPTURE_BRANCH_MANAGER_OTP_VERIFY = 79,
            [Description("DEBITORDER_APPROVE")]
            DEBITORDER_APPROVE = 80,
            [Description("NEW_PRE_APPLICATION")]
            NEW_PRE_APPLICATION = 85,
            [Description("SEND_FOR_PROCESSING")]
            SEND_FOR_PROCESSING = 86,
            [Description("CONTINUE_PRE_APPLICATION")]
            CONTINUE_PRE_APPLICATION = 87,
            [Description("PRINT_TCC_SLIP")]
            PRINT_TCC_SLIP = 90,
            [Description("CARD_STATEMENT")]
            CARD_STATEMENT = 88,
            [Description("CREATE_PAYMENT_PLAN")]
            CREATE_PAYMENT_PLAN = 95,
            [Description("APPROVE_DAYEND")]
            APPROVE_DAYEND = 96,
            [Description("CHANGE")]
            CHANGE = 120,
            [Description("CHANGE_DEBIT_ORDER")]
            CHANGE_DEBIT_ORDER = 100,
            [Description("SUBMIT_CHANGE_DEBIT_ORDER")]
            SUBMIT_CHANGE_DEBIT_ORDER = 121,
            
            [Description("ENROLL_CUSTOMER")]
            ENROLL_CUSTOMER=101,
            [Description("CREATE_ACCOUNT")]
            CREATE_ACCOUNT=102,
            [Description("CREATE_SCHEDULES")]
            CREATE_SCHEDULES=103,

            [Description("CREATE_CUSTOMER")]
            CREATE_CUSTOMER = 111,
            [Description("UPDATE_EMPLOYER")]
            UPDATE_EMPLOYER = 112,
            [Description("SET_APPLICATION_CHECKLIST")]
            SET_APPLICATION_CHECKLIST = 113,
            [Description("UPDATE_NUCARD_DETAILS")]
            UPDATE_NUCARD_DETAILS=114,
            [Description("UPDATE_APPLICATION_EVENT_HISTORY")]
            UPDATE_APPLICATION_EVENT_HISTORY = 115,
            [Description("LOAD_AMOUNT")]
            LOAD_AMOUNT = 202,
            [Description("CREATE_INSURANCE")]
            CREATE_INSURANCE = 203,
            [Description("INITIATE_DISBURSEMENT")]
            INITIATE_DISBURSEMENT = 200,
            [Description("ISSUE_NUCARD")]
            ISSUE_NUCARD = 201,
            [Description("ROLLOVER_ACCOUNT")]
            ROLLOVER_ACCOUNT = 204,
            [Description("ACTIVE_ACCOUNT")]
            ACTIVE_ACCOUNT = 205,
            [Description("NUCARD_DEBITORDER")]
            NUCARD_DEBITORDER = 206,
            [Description("SIGN_QUOTATION_MANUALLY")]
            SIGN_QUOTATION_MANUALLY = 207,
            [Description("COMPLETE_DISBURSEMENT")]
            COMPLETE_DISBURSEMENT = 130,
            [Description("SUBMIT_REPORT")]
            SUBMIT_REPORT = 135,
            [Description("APPROVED")]
            APPROVED = 136,
            [Description("AUTO_WRITEOFF")]
            AUTO_WRITEOFF = 78,
            [Description("ADD_BENIFICAIRY")]
            ADD_BENIFICAIRY = 208,
            [Description("VAP_CANCEL")]
            VAP_CANCEL = 137,
            [Description("ADD_TRANSACTION")]
            ADD_TRANSACTION = 138,
            [Description("GET_CASH_REPAYMENTS")]
            GET_CASH_REPAYMENTS = 139,
            [Description("UNAPPROVE")]
            UNAPPROVE = 141,
            [Description("DELETE")]
            DELETE = 142,
            [Description("LOAN_CONSOLIDATION_VERIFY")]
            LOAN_CONSOLIDATION_VERIFY =143,
            [Description("CONSOLIDATION_TRANSFER_APPROVED")]
            CONSOLIDATION_TRANSFER_APPROVED = 144,
            [Description("REACTIVATE")]
            REACTIVATE = 145,
            [Description("DEACTIVATE")]
            DEACTIVATE = 146,
            [Description("MICROFINANCE_APPROVE")]
            MICROFINANCE_APPROVE = 148,
            [Description("ALLOCATED_REFUND")]
            ALLOCATED_REFUND = 215,
            [Description("PROCESS_REFUND")]
            PROCESS_REFUND = 216,
            [Description("AUTO_CANCEL_DEBITORDER")]
            AUTO_CANCEL_DEBITORDER = 217,
            [Description("LOAD_VOUCHER")]
            LOAD_VOUCHER = 218,
            [Description("Change_Referral")]
            Change_Referral = 219,
            [Description("LOAD_REFERRAL_REWARD")]
            LOAD_REFERRAL_REWARD = 220,
            [Description("CUSTOMER_ROLLOVER_ACCEPTANCE")]
            CUSTOMER_ROLLOVER_ACCEPTANCE = 221,
            [Description("UNTAGGED_ROLLOVER_ACCOUNT")]
            UNTAGGED_ROLLOVER_ACCOUNT = 222,
            [Description("DUPLICATE")]
            DUPLICATE = 81,
            [Description("NUCARD_CAPTURE_CLIENT_FINGERPRINT")]
            NUCARD_CAPTURE_CLIENT_FINGERPRINT = 223,
            [Description("NUCARD_BATCH_DLINKBRANCH")]
            NUCARD_BATCH_DLINKBRANCH = 224,
            [Description("NUCARD_BATCH_LINKBRANCH")]
            NUCARD_BATCH_LINKBRANCH = 225,
            [Description("CAPTURE_FINGERPRINT")]
            CAPTURE_FINGERPRINT = 226,
            [Description("PRINT_SETTLEMENT_LETTER")]
            PRINT_SETTLEMENT_LETTER = 227,
            [Description("CUSTOMER_CAPTURE_CONSULTANT_FINGERPRINT")]
            CUSTOMER_CAPTURE_CONSULTANT_FINGERPRINT = 228,
            [Description("PRINT_ASS_FORM26")]
            PRINT_ASS_FORM26 = 229,
            [Description("UPLOAD")]
            UPLOAD = 235,
            [Description("PROCESS_DISPUTED")]
            PROCESS_DISPUTED = 238,
            [Description("BALANCE_TRANSFER")]
            BALANCE_TRANSFER = 149,
            [Description("BALANCE_TRANSFER_PROCESS")]
            BALANCE_TRANSFER_PROCESS = 150,
            [Description("BALANCE_TRANSFER_CONTINUE")]
            BALANCE_TRANSFER_CONTINUE = 151,
            [Description("NUCARD_REPLACE_ALLOCATE")]
            NUCARD_REPLACE_ALLOCATE = 239,
            [Description("PRINT_SIGNED_AGREEMENT")]
            PRINT_SIGNED_AGREEMENT = 240,
            [Description("SWITCH_ABSA_DISBURSEMENT")]
            SWITCH_ABSA_DISBURSEMENT = 242,
            [Description("ADHOC_DEBITORDER")]
            ADHOC_DEBITORDER = 243,
            [Description("APPLICATION_CLIENT_ACCEPTANCE_FAMILY")]
            APPLICATION_CLIENT_ACCEPTANCE_FAMILY = 244,
            [Description("PRINT_QUOTATION_FAMILY_BENIFITS")]
            PRINT_QUOTATION_FAMILY_BENIFITS = 245,
            [Description("SIGN_AGREEMENT_FAMILY_DIGITALLY")]
            SIGN_AGREEMENT_FAMILY_DIGITALLY = 246,
            [Description("SIGN_AGREEMENT_FAMILY_MANAULLY")]
            SIGN_AGREEMENT_FAMILY_MANAULLY = 247,
            [Description("APPLICATION_PRINT_AGREEMENT_FAMILY")]
            APPLICATION_PRINT_AGREEMENT_FAMILY = 248,
            [Description("EXCEL_DOWNLOAD")]
            EXCEL_DOWNLOAD = 249,
            [Description("REQUEST")]
            REQUEST = 252,
            [Description("CALCULATE")]
            CALCULATE = 251,
            [Description("PRINT_SIGNED_FAMILY_AGREEMENT")]
            PRINT_SIGNED_FAMILY_AGREEMENT = 253,
            [Description("APPLICATION_GENERATE_QUOTATION_APPROVAL")]
            APPLICATION_GENERATE_QUOTATION_APPROVAL = 254,
            [Description("LinkMandate")]
            LinkMandate = 255,
            [Description("DelinkMandate")]
            DelinkMandate = 256,
            [Description("NUCARD_UNBLOCK_CARD")]
            NUCARD_UNBLOCK_CARD = 257,
            [Description("AUTO_REFUND_DISBURSEMENT_INITIATED")]
            AUTO_REFUND_DISBURSEMENT_INITIATED = 258,
            [Description("PRINT_VAP_STATEMENT")]
            PRINT_VAP_STATEMENT = 259,
            [Description("Loan_Action")]
            Loan_Action = 260,
            [Description("EMI_Action")]
            EMI_Action = 261,
            [Description("Resend_Otp")]
            Resend_Otp = 262,
            [Description("Cell_Validation")]
            Cell_Validation = 263,
            [Description("Add_Installment")]
            Add_Installment = 265,
            [Description("ReSubmit_Installment")]
            ReSubmit_Installment = 266,
            [Description("APPLICATION_CLIENT_ACCEPTANCE_MANUALLY")]
            APPLICATION_CLIENT_ACCEPTANCE_MANUALLY = 267,
            [Description("APPLICATION_CLIENT_ACCEPTANCE_FAMILY_MANUALLY")]
            APPLICATION_CLIENT_ACCEPTANCE_FAMILY_MANUALLY = 268,
            [Description("FUTURE_VAP_CANCEL")]
            FUTURE_VAP_CANCEL = 269,

            [Description("VAP_CANCEL_REQUESTFORAPPROVAL")]
            VAP_CANCEL_REQUESTFORAPPROVAL = 270,
            [Description("VAP_CANCEL_APPROVAL")]
            VAP_CANCEL_APPROVAL = 271,
            [Description("VAP_CANCEL_REJECT")]
            VAP_CANCEL_REJECT = 272,
            [Description("VAP_CANCEL_START")]
            VAP_CANCEL_START = 273,
            [Description("SUBMIT_CHANGE_DEBIT_ORDER_VAPCANCEL")]
            SUBMIT_CHANGE_DEBIT_ORDER_VAPCANCEL = 274,

            [Description("GetOffers_Action")]
            GetOffers_Action = 275,

            [Description("Copy_Application")]
            Copy_Application = 276
        }

        public enum BO_Object
        {
            [Description("Customers")]
            Customers = 1,
            [Description("Accounts")]
            Accounts = 3,
            [Description("Applications")]
            Applications = 2,   
            [Description("Branch")]
            Branch = 13,
            [Description("Collections")]
            Collections = 4,
            [Description("Repayment")]
            Repayment = 6,
            [Description("BankDetails")]
            BankDetails = 7,
            [Description("EmployerDetails")]
            EmployerDetails = 8,
            [Description("Quotation")]
            Quotation = 9,
            [Description("Affordability")]
            Affordability = 10,
            [Description("Disbursement")]
            Disbursement = 11,
            [Description("Users")]
            Users = 12,
            [Description("Sales")]
            Sales = 5,
            [Description("BankAccountType")]
            BankAccountType = 14,
            [Description("Bank")]
            Bank = 15,
            [Description("MaritalStatus")]
            MaritalStatus = 16,
            [Description("Occupation")]
            Occupation = 17,
            [Description("Race")]
            Race = 18,
            [Description("Language")]
            Language = 19,
            [Description("Country")]
            Country = 20,
            [Description("Province")]
            Province = 21,
            [Description("Role")]
            Role = 22,
            [Description("VAP")]
            VAP = 23,
            [Description("PropertyOwnership")]
            PropertyOwnership = 24,
            [Description("LoanReasons")]
            LoanReasons = 25,
            [Description("NuCard")]
            NuCard = 26,
            [Description("Insurance")]
            Insurance = 27,
            [Description("Claim")]
            Claim = 28,
            [Description("NupayCollection")]
            NupayCollection = 29,
            [Description("NuPayFile")]
            NuPayFile = 30,
            [Description("NucardBatch")]
            NucardBatch = 31,
            [Description("AccPacc")]
            AccPacc = 32,
            [Description("WriteOff Off")]
            WriteOff = 33,
            [Description("WriteOff Off Initiate")]
            WriteOffReasonInitiate = 34,
            [Description("CancelReason")]
            CancelReason = 35,
            [Description("DayEndReport")]
            DayEndReport = 36,
            [Description("Integrations")]
            Integrations = 37,
            [Description("ChangeDebitOrder")]
            ChangeDebitOrder = 38,
            [Description("BranchCashTransaction")]
            BranchCashTransaction = 39,
            [Description("BranchcashAccount")]
            BranchcashAccount = 40,
            [Description("BankAccount")]
            BankAccount = 41,
            [Description("BranchCashReport")]
            BranchCashReport = 42,
            [Description("RegionCashAccountLink")]
            RegionCashAccountLink = 43,
            [Description("MicroFinance")]
            MicroFinance = 44,
            [Description("LoanConsolidation")]
            LoanConsolidation = 45,
            [Description("Refund")]
            Refund = 50,
            [Description("Campaigns")]
            Campaigns = 51,
            [Description("AtlasBudgeting")]
            AtlasBudgeting = 52,
            [Description("Disputed")]
            Disputed = 53,
            [Description("BalanceTransfer")]
            BalanceTransfer = 60,
            [Description("Sacrra")]
            Sacrra = 61,
            [Description("EarlySettlement")]
            EarlySettlement = 62,
            [Description("Discount")]
            Discount = 63,
            [Description("DebitOrder")]
            DebitOrder = 64,
            [Description("LGRRefund")]
            LGRRefund = 65

        }

        public enum BO_ObjectAPI
        {
            [Description("Bank Details")]
            bankdetails = 1,
            [Description("Employer Details")]
            employerdetails = 2,
            [Description("Documents")]
            documents = 3,
            [Description("Income Expense")]
            incomeexpense = 4,
            [Description("Personal Details")]
            profile = 5,
            [Description("newcustomer")]
            newcustomer = 6,
            [Description("copyfromass")]
            copyfromass = 7,
            [Description("Client")]
            client = 8,
            [Description("Application")]
            application = 9,
            [Description("Master")]
            master = 10,
            [Description("Affordability")]
            affordability = 11,
            [Description("Disbursement")]
            disbursement = 12,
            [Description("Quotation")]
            quotation = 13,
            [Description("account")]
            account = 14,
            [Description("Repayment")]
            repayment = 15,
            [Description("cases")]
            cases = 16,
            [Description("User")]
            User = 17,
            [Description("VAP")]
            VAP = 18,
            [Description("NuCard")]
            NuCard = 19,
            [Description("Insurance")]
            Insurance = 20,
            [Description("Claim")]
            Claim = 21,
            [Description("NupayCollection")]
            NupayCollection = 22,
            [Description("Branch")]
            Branch = 23,
            [Description("NuPay")]
            NuPay = 24,
            [Description("NucardBatch")]
            NucardBatch = 25,
            [Description("AccPacc")]
            AccPacc = 26,
            [Description("WriteOff Off")]
            WriteOff = 33,
            [Description("WriteOff Off Initiate")]
            WriteOffReasonInitiate = 34,
            [Description("PaymentPlan")]
            PaymentPlan = 35,
            [Description("branchcashaccount")]
            branchcashaccount = 36,
            [Description("bankaccount")]
            bankaccount = 37,
            [Description("branchcashreport")]
            branchcashreport = 38,
            [Description("branchcashtransaction")]
            branchcashtransaction = 39,
            [Description("regioncashaccountlink")]
            regioncashaccountlink = 40,
            [Description("microfinance")]
            microfinance = 44,
            [Description("loanconsolidation")]
            loanconsolidation = 41,
            [Description("LGRRefund")]
            LGRRefund = 50,
            [Description("ReferAndEarn")]
            ReferAndEarn = 51,
            [Description("Occupation")]
            occupation = 55,
            [Description("EmployerCode")]
            employercode = 56,
            [Description("BalanceTransfer")]
            BalanceTransfer = 60,
            [Description("EarlySettlement")]
            EarlySettlement = 61,
            [Description("Discount")]
            Discount = 63,
            [Description("CampaignNotification")]
            campaignnotification = 64,
            [Description("DebtReview")]
            debtReview = 65,
            [Description("EmiOrLoan")]
            EmiOrLoan = 66,
            [Description("CustomerAcceptance_Resend_Otp")]
            CustomerAcceptance_Resend_Otp = 67,
            [Description("FamilyBenefitAcceptance_Resend_Otp")]
            FamilyBenefitAcceptance_Resend_Otp = 68,
            [Description("IsPhoneNoExist")]
            IsPhoneNoExist = 69,
            [Description("CreditAssement")]
            CreditAssement = 70,
            [Description("GetOffers")]
            GetOffers = 71
        }

        public enum SalaryFrequency
        {
            [Description("Monthly")]
            Monthly = 1,
            [Description("Weekly")]
            Weekly = 2,
            [Description("Fortnightly")]
            Fortnightly = 3,
            [Description("Monthly/ADHOC")]
            MonthlyADHOC = 4
        }

        public enum SalaryTypeFrequency
        {
            [Description("M")]
            M = 1,
            [Description("W")]
            W = 2,
            [Description("F")]
            F = 3
        }

        public enum BO_Collection_Setting
        {
            [Description("AEDOREADPATH")]
            AEDOREADPATH = 1,
            [Description("AEDOHISTORYPATH")]
            AEDOHISTORYPATH = 2,
            [Description("NEADOREADPATH")]
            NEADOREADPATH = 3,
            [Description("RPAYREADPATH")]
            RPAYREADPATH = 4,
            [Description("NEADOHISTORYPATH")]
            NEADOHISTORYPATH = 5,
            [Description("RPAYHISTORYPATH")]
            RPAYHISTORYPATH = 6


        }

        public enum BOS_Collection
        {
            [Description("AEDO")]
            AEDO = 1,
            [Description("NAEDO")]
            NAEDO = 2,
            [Description("REALPAY")]
            REALPAY = 3,
            [Description("Cash")]
            CSH = 4,
            [Description("NuPAY TCC POS")]
            POS = 5,
            [Description("Nucard")]
            NUC = 6,
            [Description("Region Account")]
            REG = 7,
            [Description("Intl Con")]
            ROL = 8,
            [Description("SYNDICATED NAEDO")]
            SNA = 9,
            [Description("Handover")]
            HANDOVER = 10,
            [Description("WRITE OFF")]
            WRITEOFF = 11,
            [Description("CANCEL")]
            CANCEL = 12,
            [Description("REFUND")]
            REFUND = 13,
            [Description("EFT Manual")]
            EFTManual = 16,
            [Description("EFT Auto")]
            EFTAuto = 17,
            [Description("TT1Delayed")]
            TT1Delayed = 18,
            [Description("PAYROLL DEDUCTION")]
            PAYROLL = 19,
            [Description("Internal Write-OFF")]
            INTERNAL_FRAUD = 21,
            [Description("External Write-OFF")]
            EXTERNAL_FRAUD = 22,
            [Description("Auto Write-OFF")]
            AUTO_WRITEOFF = 23,
            [Description("Cancellation of Outstanding VAP Component on Loan")]
            VAP_CANCELLATION = 24,
            [Description("Cancellation of Paid VAP Component")]
            PAID_VAP_CANCEL = 25,
            [Description("AUTO_REFUND")]
            AUTO_REFUND = 26,
            [Description("TT3_DEBICHECK")]
            TT3_DEBICHECK = 27,
            [Description("Agreed Account Closure")]
            AGREED_ACC_CLOSURE = 28,
            [Description("Balance Transfer")]
            BALANCETRANSFER = 31,
            //Future VAP Cancel
            [Description("Cancellation of Outstanding FUTURE VAP Component on Loan")]
            FUTURE_VAP_CANCEL = 119,
        }

        public enum BOS_LoanType
        {
            [Description("VAP")]
            V = 2,
            [Description("LOAN")]
            L = 1,
            [Description("NuCard")]
            N = 3,
            [Description("CashInHand")]
            C = 4
        }

        public enum BOS_NuCardType
        {
            [Description("NEW")]
            New = 1,
            [Description("LOST")]
            Lost = 2,
            [Description("EXPIRED")]
            Expired = 3,
            [Description("FAULTY")]
            Faulty = 4
        }

        public enum ThirdPartyIntegration
        {
            [Description("Credit Score")]
            Credit_Score = 1,
            [Description("AVS Check")]
            AVS_Check = 2,
            [Description("NuCard")]
            NuCard = 3,
            [Description("Naedo")]
            Naedo = 4,
            [Description("AEDO")]
            AEDO = 5,

            [Description("DebiCheck")]
            DebiCheck = 6,
            [Description("TT3DebiCheck")]
            TT3DebiCheck = 7,
            [Description("RealPayDebiCheck")]
            RealPayDebiCheck = 8
        }

        public enum ErrorCategory
        {
            [Description("Swipe Card")]
            SWIPECARD = 1,
            [Description("Load NuCard")]
            LOADNUCARD = 2,
            [Description("POS")]
            POS = 3,
            [Description("NAEDO_REPORT")]
            NAEDO_REPORT = 4,
            [Description("NAEDO_DEBIT")]
            NAEDO_DEBIT = 5,
            [Description("COMPUSCAN")]
            COMPUSCAN = 6,
            [Description("TRANSUNION")]
            TRANSUNION = 7
        }

        public enum ServiceType
        {
            [Description("NAEDO")]
            NAEDO = 19,
            [Description("AEDO")]
            AEDO = 20,

            [Description("TT1Delayed")]
            TT1Delayed =21,


            [Description("TT3_DEBICHECK")]
            TT3_DEBICHECK = 22,
            [Description("TT1_REALPAY")]
            TT1_REALPAY = 23,
            [Description("TT3_REALPAY")]
            TT3_REALPAY = 24

        }

        public enum ReportType
        {
            [Description("Transactions_Uploaded")]
            Transactions_Uploaded = 01,
            [Description("Future_Transaction")]
            Future_Transaction = 02,
            [Description("Transactions_In_Progress")]
            Transactions_In_Progress = 03,
            [Description("Successful_Transactions")]
            Successful_Transactions = 04,
            [Description("Failed_Transactions")]
            Failed_Transactions = 05,
            [Description("Cancelled_Transactions")]
            Cancelled_Transactions = 06,
            [Description("Disputed_Transactions")]
            Disputed_Transactions = 07
        }

        public enum NaedoSalaryFrequency
        {
            [Description("Once_Off")]
            Once_Off = 0,
            [Description("Weekly")]
            Weekly = 1,
            [Description("Fortnightly")]
            Fortnightly = 2,
            [Description("Monthly")]
            Monthly = 3,
            [Description("First_Working_Day")]
            First_Working_Day = 4,
            [Description("Last_Working_Day")]
            Last_Working_Day = 5
        }

        public enum AccountType
        {
            [Description("Cheque")]
            Cheque = 1,
            [Description("Saving")]
            Saving = 2,
            [Description("Transmission")]
            Transmission = 3
        }

        public enum AccountTypeEasyDebit
        {
            [Description("Cheque")]
            Cheque = 1,
            [Description("Savings")]
            Savings = 2,
            [Description("Transmission")]
            Transmission = 3
        }

        public enum NaedoTrackingIndicator
        {
            [Description("No_Tracking")]
            No_Tracking = 12,
            [Description("One_Day_Tracking")]
            One_Day_Tracking = 13,
            [Description("Three_Day_Tracking")]
            Three_Day_Tracking = 14,
            [Description("Four_Day_Tracking")]
            Four_Day_Tracking = 02,
            [Description("Seven_Day_Tracking")]
            Seven_Day_Tracking = 15,
            [Description("Fourteen_Day_Tracking")]
            Fourteen_Day_Tracking = 16,
            [Description("TwentyOne_Day_Tracking")]
            TwentyOne_Day_Tracking = 17,
            [Description("ThirtyTwo_Day_Tracking")]
            ThirtyTwo_Day_Tracking = 18
        }

        public enum PaymentType
        {
            [Description("Manual")]
            Manual = 1,
            [Description("Auto")]
            Auto = 2
        }

        public enum Application
        {
            [Description("BOS")]
            BOS = 1,
            [Description("CMS")]
            CMS = 2
        }

        public enum LoanStateReasonCode
        {
            [Description("Early Settled")]
            E = 1,
            [Description("Fully paid up")]
            F = 2,
            [Description("Handed over")]
            H = 3,
            [Description("Written Off")]
            W = 4,
            [Description("Cancelled")]
            C = 5,
            [Description("New Loan")]
            N = 6,
            [Description("Part Payment")]
            P = 7,
            [Description("Roll Over")]
            R = 8,
            [Description("Overdue Payment Requesting")]
            I = 9,
            [Description("Overdue Payment Requested")]
            D = 10
        }

        public enum InsuranceType
        {
            [Description("Funeral")]
            Funeral = 1,
            [Description("Credit Life")]
            CreditLife = 2
        }

        public enum PolicyStatus
        {
            [Description("Active")]
            A = 1, //(Default Status for new Policy)
            [Description("Reinstated")]
            R = 2,//(Payment received after closure)
            [Description("Claimed")]
            C = 3,//(Death - D , P, R )
            [Description("Loan Cancelled")]
            X = 4,
            [Description("Written Off")]
            E = 5,
            [Description("Handed Over")]
            L = 6,
            [Description("Paid Up")]
            P = 7,
        }

        public enum ClaimStatus
        {

            [Description("OutStanding")]
            O = 1,
            [Description("Paid")]
            P = 2,
            [Description("Rejected")]
            R = 3,
            [Description("New")]
            N = 4,
            [Description("Cancelled")]
            C = 5
        }
        public enum ClaimReason
        {
            [Description("Dead Unnatural")]
            D = 1,
            [Description("Illness")]
            I = 2,
            [Description("Dead-Natural")]
            N = 3,
            [Description("Permanent Disable")]
            P = 4,
            [Description("Retrenchment")]
            R = 4,
            [Description("Dead-Suicide")]
            S = 4

        }

        public enum BeneficiaryType
        {
            [Description("Beneficiary")]
            Beneficiary = 1,
            [Description("Insured")]
            Insured = 2,
            [Description("Others")]
            Others = 3,
            [Description("NextOfkin")]
            NextOfKin = 4,
            [Description("MainMember")]
            MainMember = 5
        }

        public enum SignFlowDocType
        {
            [Description("Quotation")]
            Quotation = 1,
            [Description("Agreement")]
            Agreement = 2,
            [Description("FamilyAgreement")]
            FamilyAgreement = 3
        }


        public enum SigningMethod
        {
            [Description("Quotation")]
            Digital = 'D',
            [Description("Agreement")]
            Manual = 'M'
        }
        public enum CheckType
        {
            [Description("Ignore")]
            I = 'I',
            [Description("Deferred")]
            D = 'D',
            [Description("Verified")]
            V = 'V'
        }

        public enum HandoverLoanType
        {
            [Description("LOAN")]
            LOAN,
            [Description("VAP")]
            VAP,
            [Description("NUCARD")]
            NUCARD
        }

        public enum DebitOrderModes
        {
            [Description("AEADO")]
            AEADO = 1,
            [Description("NEADO")]
            NEADO = 2,
            [Description("TT1Delayed")]
            TT1Delayed = 3,
            [Description("TT1_0229")]
            TT1_0229 = 4,
            [Description("TT1_0230")]
            TT1_0230 = 5,
            [Description("TT3_DEBICHECK")]
            TT3_DEBICHECK = 6,
            [Description("No DebitOrder")]
            NODebitOrder = 7,
            [Description("TT1_REALPAY")]
            TT1_REALPAY = 8,
            [Description("TT3_REALPAY")]
            TT3_REALPAY = 9
        }

        public enum IntegrationType
        {
            [Description("Finger print")]
            FINGER_PRINT,
            [Description("CompuScan")]
            COMPUSCAN,
            [Description("Infobip SMS")]
            INFOBIP,
            [Description("AVS check")]
            AVS_CHECK,
            [Description("Signflow")]
            SIGNFLOW,
            [Description("Balance check")]
            NUCARD_BALANCE_CHECK,
            [Description("Card allocation")]
            NUCARD_ALLOCATE_CARD,
            [Description("Load card")]
            NUCARD_LOAD_CARD,
            [Description("Block card")]
            NUCARD_BLOCK_CARD,
            [Description("Reverse load card")]
            NUCARD_REVERSE_LOAD_CARD,
            [Description("AEDO Create")]
            NUPAY_CREATE_AEDO,
            [Description("AEDO Cancel")]
            NUPAY_CANCEL_AEDO,
            [Description("NAEDO Create")]
            NUPAY_CREATE_NAEDO,
            [Description("NAEDO Cancel")]
            NUPAY_CANCEL_NAEDO,
            [Description("DebiCheck Create")]
            NUPAY_CREATE_DEBICHECK,
            [Description("DebiCheck Cancel")]
            NUPAY_CANCEL_DEBICHECK,
            [Description("NuCard Deduct")]
            NUCARD_DEDUCT,
            [Description("NuCard Status")]
            NUCARD_STATUS,
            [Description("Tran Id Query for AEDO")]
            TRAN_ID_QUERY_FOR_AEDO,
            [Description("NuCard Statement")]
            NUCARD_STATEMENT,
            [Description("NuCard Cancel Stop")]
            NUCARD_CANCEL_STOP,
            [Description("NuCard Transfer Funds")]
            NUCARD_TRANSFER_FUNDS,
            [Description("NUPAY_CANCEL_INSTALMENT_AEDO")]
            NUPAY_CANCEL_INSTALMENT_AEDO,
            [Description("NUPAY_CANCEL_INSTALMENT_NAEDO")]
            NUPAY_CANCEL_INSTALMENT_NAEDO,
            [Description("Digital Cabinet Upload")]
            DIGITAL_CABINET_UPLOAD,
            [Description("Digital Cabinet Download")]
            DIGITAL_CABINET_DOWNLOAD,
            [Description("Upload Naedo Transaction")]
            UPLOAD_NAEDO_TRANSACTION,
            [Description("Nupay Tcc Pos")]
            NUPAY_TCC_POS,
            [Description("Nucard allocation check")]
            NUCARD_ISALLOCATED,
            [Description("DebiCheckTT3 Create")]
            NUPAY_CREATE_DEBICHECKTT3,
            [Description("DebiCheck Status")]
            NUPAY_DEBICHECK_STATUS,
            [Description("Campaign Manager Send Voucher")]
            CAMPAIGN_MANAGER_SEND_VOUCHER,
            [Description("DebiCheck Installment Cancellation")]
            DEBHICHECK_CANCEL_INSTALLMENT,
            [Description("DebiCheck Installment Addition")]
            DEBHICHECK_ADD_INSTALLMENT,
            [Description("ConnectMobile SMS")]
            CONNECTMOBILE,
            [Description("Easy Debit AVS check")]
            EASY_DEBIT_AVS_CHECK,
            [Description("Easy Debit AVS Strike Date")]
            EASY_DEBIT_AVS_STRIKE_DATE,
            [Description("RealPayTT1 Client Update")]
            REALPAYTT1_UPDATE_CLIENT,
            [Description("RealPayTT1 Mandate Creation")]
            REALPAYTT1_CREATE_MANDATE,
            [Description("RealPayTT1 Mandate Cancellation")]
            REALPAYTT1_CANCEL_MANDATE,
            [Description("TRANSUNION")]
            TRANSUNION,
            [Description("SKYQR")]
            SKYQR,
            [Description("RealPay Mandate Status")]
            REALPAY_MANDATE_STATUS,
            [Description("RealPay Installment Addition")]
            REALPAY_ADD_INSTALLMENT,
            [Description("TRANSUNIONREPORT")]
            TRANSUNIONREPORT,

            [Description("XDS Token Authenticate")]
            XDS_Token_Authenticate,
            [Description("PreVet XDS Customer Details")]
            PreVet_XDS_CustomerDetails,
            [Description("Truid Company And BrandId")]
            Truid_CompanyAndBrandId,
            [Description("Truid Collection By Upload")]
            Truid_CollectionByUpload,
            [Description("Truid Data Service Id")]
            Truid_DataServiceId,
            [Description("Truid Collection By AccountNumber")]
            Truid_CollectionByAccountNum,
            [Description("Truid Consents")]
            Truid_Consents,
            [Description("Truid Data Providers")]
            Truid_DataProviders,
            [Description("Truid Credentials")]
            Truid_Credentials,
            [Description("Truid Collection Status")]
            Truid_CollectionStatus,
            [Description("Truid Challenges")]
            Truid_Challenges,
            [Description("Truid Categorisation")]
            Truid_Categorisation,
            [Description("FullVet XDS Customer Details")]
            FullVet_XDS_CustomerDetails,

            [Description("DebiCheck Installment Reschedule")]
            DEBICHECK_RESCHEDULE_INSTALL,

            //LamininApi
            [Description("Lamini API Debtfreeze")]
            Lamini_API_Debtfreeze,
            [Description("Lamini API DebtReview")]
            Lamini_API_DebtReview,

            [Description("AtlasScoreExperian")]
            AtlasScoreExperian,

            [Description("AtlasProductMatrix")]
            AtlasProductMatrix,

            [Description("AtlasDocumentServices")]
            AtlasDocumentServices,

            [Description("AtlasDocumentServiceProcessingStatus")]
            AtlasDocumentServiceProcessingStatus,

            [Description("BankStatementTransaction")]
            BankStatementTransaction

        }

        public enum AncillaryProducts
        {
            [Description("VAP")]
            VAP = 1,
            [Description("Credit Life")]
            CreditLife = 2           
        }

        public enum ProductConfig
        {
            FIRSTLOANMINAMOUNT,
            FIRSTLOANMAXAMOUNT,
            NEXTLOANMINAMOUNT,
            NEXTLOANMAXAMOUNT,
            CREDITSCORE,
            LOANTERM,
            FREQUENCYTYPE,
            DEBITORDERMODES,
            DISBURSEMENTMODES,
            AFFORDABILITYPERCENTAPPLICABLE,
            FIRSTINTERESTRATE,
            SECONDINTERESTRATE,
            ANCILLARYPRODUCTS,
            ALLOWROLLOVER,
            ALLOWEARLYSETTLEMENT,
            REPAYMENTMODES,
            SERVICEFEES,
            VATONSERVICEFEES,
            INITIATIONFEES,
            VATINITIATIONFEES,
            DOCUMENTLIST,
            ALLOWREFUNDS,
            ALLOWREVERSAL,
            ALLOWLOANCANCELLATION,
            VATPERCENTAGE,
            QUOTATIONACCEPTBYOTP,
            QUOTATIONACCEPTBYFINGERPRINT,
            CONSULTANTVERIFICATION,
            COUNSULTANTOTPREQUIRED,
            MANAGERVERIFICATION,
            MANAGEROTPREQUIRED,
            MINAGE,
            MAXAGE,
            MINSALARY,
            MAXSALARY,
            ALLOWEDCOUNTRY,
            ISCAMPAIGNCODE,
            CAMPAIGNID,
            CAMPAIGNNAME,
            AFFORDABILITYPERCENT,
            NLRMINSCORE,
            VATRATE,
            SERVICEFEEPERMONTH,
            CREDITPROTECTIONRATEPERMONTH,
            ALLOWCARDVALIDATION,
            ALLOWDEFER,
            VAPNOTAPPLIEDVALUE,
            APPLICATIONCHECKLIST,
            CLIENTCHECKLIST,
            ALLOWEDREPAYMENTMODES,
            CHANGEDEBITORDER,
            ALLOWBANKCHANGE,
            ALLOWPAYMENTPLANCHANGE,
            ALLOWLOANCONSOLIDATION,
            ALLOWVAPCANCELLATION,
            ALLOWCROSSBORDERMONEYTRANSFER,
            CROSSBORDERMONEYTRANSFERCONFIG,
            DISCRETIONNEGATIVE,
            DISCRETIONCOMPARE,
            ALLOWREPAYMENTVERIFICATION,
            ALLOWCANCELLOANFINGERPRINT,
            ALLOWWRITEOFFFINGERPRINT,
            ALLOWVAPCANCELFINGERPRINT,
            ALLOWRELIEFLOAN,
            GENDER,
            ALLOWADHOCDEBITORDER,
            DEFAULTEMPLOYERCODE,
            DEFAULTOCCUPATIONCODE,
            READONLY,
            DEFAULTEMPLOYERNAME,
            DEFAULTOCCUPATIONDESCRIPTION,
            AVSCHECKTYPE,
            MAXREPAYMENTAMOUNT,
            INSTALLMENTNO,
            IGNOREDISCRETION,
            ISPRODUCTCODEAPPROVAL,
            PRODUCTWISESTARTTERM,
            ISADDITIONALAMOUNTINVAP,
            ISEMIDISABLE

        }
        public enum SNXPDFDocument
        {
            QUOTATIONCOPY,
            PRINTQUOTATION,
            ATLASAGREEMENTCOPY,
            CUSTOMERAGREEMENTCOPY,
            PRINTAGREEMENT,
            PRINTCARDSTATEMENT,
            PRINTLOANSTATEMENT,
            PRINTEARLYSETTLEMENT,
            PRINTEARLYSETTLEMENTLETTER,
            PRINTPAIDUPLETTER,
            PRINTHANDOVERREPORT,
            PRINTOVERDUEREPORT,
            PAYMENTSCHEDULE,
            PRINTTCCSLIP,
            PRINTREPAYMENTRECEIPT,
            PRINTSETTLEMENTLETTER,
            ASS_FORM_26,
            QUOTATIONCOPY_FAMILY,
            ATLASAGREEMENT_FAMLIY,
            PRINTAGREEMENT_FAMILY,
            PRINTVAPSTATEMENT
        }

        public enum CashManagementConfigKey
        {
            [Description("ENFORCE_REPORT_APPROVAL")]
            ENFORCE_REPORT_APPROVAL,
            [Description("ENFORCE_SEQUENTIAL_APPROVAL")]
            ENFORCE_SEQUENTIAL_APPROVAL,
            [Description("LGR_ENTRY_TRIGGER")]
            LGR_ENTRY_TRIGGER
        }

        public enum AbsaFileType
        {
            [Description("CLIENT_EFT")]
            CLIENT_EFT,
            [Description("THIRDPARTY_EFT")]
            THIRDPARTY_EFT,
            [Description("REFUND_EFT")]
            REFUND_EFT
        }

        public enum WriteOffReason
        {
            [Description("Disability")]
            Disability = 1,
            [Description("Deceased")]
            Deceased = 2,
            [Description("Retrenchment")]
            Retrenchment = 3,
            [Description("External Fraud")]
            External_Fraud = 4,
            [Description("Internal Fraud")]
            Internal_Fraud = 5,
            [Description("Auto Write-OFF")]
            Auto_Write_OFF = 6

        }

        #region Campaign manager specific Enums

        public enum ReferralRewardReportBatchStatus
        {
            [Description("Success")]
            SUCCESS,
            [Description("Failed")]
            FAILED
        }

        public enum ReferralRewardReportStatus
        {
            [Description("PENDING")]
            PENDING,
            [Description("INPROGRESS")]
            INPROGRESS,
            [Description("SUCCESS")]
            SUCCESS,
            [Description("FAILED")]
            FAILED
        }

        #endregion
        public enum NTFPlaceholders
        {
            OTP,
            ApplicationId,
            ID,
            RolloverAccountId,
            PayableAmount,
            CurrentTime
        }

        public enum NTFTemplateType
        {
            [Description("General OTP")]
            OTP = 1,
            [Description("Rollover OTP")]
            RolloverOTP = 2
        }

        public enum ProjectName
        {
            BackOfficeServer,
            BackOfficeJobs
        }

        public enum IDLPDiscountType
        {
            [Description("Percentage")]
            Percentage = 1,
            [Description("FlatAmount")]
            FlatAmount = 2
        }

        public enum ServiceProviderTypes
        {
            Notification,
            DebitOrder,
            EasyDebitAVS_Token,
            EasyDebitAVS_Verify,
            EasyDebitStrikeDate,

            CustomerDetailsXDS_Token,
            CustomerDetailsXDS,
            Truid_GetCompanyAndBrandId,
            CurrentCollection,
            CollectionStatus,
            FullVetCustomerDetailsXDS,
            GetDataServiceId,
            CurrentCollectionAccountNumber,
            Consents,
            DataProviders,
            Credentials,
            Challenges,
            Categorisations,

            //LamininApi
            LamininApi_Debt,
            LamininApi_Affordability,

            //AtlasScoreExperian
            AtlasScoreExperian,

            //AtlasProductMatrix
            AtlasProductMatrix,

            //AtlasDocumentServices
            AtlasDocumentServices,

            AtlasDocumentServiceProcessingStatus
        }

        public enum ServerType
        {
            Production,
            PreProduction
        }

        public enum CreditAssessment
        {
            PreVet,
            FullVet
        }

        public enum AVSType
        {
            AVS,
            EasyDebitAVS
        }

        public enum ScoreMode
        {
            CompuScan,
            TransUnion
        }

        public enum DebitOrderServiceProvider
        {
            NUPAY,
            REALPAY
        }

        public enum AtlasDocumentService
        {
            AtlasDocumentServices,
            AtlasDocumentServiceProcessingStatus,
            AtlasDE
        }

        public enum NationalidIdentificationType
        {
            [Description("South African Identity Number")]
            SAID,
            [Description("Foreign Passport")]
            FOPA,
            [Description("South African Passport")]
            SAPA,
            [Description("South African Temporary Residence")]
            SATR,
            [Description("South African Business Registration")]
            SABR
        }

        public enum VapCancelTypeEnum
        {
            [Description("BothVapCancel")]
            BothVapCancel = 0,
            [Description("AllVapCancel")]
            AllVapCancel = 1,
            [Description("FutureVapCancel")]
            FutureVapCancel = 2
        }

        public enum VapCancelStatusEnum
        {
            [Description("RequestForApproval")]
            RequestForApproval = 0,
            [Description("Approval")]
            Approval = 1,
            [Description("VapCancel")]
            VapCancel = 2,
            [Description("VapCancelReject")]
            VapCancelReject = 3,

            [Description("VapCancel_ChangeDO_Mandate_APPROVED")]
            VapCancel_ChangeDO_Mandate_APPROVED = 5,

            [Description("VapCancelDone")]
            VapCancelDone = 4
        }

    }
}
