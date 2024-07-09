using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atlas.Common.Common
{
    public static class Constants
    {
        public const string Failed = "Failed";
        public const string FailedCode = "FAILED";
        public const string Success = "Success";
        public const string SuccessCode = "SUCCESS";
        public const string AccountDetailsNotFound = "ALMS - Account details not found";
        public const string AccountListNotFound = "ALMS - Account records not found";
        public const string FutureVAPCancelDetailsNotFound = "ALMS - Future VAP Cancel Details Not Found";
        public const string FutureVAPCancelDetailsError = "ALMS - Future VAP Cancel Details Error"; 
        //Add and Resubmit Instalment start
        public const string FailedScheduleNotFound_AddInstDone = "ALMS - Failed Schedule Not Found Or Add Insatllment is Done Already";
        public const string SchedulenotFailed = "ALMS - Installment is already Rescheduled or Repaid. Kindly verify in the history";
        public const string FailedSchedulenotFound = "ALMS - Failed Schedule data not Found";
        public const string NoResubmitForLastSchedule = "ALMS - No Resubmit For Last Schedule";
        public const string NoRealpayResubmit = "ALMS - No Option for REALPAY Resubmit";
        public const string AddInstallmetLimit = "ALMS - Add Installment Alrady done 2 times";
        public const string AllDueDatesInPast = "ALMS - Unable to resubmit.  All Due Dates are in Past";

        public const string AccountErrorCode = "ALMS - ACCOUNT_ERROR";
        public const string AccountDetailsErrorMessage = "ALMS - Error in getting account details";
        public const string RegionCashAccountLnkListErrorMessage = "ALMS - Error in getting regioncashaccountlnk list";
        public const string CustomerDetailsNotFound = "ALMS - Customer details not found";
        public const string InterestCalError = "ALMS - Error in interest calculation";
        public const string InterestRateCalError = "ALMS - Error in interest rate calculation";
        public const string ProvideCustomer = "ALMS - Please provide customer details!";
        public const string ProvideAccount = "ALMS - Please provide Account details!";
        public const string InvalidToken = "ALMS - Invalid session token";
        public const string AuthenticationFailedCode = "ALMS - AUTHENTICATION_FAILED";
        public const string AuthenticationFailed = "ALMS - Authentication failed.";
        public const string InvalidUsernamePassword = "ALMS - Invalid username or password.";
        public const string AuthorizationFailedCode = "ALMS - AUTHORIZATION_FAILED";
        public const string AuthorizationFailed = "ALMS - Unauthorized request.";
        public const string ApplicationDetailsNotFound = "ALMS - Application details not found";
        public const string FileNotFound = "ALMS - File does not exists";
        public const string FileUploaded = "ALMS - Document uploaded successfully";
        public const string InvalidBankDetails = "ALMS - Bank details are invalid";
        public const string FormulaNotMatch = "ALMS - UI and backend formula not match";
        public const string VoucherNumber = "ALMS - Voucher number not found";
        public const string InvalidOTP = "ALMS - Invalid OTP";
        public const string QuotePayLoadNull = "ALMS - Please provide quotation details";
        public const string PreConditionsNotMet = "ALMS - {0} is pending.";
        public const string PersonIdNotFound = "ALMS - Customer Not Registered.";
        public const string FingerPrintEnrollFailedCode = "ALMS - FINGERPRINT_ENROLL_FAILED";
        public const string FingerPrintEnrollFailed = "ALMS - Please Enroll Customer Fingerprint";
        public const string FingerPrintAlreadyEnroll = "ALMS - Customer fingerprints already enrolled";
        public const string LoanCalculationError = "ALMS - Application cannot be saved. Discretion amount is insufficient.";
        public const string VerifyFingerPrint = "ALMS - Please Enrol Fingerprint";
        public const string RepaymentDetailsNotFound = "ALMS - Repayment details not found";
        public const string SessionTokenNull = "ALMS - Session token is null";
        public const string SessionTokenInvalid = "ALMS - Session token is invalid";
        public const string InvalidUserNameMessage = "ALMS - Invalid Username";
        public const string UserNameAlreadyExistsMessage = "ALMS - Username Already Exists";
        public const string ErrorFetchingDetailsMessage = "ALMS - Error fetching details";
        public const string CreditScoreError = "ALMS - Error in getting credit score";
        public const string ApplicationErrorCode = "ALMS - APPLICATION_ERROR";
        public const string LoanConsolidationErrorCode = "ALMS - LOAN_CONSOLIDATION_ERROR";
        public const string ActionsErrorMessage = "ALMS - Error in getting actions";
        public const string StatusErrorMessage = "ALMS - Error in getting status";
        public const string DebitOrderErrorMessage = "ALMS - Error in getting  valid debit order";
        public const string AccountTypeErrorMessage = "ALMS - Error in getting account type";
        public const string ApplicationDetailsErrorMessage = "ALMS - Error in getting application details";
        public const string FiltersErrorMessage = "ALMS - Error in getting filter conditions";
        public const string ApplicationCreateErrorMessage = "ALMS - Error in creating application";
        public const string UpdateClientErrorMessage = "ALMS - Error in updating client details";
        public const string UpdateBankDetailsErrorMessage = "ALMS - Error in updating bank details";
        public const string BankDetailsNotFoundMessage = "ALMS - Bank details not found";
        public const string ClientDetailsNotFoundMessage = "ALMS - Client details not found";
        public const string EmployerDetailsNotFoundMessage = "ALMS - Employer details not found";
        public const string UpdateEmployerErrorMessage = "ALMS - Error in updating employer details";
        public const string ScoreCardErrorMessage = "ALMS - Error in getting score card";
        public const string HandshakeExecutionErrorMessage = "ALMS - Error while executing handshake";
        public const string FunctionExecutionErrorMessage = "ALMS - Error while executing function";
        public const string SignFlowExecutionErrorMessage = "ALMS - Error while executing sign flow function";
        public const string CardSwipeExecutionErrorMessage = "ALMS - Error while executing card swipe function";
        public const string DebitOrderCreationErrorMessage = "ALMS - Error while creating debit order";
        public const string NuCardIssueErrorMessage = "ALMS - Error issuing NuCard";
        public const string NuCardLoadErrorMessage = "ALMS - Error loading NuCard";
        public const string AffordabilityDetailsNotFoundMessage = "ALMS - Affordability details not found";
        public const string UpdateAffordabilityMessage = "ALMS - Error updating affordability details";
        public const string UpdateDisbursementMessage = "ALMS - Error updating disbursement details";
        public const string UpdateQuotationMessage = "ALMS - Error updating quotation details";
        public const string DeductNuCardMessage = "ALMS - Error in deducting amount from NuCard";
        public const string BalanceNuCardMessage = "ALMS - Error in processing balance card request";
        public const string FnStatementErrorMessage = "ALMS - Error in processing statement request";
        public const string StopCardErrorMessage = "ALMS - Error in processing stop card request";
        public const string CancelStopCardErrorMessage = "ALMS - Error in cancelling stop card request";
        public const string GetApplicationsErrorMessage = "ALMS - Error in getting applications";
        public const string ApplicationsNotFoundErrorMessage = "ALMS - Application details not found";
        public const string LoanTermsCalculationErrorMessage = "ALMS - Error calculating loan terms";
        public const string LoanAmountValidationErrorMessage = "ALMS - Loan amount should be in the range of {0} and {1}";
        public const string LoanAmountValidationFailedMessage = "ALMS - Error in validating loan amount";
        public const string SalaryAmountValidationErrorMessage = "ALMS - Salary should be equal and greater than {0}";
        public const string SalaryAmountValidationFailedMessage = "ALMS - Error in validating salary amount";
        public const string APIFailedMessage = "ALMS - API Failed";
        public const string GetMachineDetailsErrorMessage = "ALMS - Error in getting machine details";
        public const string GetMachineDetailsUnavailableMessage = "ALMS - Machine details unavailable";
        public const string PersonDetailsUnavailableMessage = "ALMS - Person details unavailable";
        public const string GetPersonDetailsErrorMessage = "ALMS - Error in getting person details";
        public const string AddPersonDetailsErrorMessage = "ALMS - Error in adding person details";
        public const string FPEnrollErrorMessage = "ALMS - Error in enrolling finger prints";
        public const string FPVerifyErrorMessage = "ALMS - Error in verifying finger prints";
        public const string FingerPrintVerifyFailedCode = "ALMS - FINGERPRINT_VERIFY_FAILED";
        public const string EMICalculationErrorMessage = "ALMS - Error calculating EMI";
        public const string MasterDataErrorMessage = "ALMS - Error getting master data";
        public const string BranchMasterDataErrorMessage = "ALMS - Error getting branch data";
        public const string MasterDataErrorCode = "ALMS - MASTER_DATA_ERROR";
        public const string MenuListErrorCode = "ALMS - MENU_ERROR";
        public const string MenuListErrorMessage = "ALMS - Error in getting menu list";
        public const string CustomerErrorCode = "ALMS - CUSTOMER_ERROR";
        public const string CustomerDetailsErrorMessage = "ALMS - Error in getting customer details";
        public const string CustomerCreateErrorMessage = "ALMS - Error in creating customer details";
        public const string DocumentUploadErrorMessage = "ALMS - Error in uploading document";
        public const string GetDocumentErrorMessage = "ALMS - Error in getting documents";
        public const string ProvideBankErrorMessage = "ALMS - Please provide bank details";
        public const string ProvideEmployerErrorMessage = "ALMS - Please provide employer details";
        public const string CheckDigitExecutionErrorMessage = "ALMS - Error in executing check digit";
        public const string AVSExecutionErrorMessage = "ALMS - Error in account verification";
        public const string BinCheckExecutionErrorMessage = "ALMS - Error in executing bin check";
        public const string AuthorizationErrorMessage = "ALMS - Error in authorizing user";
        public const string RegistrationFailed = "ALMS - Registration failed.";
        public const string RepaymentRecordNotFound = "ALMS - Repayment record not found";
        public const string RepaymentErrorCode = "ALMS - REPAYMENT_ERROR";
        public const string POSRepaymentErrorCode = "POSError";
        public const string RepaymentDetailsErrorMessage = "ALMS - Error while getting repayment details";
        public const string RepaymentListErrorMessage = "ALMS - Error while getting repayment list";
        public const string RepaymentActionErrorMessage = "ALMS - Error while getting repayment actions";
        public const string RepaymentProcessErrorMessage = "ALMS - Error while processing repayment";
        public const string RepaymentRefundErrorMessage = "ALMS - Error while refunding the repayment";
        public const string RepaymentCreateErrorMessage = "ALMS - Error while creating new repayment request";
        public const string ActionsErrorCode = "ALMS - ACTIONS_ERROR";
        public const string ActionsInvalidMessage = "ALMS - Invalid Action";
        public const string ActionsExecutionFoundMessage = "ALMS - Error while executing action";
        public const string CollectionsErrorCode = "ALMS - COLLECTIONS_ERROR";
        public const string DashboardErrorCode = "ALMS - DASHBOARD_ERROR";
        public const string PrintQuoteExecutionErrorMessage = "ALMS - Error while printing quotation";
        public const string FrameworkErrorCode = "ALMS - FRAMEWORK_ERROR";
        public const string GetUserDetailsMessage = "ALMS - Error fetching user details";
        public const string GetRoleErrorMessage = "ALMS - Error fetching roles";
        public const string GetRegionsErrorMessage = "ALMS - Error fetching regions";
        public const string GetBranchesErrorMessage = "ALMS - Error fetching branches";
        public const string GetUsersErrorMessage = "ALMS - Error fetching users";
        public const string UsersNotFoundErrorMessage = "ALMS - Users not found";
        public const string BranchesNotFoundErrorMessage = "ALMS - Branches not found";
        public const string RolesNotFoundErrorMessage = "ALMS - Roless not found";
        public const string RegionsNotFoundErrorMessage = "ALMS - Regions not found";
        public const string GetBranchDetailsMessage = "ALMS - Error fetching branch details";
        public const string GenerateOTPErrorMessage = "ALMS - Error generating OTP";
        public const string DisbursementNotFoundErrorMessage = "ALMS - Disbusment details not found";
        public const string LoanConsolidationDetailsErrorMessage = "ALMS - LoanConsolidationDetails details not found";
        public const string LoanConsolidationReferenceNoErrorMessage = "ALMS - Duplicate Reference Number found for the same ApplicationID";
        public const string LoanConsolidationDateErrorMessage = "ALMS - Invalid ExpiryDate or NextDebitOrderDate";
        public const string InvalidThirdPartyErrorMessage = "ALMS - Invalid Third Party";
        public const string DeactivatedThirdPartyErrorMessage = "ALMS - Add failed. Third Party is deactivated";
        public const string DetailsNotFoundErrorMessage = "ALMS - Details not found";
        public const string RepaymentReverseErrorMessage = "ALMS - Error while reversing repayment";
        public const string ProcessDisputedRepaymentErrorMessage = "ALMS - Error while Processing Disputed Repayment";
        public const string UserFoundErrorcode = "ALMS - USER_ERROR";
        public const string UserDetailsFoundErrorMessage = "ALMS - User details not found";
        public const string HolidayListErrorMessage = "ALMS - Error in getting holiday list";
        public const string HolidayDeclaringErrorMessage = "ALMS - Error in declaring holidays";
        public const string HolidayCheckErrorMessage = "ALMS - Error in checking holiday";
        public const string NextWorkingDayErrorMessage = "ALMS - Error in getting next working date";
        public const string ContactDetailsErrorMessage = "ALMS - Please update contact details";
        public const string PendingTasks = "ALMS - Pending Tasks";
        public const string PendingTasksMessage = "ALMS - User has pending tasks.";
        public const string BranchEdited = "ALMS - Branch_Edited";
        public const string BranchEditedMessage = "ALMS - Branch edited successfully.";
        public const string BranchEdited_Error = "ALMS - Branch_Edited_Error";
        public const string BranchEditedErrorMessage = "ALMS - Error in Branch edit. Please try again";
        public const string RegionEdited = "ALMS - Region_Edited";
        public const string RegionEditedMessage = "ALMS - Region edited successfully.";
        public const string RegionEdited_Error = "ALMS - Region_Edited_Error";
        public const string RegionEditedErrorMessage = "ALMS - Error in Region edit. Please try again.";
        public const string PassWordRequired = "ALMS - PASSWORD_REQUIRED";
        public const string PassWordRequiredErrorMessage = "ALMS - Could not recognize you. Please login using username and password.";
        public const string BiometricInvalidUsername = "ALMS - BIOMETRIC_INVALID_USERNAME";
        public const string BiometricInvalidUsernameErrorMessage = "ALMS - Invalid username";
        public const string InvalidFirstRepaymentDateErrorCode = "ALMS - INVALID_FIRSTREPAYMENTDATE";
        public const string InvalidFirstRepaymentDateErrorMessage = "ALMS - Invalid first repayment date.";
        public const string MandatoryBeneficiaryDetails = "ALMS - All the required fields are mandatory";
        public const string FutureDateErr = "ALMS - Saving Future Date as Birth Date is not allowed";
        public const string ChildAgeLimit = "ALMS - Beneficiary Child's age is greater than 21";
        public const string TCCTerminalMasterDataErrorMessage = "ALMS - TCC terminals not found";
        public const string UserRoleAndBranchErrorMessage = "ALMS - User role and branch not found";
        public const string EmployerCodeNotFound = "ALMS - Employer codes not found";
        public const string ConsultantPersonIdNotFound = "ALMS - Consultant's person id not found. Please log out and login again.";
        public const string CardAllocationFeesNotFound = "ALMS - Card allocation fees data not found";
        public const string CardAllocationReasonsNotFound = "ALMS - Card allocation reasons not found";
        public const string ChecklistItemsPendingError = "ALMS - Cannot proceed. Ensure all items in checklist are verified.";
        public const string NuCardError = "ALMS - NUCARD_ERROR";
        public const string LGRRefundError = "ALMS - LGRRefund_ERROR";
        public const string PrintTCCSlipExecutionErrorMessage = "ALMS - Error while printing TCC Slip";
        public const string CreateBranchCashAccountErrorMessage = "ALMS - Error in creating branch cash account details";
        public const string CashManagementErrorCode = "ALMS - CashManagement_ERROR";
        public const string CreateBankAccountErrorMessage = "ALMS - Error in creating BankAccount details";
        public const string UpdateBankAccountErrorMessage = "ALMS - Error in updating BankAccount details";
        public const string UpdateBranchCashAccountErrorMessage = "ALMS - Error in updating branch cash account details";
        public const string BranchCashReportListNotFound = "ALMS - BranchCash report list not found";
        public const string BranchCashReportIdRequired = "ALMS - BranchCashReportId is required";
        public const string CreateBranchCashReportErrorMessage = "ALMS - Error in creating BranchCashReport details";
        public const string BranchCashReportErrorMessage = "ALMS - Error in getting BranchCashReport details";
        public const string BranchCashReportSentToHOErrorMessage = "ALMS - Error in updating BranchCashReport details, report already sent to head office";
        public const string BranchCashReportAlreadyApprovedErrorMessage = "ALMS - Error in updating BranchCashReport details, report already approved";
        public const string UpdateBranchCashReportingDateErrorMessage = "ALMS - Error in updating BranchCashReport details, reporting date is invalid";
        public const string CreateBranchCashReportingDateErrorMessage = "ALMS - Error in creating BranchCashReport details, reporting date is invalid";
        public const string BranchCashTransactionNotFound = "ALMS - BranchCashTransaction not found";
        public const string BranchCashTransactionErrorMessage = "ALMS -Error in BranchCashTransactions";
        public const string BranchCashTransactionAccountValidation = "ALMS - Error Account number entered is not valid.";
        public const string BranchCashTransactionExist = "ALMS - Error BranchCashTransaction already exist for entered Account number.";
        public const string LoanConsolidationdetailsErrorMessage = "ALMS -Error in LoanConsolidationdetails";
        public const string LoanConsolidationdetailsNotFound = "ALMS - LoanConsolidationdetails not found";
        public const string NuCardViewError = "ALMS - Error getting NuCard list";
        public const string ClientNotFoundAgainstNuCard = "ALMS - NuCard Not Allocated to any Client";
        public const string ClientFoundAgainstNuCard = "ALMS - NuCard is Allocated to the Client";
        public const string LGRRefundNotFound = "ALMS - LGRRefund details Not Found";
        public const string NuCardDetails = "ALMS - Error getting NuCard Details";
        public const string LGRProcessedRefundDetails = "ALMS - Error While Processed LGRRefund";
        public const string LGRRefundDetails = "ALMS - Error getting LGRRefund Details";
        public const string FundTransferDetails = "ALMS - Error transfering funds";
        public const string NuCardsNotFound = "ALMS - NuCards not found";
        public const string NuCardVoucherNotFound = "ALMS - Voucher number not found";
        public const string NuCardNotValid = "ALMS - Invalid voucher. Ensure card is not blocked or expired.";
        public const string NuCardVoucherOutOfStock = "ALMS - Vouchers out of stock for {0} branch";
        public const string LoggedInUserBranchNotFoundErrorMessage = "ALMS - Logged in user's branch not found";
        public const string DebitOrderCancellationErrorCode = "ALMS - DebitOrderCancellationErrorCode";
        public const string DebitOrderCancellationErrorMessage = "ALMS - Cancellation of Debit Order #Contract_Number registered with NuPay was unsuccessful, please try again later !!";
        public const string SelfApprovalError = "ALMS - Manager can't create and approve the same application";

        public const string AbsaStatusUpdateErrorCode = "ABSA_STATUS_UPDATE_ERROR";
        public const string AbsaStatusUpdateErrorMessage = "Error in Updating ABSA Reply Status";

        // repayment
        public const string DuplicateTransaction = "ALMS - TransactionId not be duplicate";

        #region Biometric error messages
        public const string MachineNotFoundErrorMessage  = "ALMS - Fingerprint machine not found or is configured wrong. Kindly login using username and password.";
        public const string ErrorActivatingMachineErrorMessage = "ALMS - Error activating fingerprint machine. Kindly login using username and password.";
        public const string CouldNotRecognizeErrorMessage = "ALMS - Sorry, we could not recognize you. Kindly login using username and password.";
        public const string FingerPrintServerUnavailableErrorMessage = "ALMS - Fingerprint server is unavailable. Kindly login using username and password.";
        public const string EnrollmentMissing = "ALMS - Sorry, your fingerprint enrolment is not done or is under processing. Kindly login using username and password.";
        public const string PasswordErrorMessage = "ALMS - Please enter password";
        public const string UsernameErrorMessage = "ALMS - Please enter username";
        #endregion

        public const string NaedoUserCredentialsNotFoundErrorCode = "ALMS - NaedoUserCredentialsNotFoundErrorCode";
        public const string NaedoUserCredentialsNotFoundErrorMessage = "ALMS - Naedo User Credentials Not Found";
        public const string BranchNotFound = "ALMS - Branch Not Found";
        public const string NullResultForNaedo = "ALMS - No result from NAEDO service";
        public const string NaedoError= "ALMS - Error in Naedo Transaction";


        public const string SalesPersonNotFound = "ALMS - Sales Person not found";
        public const string ServiceTypeErrorCode = "ALMS - ServiceTypeError";
        public const string ServiceTypeErrorMessage = "ALMS - ServiceType not found";
        public const string TechnicalErrorCode = "ALMS - TECHNICAL";
        public const string TechnicalErrorMessage = "ALMS - Some technical issue.";
        public const string InsuranceErrorCode = "ALMS - INSURANCE_ERROR";
        public const string InsuranceErrorMessage = "ALMS - Getting error in Insurance List";
        public const string InsuranceErrorMessageDetails = "ALMS - Getting error in Insurance Details";
        public const string ClaimErrorMessageDetails = "ALMS - Getting error in Claim Details";
        public const string ClaimNotFoundErrorCode = "ALMS - ClaimNotFoundErrorCode";
        public const string ClaimNotFoundError = "ALMS - Claim Not Found";
        public const string ClaimProcessErrorCode = "ALMS - ClaimProcessCode";
        public const string ClaimProcessError = "ALMS - Error Found while processing claim";
        public const string InsuranceDetailError = "ALMS - Insurance Details not Found";
        public const string NoRecordsFound = "ALMS - No Records found";

        public const string CancelDebitOrderError = "ALMS - Cancel Debit Order Error";
        public const string ThirdPartyConfigurationError = "ALMS - Missing Configurations";
        public const string TerminalNotSelected = "ALMS - TCC Terminal Not Selected";


        public const string InCorrectConsideredNLR = "ALMS - Incorrect Considered NLR Inst";

        public const string InCorrectConsideredCPA = "ALMS - Incorrect Considered CPA Inst";

        public const string InValidEarlySettlementDate= "ALMS - InValid Early Settlement Date";
        public const string DebitCancelErrorMessage = "ALMS - Debit Order not found";
        public const string EarlySettlementError = "ALMS - Early Settlement Error";
        public const string NotAllowedLoanEndDateIsAsOfToday = "ALMS - Not allowed loan end date is as of today";
        public const string LoanEndDateIsInThePast = "ALMS - Loan end date is in the past";
        public const string EarlySettlementDateShouldBeGreaterThanLoanDate = "ALMS - Early settlement date should be greater than loan date";
        public const string EarlySettlementDateEarlierThanTheLastSuccessfulInstallmentRepaymentDate = "ALMS - Early settlement date earlier than the Last Successful Installment Repayment Date";
        public const string YourAccountIsDeactivatedKindlyContactAdministator = "ALMS - Your account is deactivated. Kindly contact administator";

        public const int MaxAddressLengthForCompuscan = 40;
        /* for User Management */
        public const string StaffError = "ALMS - STAFF_ERROR";
        public const string UserNotFound = "ALMS - User not found.";

        public const string UserRegisterErr = "ALMS - Registeration Error";
        public const string UserRegisterErrMsg= "ALMS - Error in Registering User";

        public const string UserRoleError = "ALMS - Role_ERROR";
        public const string UserRoleNotFound = "ALMS - User role already exist.";

        public const string FetchFPDetails = "ALMS - Error in fetching finger print details";

        public const string FPDetailsNotFound = "ALMS - Person details not found";

        public const string OperatorIdExists = "ALMS - OperatorId already exists";

        public const string ErrorFetchingUserTasks = "ALMS - Error in fetching User Tasks From CMS";

        public const string PendingTasksInCMS_Deactivate = "ALMS - DeActivate User is not allowed as User has some pending tasks in CMS";
        public const string PendingTasksInCMS_BranchChange= "ALMS - Branch Change is not allowed as User has some pending tasks in CMS";
        public const string PendingTasksInCMS_DeleteRole = "ALMS - Delete Role is not allowed as User has some pending tasks in CMS";

        public const string NameValidation_Vowel = "ALMS - There must be atleast one vowel or \"Y\" in First Name and Surname.";
        public const string NameValidation_AND = "ALMS - Word \"AND\" is not allowed in name";
        public const string NameValidation_MoreThanOneChar = "ALMS - Name must contains atleast 2 Characters in First Name and Surname";
        public const string NameValidation_SecondCharacterWithoutSpace = "ALMS - Space is only allowed after 2 characters in First Name and Surname";
        public const string NameValidation_ThreeConsecutiveAlphabet = "ALMS - 3 Consecutive identical alphabets are not allowed in First Name and Surname";
        public const string NameValidation_SpecialCharacters = "ALMS - Special Characters are not allowed in First Name and Surname";
        public const string NameValidation_Numbers = "ALMS - Numbers are not allowed in First Name and Surname";
        public const string NameValidation_Empty = "ALMS - Invalid Name: Name is Empty";


        public const string BranchError = "ALMS - Branch_ERROR";
        public const string BranchDetailsNotProvided = "ALMS - BranchDetails not provided";
        public const string CompanyDetailsNotProvided = "ALMS - CompanyDetails not provided";
        public const string RequiredBranchDetails = "ALMS - BranchName,LegacyBranchCode,Region,Branch EmailId,OpenDate is required";
        public const string RequiredCompanyDetails = "ALMS - NCR_Registration_No,VAT_Registration_No is required";
        public const string RequiredAffordabilityDetails = "ALMS - affordability details not provided";
        public const string BranchIdValidation = "ALMS - BranchId is required";
        public const string TCCTerminalDetailsNotProvided = "ALMS - TCC Terminal details not provided";
        public const string RequiredTCCTerminalDetails = "ALMS - BranchId,TerminalId and POSMerchant is required";
        public const string ThirdPartyConfigurationValidation = "ALMS - Third party configuration details not provided";
        public const string ThirdPartyConfigRequiredDetails = "ALMS - Please provide branch,creditscore,nucard,NAEDO,AEDO service details";
        public const string CreditScoreConfigRequiredDetails = "ALMS - UserName and Password is required to configure CreditScore";
        public const string NucardConfigRequiredDetails = "ALMS - UserName,Password,MerchantId,AppId,ProfileId is required to configure NuCard";
        public const string NAEDOConfigRequiredDetails = "ALMS - Load,Cancel and Receipt credentials required to configure NAEDO";
        public const string NAEDO_LoadConfigValidations = "ALMS - UserName,Password,MerchantId is required for NAEDO load configurations";
        public const string NAEDO_CancelConfigValidations = "ALMS - UserName,Password,MerchantId is required for NAEDO Cancel configurations";
        public const string NAEDO_ReceiptConfigValidations = "ALMS - UserName,Password,MerchantId is required for NAEDO Receipt configurations";
        public const string AEDOConfigRequiredDetails = "ALMS - Cancel credentials required to configure AEDO";
        public const string AEDO_CancelConfigValidations = "ALMS - UserName,Password,MerchantId is required for AEDO Cancel configurations";
        public const string AEDO_ReceiptConfigValidations = "ALMS - UserName,Password,MerchantId is required for AEDO Receipt configurations";
        public const string CreditScore_MasterEntry = "ALMS - Master entry does not exist for credit score";
        public const string AVSCheck_MasterEntry = "ALMS - Master entry does not exist for AVS Check";
        public const string NuCard_MasterEntry = "ALMS - Master entry does not exist for NuCard";
        public const string NAEDO_MasterEntry = "ALMS - Master entry does not exist for Naedo";
        public const string AEDO_MasterEntry = "ALMS - Master entry does not exist for Aedo";
        public const string RealPayDebiCheck_MasterEntry = "ALMS - Master entry does not exist for RealPay DebiCheck";

        public const string UserSelfEdit = "ALMS - User is not allowed to update own details";

        public const string UniqueLegacyBranchNumError = "ALMS - Legacy branch code already exists";
        public const string UniqueMerchantIdError = "ALMS - Merchant Id already exists";
        public const string UniqueNaedoCancelMerchantIdError = "ALMS - Merchant Id already exists for cancel NAEDO";
        public const string UniqueNaedoRecieptMerchantIdError = "ALMS - Merchant Id already exists for receipt NAEDO";
        public const string UniqueNaedoLoadMerchantIdError = "ALMS - Merchant Id already exists for load NAEDO";
        public const string UniqueAedoLoadMerchantIdError = "ALMS - Merchant Id already exists for AEDO";
        public const string UniqueAedoReceiptMerchantIdError = "ALMS - Merchant Id already exists for AEDO";
        public const string UniqueNucardMerchantIdError = "ALMS - Merchant Id already exists for Nucard";
        public const string UniqueAVSCheckMerchantIdError = "ALMS - Merchant Id already exists for AVS Check";
        public const string SelectValidPropertyOwnership = "ALMS - Please select valid property ownership option";

        public const string SignFlowSuccess = "signed";

        public const string NuPayExcel_ValidationXLSX= "ALMS - File should be in XLSX format";
        public const string NuPayExcel_ValidationDuplicateFile = "ALMS - Duplicate File";
        public const string NuPayExcel_Invalid = "ALMS - Columns Names are either Invalid or not in the proper sequence";

        public const string NuPayExcel_DuplicateSequence = "ALMS - Processing of Duplicate Sequence Number is not allowed";
        public const string NuPayExcel_EmptyData = "ALMS -No Records found in excel";

        public const string NuCardBatchErrorCode = "NUCARD_BATCH_ERROR";
        public const string NoBatchFoundError = "ALMS - Batches not found";
        public const string ProvideLastVNOrCountNuCardBatchError = "ALMS - Please provide last voucher number or total number of vouchers";
        public const string ProvideFirstVNNuCardBatchError = "ALMS - Please provide first voucher number";
        public const string MaxVNAllowedPerBatchFoundError = "ALMS - Maximum {0} vouchers can be transferred at a time";
        public const string VNNotFoundInSelectedRangeError = "ALMS - No vouchers found in the selected range";
        public const string NuCardBatchCreateError = "ALMS - Error in creating new batch";
        public const string dateOfBirthErr = "ALMS - Date Of Birth is Required";
        public const string compuScoreRequired = "ALMS - {0} is required for GetScore";
        public const string BatchValidationFailedError = "ALMS - Voucher validation failed. Please validate vouchers again";
        public const string BatchValidationFailedError2 = "ALMS - Transfer Failed - Voucher number {0} in the given range is not in 'Not Set' status";
        public const string NuCardNotAssCustomer = "ALMS - This is an ASS client. Card cannot be managed from ALMS.";
        public const string RequiredCellNumber = "ALMS - Cell Number is required for replacing the card";
        public const string ReissueReasonNotSelected = "ALMS - Select reason to issue new card";
        public const string RepaymentReverseEarlySettleErrorMessage = "ALMS - Repayment can not be reverse. Account has been early settled.";
        public const string RepaymentReverseRollOverErrorMessage = "ALMS - Repayment can not be reverse. Account has been Internal Consolidated.";
        public const string RepaymentReverseNotLatestRepaymentErrorMessage = "ALMS - Repayment can not be reverse.";
        public const string RepaymentReversehandoverRepaymentErrorMessage = "ALMS - Repayment can not be reverse. Account has been handed over.";

        public const string AccPaccDisbursementErrorMessage = "ALMS - Error while updating disbursement entries.";
        public const string NuCardAccountErrorMessage = "ALMS - Error while creating NuCard account.";
        public const string NuCardClientMapAccountErrorMessage = "ALMS - Error while updatig NuCard account mapping entries.";

        public const string AccPaccStatusCode = "ALMS - ACCPACC_ERROR";
        public const string AccPaccRunProcessStatusNotFoundError = "ALMS - AccPacc Run Process Status list not found.";
        public const string AccPaccRunProcessStatusError = "ALMS - Error in getting AccPacc Run Process Status list.";
        public const string AccPaccTransactionsNotFoundError = "ALMS - AccPacc transaction list not found.";
        public const string AccPaccTransactionssError = "ALMS - Error in getting AccPacc transaction list.";

        public const string VAPRepaymentErrorMessage = "ALMS - Repayment not allowed for VAP account.";

        public const string GenerateAccPaccSuccessMessage = "Your request to generate accpac is accepted with BatchId {0}, Once the process is finished we will notify you by email.";
        public const string GenerateAccPaccFailedMessage = "Your request to generate accpac can not be processed at this moment as accpac with BatchId {0} is already in progress.";

        public const string CancelLoanErrorMessage = "ALMS - Error executing CancelLoan process.";
        public const string CancelNotAllowedErrorMessage = "ALMS - Repayment found. Loan Cancellation not allowed.";

        public const string ChangePassValidationFailed = "ALMS - Password Confirmation failed";

        public const string DayEndReportError = "ALMS - DAYENDREPORT_ERROR";
        public const string DayEndReportListErrorMessage = "ALMS - Error while getting day end report";
        public const string DayEndReportErrorMessage = "ALMS - Error while saving day end report details";
        public const string CashInHandAccountNotFoundErrorMessage = "ALMS - No Cash In Hand account found for branch";
        public const string CashInHandAccountRepaymentErrorMessage = "ALMS - Error while processing repayment";
        public const string CreateBranchCashTransactionErrorMessage = "ALMS - Error while processing Branch CashTransaction";
        public const string TaxAmountTransactionErrorMessage = "ALMS - Tax amount should not be greater than transaction amount";
        public const string ApplicationAssignedErrorMessage = "ALMS - Error while assigning application.";
		    public const string ApplicationSubmitErrorMessage = "Error in submitting Application";
        public const string IDnotFoundCode = "ID_NOT_FOUND_ERROR";
        public const string IDnotFound = "Application ID not found";
        public const string DebiCheckError = "ALMS - Error while Executing Debicheck";
        public const string DebitModeIdErrorMessage = "ALMS - Incorrect debit mode id.";
        public const string ThirdPartyConfigErrorMessage = "ALMS - Debi Check  credentials not found.";
        public const string DebiCheckStatusErrorMessage = "ALMS - Error while checking debit order status";
        public const string DebiCheckStatusErrorCode = "ALMS - DEBITORDER_ERROR";
        public const string ThirdPartyConfigErrorCode = "ALMS - DEBICHECK_CREDENTIALS_NOTFOUND";

        public const string DayEndApprovalListErrorMessage = "ALMS - Error while getting approval list.";
        public const string ValidationruleForEarlySettlement = "Internal Consolidation not allowed for";
        public const string RolloverNotAllowed = "Internal Consolidation not allowed - ";
        public const string RolloverAllowed = "Internal Consolidation allowed for - ";

        public const string NuCardConfigErrorMessage = "ALMS - NuCard config credentials not found";
        public const string NuCardConfigErrorCode = "ALMS - NUCARD_CREDENTIALS_NOT_FOUND";

        public const string IntegrationLogErrorCode = "ALMS - INTEGRATION_LOG_ERROR";
        public const string IntegrationLogErrorMessage = "ALMS - Error in getting Logs";
        public const string IntegrationLogStatusErrorMessage = "ALMS - Error in updating Integration Log status";
      
        public const string ContactSystemAdmin = "ALMS - Error while processing account. Kindly contact administator";

        public const string CreatePaymentPlanErrorCode = "ALMS - PAYMENT_PLAN_ERROR";
        public const string CreatePaymentPlanErrorMessage = "ALMS - Error while creating Payment Plan";

        public const string VapCancelWithoutChangeDebitOrderCode = "ALMS - Vap_Cancel_Without_ChangeDebitOrder";
        public const string VapCancelWithoutChangeDebitOrderMessage = "ALMS - Error while Vap Cancel Without ChangeDebitOrder";



        public const string ChangeDebitOrderErrorCode = "ALMS - CHANGE_DEBIT_ORDER_ERROR";
        public const string GetChangeDebitOrderErrorMessage = "ALMS - Error while getting ChangeDebitOrder details";
        public const string ChangebankdetaiExecutionErrorMessage = "ALMS - Error in executing Change BankDetail";
        public const string SubmitChangeDebitOrderErrorMessage = "ALMS - Error while Changing DebitOrder";
        public const string BankDetailschangesChangeDebitOrderErrorMessage = "ALMS - Either BankDetail changes OR PaymentPlan changes are required";
        public const string PaymentPlanChangeDebitOrderErrorMessage = "ALMS - PaymentPlan is already created for AccountId: {0}";
        public const string ChangeBankDetailPendingErrorMessage = "ALMS - Cannot proceed. Ensure AVS-Check, Check-digit are verified.";

        public const string InvalidClientIdErrorMessage = "ALMS - Invalid Client Id.";
        public const string InvalidApplicationIdErrorMessage = "ALMS - Invalid Application Id.";

        public const string InsuredCountBeneficiaryDetails = "ALMS - You can add only five family members";

        public const string contactAdminstrator = "Something went wrong.Please contact system administrator.";

        public const string ProductConfigErrorCode = "ALMS - PRODUCT_ERROR";
        public const string ProductConfigErrorMessage = "ALMS - Error while getting product config list.";

        public const string ProductErrorcode = "ALMS - PRODUCT_ERROR";
        public const string ProductsNotFoundErrorMessage = "ALMS - Products not found";
        public const string GetProductErrorMessage = "ALMS - Error fetching Products";
        public const string DocumentErrorcode = "ALMS - DOCUMENT_ERROR";
        public const string DocumentErrorMessage = "ALMS -Error while getting document list";

        public const string BranchProductConfigErrorCode = "ALMS - BRANCH_PRODUCT_MAPPING_ERROR";
        public const string BranchProductConfigErrorMessage = "ALMS - Error while getting branch product list.";

        public const string CompanyProductConfigErrorCode = "ALMS - COMPANY_PRODUCT_CONFIG_ERROR";
        public const string CompanyProductConfigErrorMessage = "ALMS - Error while getting company's product config list.";

        public const string RequestCanNotBeNullErrorMessage = "ALMS - Request can not be null";

        public const string NuCardScheulesErrorMessage = "ALMS - Error in generating NuCard account schedules";

        public const string TerminalFounfFoundErrorMessage = "ALMS - Terminal details not found";
        public const string NuCardAccountNotFoundErrorMessage = "ALMS - NuCard Account not found";
        public const string InvalidCardFeesErrorMessage = "ALMS - Invalid card fees";
        public const string CustomerDetailsForDebitOrderErrorMessage = "ALMS - Error while getting customer details";
        public const string ManualSignExecutionErrorMessage = "ALMS - Error while signing document manually";
        public const string SkipStatus = "Skip";

        public const string NuCardBlockedErrorMessage = "ALMS - Card is blocked.";
        public const string NuCardExpiredErrorMessage = "ALMS - Card is expired.";
        public const string NuCardVoucherNotFoundErrorMessage = "ALMS - Voucher not found";
        public const string AtlasDocumentCopyType = "Atlas";
        public const string ClientDocumentCopyType = "Client";
        public const string RepaymentCreateTransactionIdErrorMessage = "ALMS - Error: This installment has already been Paid for this AccountId ";
        public const string RepaymentCreateHandedOverErrorMessage = " Repayment mode is not allowed on Handover Account";
        public const string RepaymentCreateinstallmentErrorMessage = "ALMS - Error: This installment No. has already been Paid or invalid  for this AccountId ";

        public const string ProductResetCacheErrorMessage = "ALMS - Can not reset cache in working hours. Please contact system administrator";
    
        public const string BranchCashPreviousReportErrorMessage = "ALMS - Please send previous day report to HO";



        public const string DebiTOrderRequestErrorMessage = "ALMS - Error while creating debit order request";
        //public const string RepaymentCreateTransactionIdErrorMessage = "ALMS - Error: This installment has already been Paid for this AccountId ";
        //public const string RepaymentCreateinstallmentErrorMessage = "ALMS - Error: This installment No. has already been Paid or invalid  for this AccountId ";
        #region nupay card validation
        public const string NucardStolenErrorCode = "NUCARD_STOLEN";
        public const string NucardStolenErrorMessage = "Nupay - Card has been stolen.";
        public const string NucardvalidErrorCode = "NUCARD_VALID";
        public const string NucardvalidErrorMessage = "Nupay - Card is not valid.";
        public const string NucardlostErrorCode = "NUCARD_LOST";
        public const string NucardlostErrorMessage = "Nupay - Card has been lost.";
        public const string NucardexpiredErrorCode = "NUCARD_EXPIRED";
        public const string NucardexpiredErrorMessage = "Nupay - Card has been expired.";
        public const string NucardcancelledErrorCode = "NUCARD_CANCELLED";
        public const string NucardcancelledErrorMessage = "Nupay - Card has been cancelled.";
        public const string NucardstoppedErrorCode = "NUCARD_STOPPED";
        public const string NucardstoppedErrorMessage = "Nupay - Card has been stopped.";
        public const string NucardactivatedErrorCode = "NUCARD_ACTIVATED";
        public const string NucardactivatedErrorMessage = "Nupay - Card is not activated.";
        public const string NupayThirdPartyMessage = "Nupay - ";






        #endregion

        public const string CardNumberRequiredErrorMessage = "ALMS - Card number is required on bank details.";

        public const string NuCardIssueCustomerErrorMessage = "ALMS - Card is already issued to customer";
        public const string NuCardAssignedErrorMessage = "ALMS - Card is already assigned to customer";

        public const string ApplicationStatusErrorMessage = "ALMS - Error while getting application status";
        public const string ApplicationDebitOrderErrorMessage = "ALMS - Application debit order is not yet approved";

        public const string MandateNotFoundErrorMessage = "ALMS - Mandate not found";
        public const string UniqueTerminalIdError = "ALMS - Terminal Id already exists";

        public const string NuCardInvalidErrorMessage = "ALMS - Card may be lost / stolen / stopped.";



        public const string EarlySettlementOfferErrorCode = "ALMS - EARLYSETTLEMENTOFFERS_ERROR";
        public const string EarlySettlementOfferErrorMessage = "ALMS - Error while Getting EarlySettlement Offers list";

        public const string AutoWriteOffErrorCode = "ALMS - AUTO_WRITEOFF_ERROR";
        public const string AutoWriteOffErrorMessage = "ALMS - Error while executing Auto Write-off";
        public const string MicroFinanceListNotFound = "ALMS - MicroFinance records not found";
        public const string MicroFinanceErrorcreatingMessage = "ALMS - Error creating MicroFinance for AccountNo";
        public const string MicroFinanceErrorMessage = "ALMS - Error in getting MicroFinance details";
        public const string MicroFinanceExistErrorMessage = "ALMS - Error MicroFinance detail is already exist for AccountNo -";
        public const string MicroFinanceErrorCode = "ALMS - MicroFinance_ERROR";
        public const string MicroFinanceApprovedErrorMessage = "ALMS - MicroFinance is not Approved";
        public const string LoanConsolidationallowedErrorMessage = "ALMS - LoanConsolidation not allowed for this Product:- ";
        public const string LoanConsolidateEndDateIsInThePast = "ALMS - LoanConsolidation ExpiryDate or NextDebitOrderDate is in the past";
        public const string LoanConsolidationDisbursementMessage = "Application has been marked for disbursement. This Process may take up to 4 hours if the bank details need to be approved";
        public const string LoanConsolidationPayableAmountInvalidMessage = "ALMS - Invalid Payable Amount (PayableAmount should be equal to LoanConsolidationAmount)";
        public const string LoanConsolidationLoanAmountInvalidMessage = "ALMS - Invalid LoanAmount or LoanConsolidationAmount";
        public const string DisbursedMessage = "This loan application is disbursed";

        public const string AVSCheckErrorCode = "ALMS - AVS_CHECK_ERROR";

        public const string SalesAgentCode = "AgentCode already exists";
        public const string SalesAgentIdNumber = "IDNumber already exists";
        public const string SalesAgentError = "ALMS - SALES_AGENT_ERROR";
        public const string SalesAgentNotFound = "ALMS - Sales Agent not found.";
        public const string SalesAgentsValidate = "ALMS - Mandatory Fields - AgentCode,FirstName,LastName,DateEngaged,IdNumber";

        public const string RefundDetailsNotFound = "ALMS - Refund Details Not  Found";
        public const string ReinitiateSystemDayEndProcess = "System balance have changed, please reinitiate End Of Day process";
        public const string ReinitiateUserDayEndProcess = "User Reported balance is not match with System balance, please reinitiate End Of Day process";
        #region //Campaign Manager 
        public const string CampaignManagerError = "CAMPAIGN - ERROR";
        public const string CampaignManagerTemplateError = "CampaignManagerTemplateError ";
        public const string ReferrerViewNotFound = "Referrer not found";
        public const string ReferrerViewError = "Erron in getting Referrer details";
        public const string ReferAndEarnViewDataNotFound = "No data found";
        public const string ReferAndEarnViewError = "Error in getting Refer & Earn list data";
        public const string UpdateAgentCodeInApplicationError = "Error in updating Agent Code in Application";
        public const string CustomerEarningsError = "Error in getting information about customer earnings";
        public const string CampaignManagerErrorMessage = "No Campaign Available";


        #endregion


        public const string BatchSaveError = "Error while saving the Batch Details";
        public const string PayableAmountUpdateError = "ALMS - Error while updating Payable Amount";
        public const string IncorrectPayableAmount = "ALMS - Incorrect Payable amount received";
        public const string OccupationCodeNotFound = "ALMS - OccupationCode records not found";
        public const string OccupationCodeFound = "ALMS - OccupationCode records already exists";
        public const string OccupationCodeRequiredNotFound = "ALMS - Occupation details required";
        public const string UpdateOccupationErrorMessage = "ALMS - Error in updating Occupation details";
        public const string EmployerCodeFound = "ALMS - EmployerCode already exists";
        public const string EmployerCodeRequiredNotFound = "ALMS - EmployerCode details required";
        public const string UpdateEmployerCodeErrorMessage = "ALMS - Error in updating EmployerCode details";
        public const string RefundwriteoffValidReason = "ALMS - Please select a valid reason for Refund Write off";
        public const string RepaymentwriteoffValidReason = "ALMS - Please select a valid reason for Repayment Write off";

        public const string DelinquentCustomerErrorMessage = "ALMS - Can not create application as this Client is Delinquent";
        public const string ConsultantFingerPrintOnCustomerError = "ALMS - Error in capturing fingerprint";

        public const string AtlasBudgetingErrorCode = "ALMS - ATLAS_BUDGETING_ERROR";
        public const string AtlasBudgetingErrorMessage = "ALMS - Please upload valid AtlasBudgeting Excel file";
        public const string ProcessBalanceTransferErrorMessage = "ALMS - Error while Processing Balance Transfer Refund";
        public const string BalanceTransferDetailsErrorMessage = "ALMS - Error while updating Balance Transfer details";
        public const string BalanceTransferErrorMessage = "ALMS - Error while Creating Balance Transfer details";
        public const string BalanceTransferDetailsMessage = "ALMS - Error while getting Balance Transfer details";
        public const string BalanceTransferFromACC_TOACCMessage = "ALMS - Error Credit Balance Amount Cannot be transferred to same Account";
        public const string GeneratesaccraSuccessMessage = "Your request to generate sacrra is accepted with BatchId {0}, Once the process is finished you can download file.";
        public const string GeneratesaccraFailedMessage = "Your request to generate sacrra can not be processed at this moment as saccra with BatchId {0} is already in progress.";

        public const string DisputeInfoErrorMessage = "ALMS - Error in getting dispute details";
        public const string RepaymentNotProcess = "ALMS - This Repayment can not process because another repayment is pending for processing.";
        public const string RepaymentProcessErrorCode = "ALMS - REPAYMENT_VALIDATION";

        public const string FaultyNuCardCancelErrorMessage = "Sorry! Nucard couldn't cancel due to outstanding balance 0 for a faulty Nucard reason.";
        public const string FaultyNuCardWriteOffErrorMessage = "Sorry! Nucard couldn't writeoff due to outstanding balance 0 for a faulty Nucard reason";

        public const string UpdateRepaymentSchedulesFailed = "ALMS - Updating Repayment status in Schedules failed";
        public const string IDLPAccountApprovalPending = "ALMS - Overdue Interest Discount is already applied on this account and it is in under approval state";
        public const string IDLPAccountApproved = "ALMS - Overdue Interest Discount is already applied on this account";

        public const string IDLPDiscountError = "ALMS - Overdue Interest Discount";
        public const string IDLPDiscountValidation = "ALMS - Overdue Interest Discount cannot be greater then actual Overdue Interest amount accrued";
        public const string AdditionalFeeValidation = "ALMS - Overdue Service Fee cannot be greater then actual Overdue Service accrued";
        public const string RepaymentIDLPAmountValidationErrorMessage = "ALMS - Error: Amount entered is less then the Repayment amount with Overdue Interest amount  ";
        public const string IDLPExtensionValidation = "ALMS - Error: No Pending Overdue Interest Amount left for Installment Extension";
        
        //Add and Resubmit Instalment start
        public const string ExtensionValidation = "ALMS - Error: Last Schedule is not Failed Or wrong Last Installment no";
        public const string DebiCheckRescheduleAPIError = "ALMS - Error in Resubmit";
        public const string DebiCheckAddAPIError = "ALMS - Error while Executing Debicheck Add API";
        public const string ResubmitValidation = "ALMS - Error: Selected Installment is not Failed";

        public const string IDLPInactive = "ALMS - Error: Overdue Interest is inactive";
        public const string DebiCheckExtensionAPIError = "ALMS - Error while Executing Debicheck API Extension";
        

        public const string IDLPValidationForEarlySettled = "Early Settlement is Invalid on Overdue Interest";

        public const string MockCreditScoreError = "ALMS - Kindly mapped the Mocked CreditScore";

        public const string CreditScoreApprovalMessage = "ALMS - Application is send to Authorized person for approval";

        public const string CreditScoreApprovalErrorMessage = "ALMS - Failed while sending for approval";

        public const string MandateExistErrorMessage = "ALMS - Mandate already exist";

        public const string RejectApplication = "REJECT";

        public const string EasyDebitAVSError = "ALMS-EASYDEBITERROR";

        public const string RealPayError = "ALMS - REALPAYERROR";

        public const string RealPayThirdPartyError = "REALPAYERROR";

        public const string MandateAccountlinkErrorMessage = "ALMS - Mandate not link with AccountId";

        public const string EasyDebitErrorCode = "EASY DEBIT ERROR";

        public const string EasyDebitOneParameterErrorMessage = "EasyDebit - Error while comparing following parameter - ";

        public const string EasyDebitParameterErrorMessage = "EasyDebit - Error while comparing parameters";

        public const string SKYQRError = "ALMS - SKYQR ERROR";

        public const string MandateDelinkedSuccess = "Mandate Delinked Successfully";

        public const string MandateAlreadyLinkedErrorMessage = "ALMS - Mandate already Linked to another AccountID";

        public const string MandateDelinkedErrorMessage = "ALMS - Only manually linked mandates can be delinked";

        public const string TransUnionTicketNotFound = "ALMS - TransUnion TicketNo not found";

        public const string FlashLoanAutoSavingErrorMessage = "ALMS - Error while Autosaving the Flash Loan";

        public const string FlashLoanDurationValidationErrorMessage = "ALMS - Loan duration exceeds the maximum limit.";

        public const string FlashLoanDurationValidationSaveErrorMessage = "ALMS - Loan duration exceeds the maximum limit";

        public const string LoadRefundAmountInNucard = "ALMS- LOADREFUNDNUCARD";
        public const string LoadRefundAmountInNucardErrorMessage = "ALMS- LOADREFUNDNUCARD Failed";

        public const string LoadRefundAmountLimit = "ALMS- Refund Disbursement Limit Exceeded";
        public const string LoadRefundBankNotSupport = "The Bank does not support EFT AUTO please select another Mode";
        public const string ExpressLoanAutoSavingErrorMessage = "ALMS - Error while Autosaving the Express Loan";
        public const string RealPayMandateApproveMessage = "Mandate is approved";
        public const string RealPayMandateNotApproveMessage = "Mandate is not approved yet";
        public const string CompanyExist = "Company Already Exist";
        public const string CompanyAlreadyExist = "User already have this Company";
        public const string InValidCompany = "ALMS - Incorrect Company selected";
        public const string AutomateRefundFailed = "Automate Refund Failed";
        public const string AutomateRefundFailedMessage = "Automate Refund Process Failed";
        public const string PartialSuccess = "PartialSuccess";

    }
}