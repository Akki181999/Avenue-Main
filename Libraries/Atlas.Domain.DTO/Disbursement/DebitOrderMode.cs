using Atlas.Domain.DTO.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Disbursement
{
    public class DebitOrderMode
    {
        public DebitOrderModesDTO LastDebitOrder { get; set; }
        public List<DebitOrderModesDTO> AllowedDebitOrderModes { get; set; }
    }

    public class DebitOrderRequest
    {
        public int DebitOrderModeId { get; set; }
        public string TCCTerminalID { get; set; }
        public int AttemptCount { get; set; }
    }

    public class DebitOrderCustomerDetails
    {
        public int ApplicationId { get; set; }
        public int AccountId { get; set; }
        public int BranchId { get; set; }
        public int ClientId { get; set; }
        public string IDNumber { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal RepaymentAmount { get; set; }
        public decimal TotalInstallment { get; set; }
        public int QuantityInstallments { get; set; }
        public bool VAP { get; set; }
        public DateTime? FirstRepayDate { get; set; }
        public int SalaryType { get; set; }
        public int PayDay { get; set; }
        public string EmployCode { get; set; }
        public string SalaryTypeDescription { get; set; }
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public int AccountTypeId { get; set; }
        public string AccountType { get; set; }
        public string CardNumber { get; set; }
        public int BankId { get; set; }
        public string Code { get; set; }
        public int FinancialInstitutionId { get; set; }
        public string ResidentialAddressLine1 { get; set; }
        public string ResidentialAddressLine2 { get; set; }
        public string ResidentialAddressLine3 { get; set; }
        public string ResidentialAddressLine4 { get; set; }
        public string ResidentialAddressPostalCode { get; set; }
        public string TCCTerminalID { get; set; }
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public decimal PayableAmount { get; set; }
        public long RollOverAccountId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public int RealPayBankId { get; set; }

        public string NuCardNumber { get; set; }
        public string BeneficiaryUser { get; set; }
        public long ParentFlashLoanAccountId { get; set; }

        //Future VAP Cancel
        public bool IsVAPCancel { get; set; } = false;
    }

    public class Modes
    {
        public DebitOrderMode debitOrderMode { get; set; }
        public DisbursementMode DisbursementMode { get; set; }
    }

    
}