using System;

namespace Pioneer.Accident.Service.Model
{
    public class Lead
    {
        public int Id { get; set; }

        public DateTime GeneratedDate { get; set; }

        public string Status { get; set; }

        public bool SingleOwnership { get; set; }

        public int Amount { get; set; }

        public int Age { get; set; }

        public int Period { get; set; }

        public bool CriticalIllness { get; set; }

        public int InsuranceTypeId { get; set; }

        public int PremiumTypeId { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public string HomePhone { get; set; }

        public string WorkPhone { get; set; }

        public bool Smoker { get; set; }

        public int MortgageTypeId { get; set; }

        public int MortgageRateId { get; set; }

        public int MortgageRepaymentId { get; set; }

        public int MortgagePropertyLocationId { get; set; }

        public int MortgagePropertyTypeId { get; set; }

        public int MortgageCreditHistoryId { get; set; }

        public int? MortgagePropertyValue { get; set; }

        public int? CurrentDebt { get; set; }

        public int? MortgageAnnualIncome { get; set; }

        public bool MortgageMissedLoan { get; set; }

        public bool HadBankruptcy { get; set; }

        public bool AppliedIva { get; set; }

        public bool HadCcj { get; set; }

        public int? MortgageLoanValue { get; set; }

        public int? LoanPurposeId { get; set; }

        public int? EmploymentStatusId { get; set; }

        public bool HomeOwner { get; set; }

        public int? MortgageBalance { get; set; }

        public int? LoanMaritalStatusId { get; set; }

        public int? LoanCountryOfResidenceId { get; set; }

        public int? LoanAnnualIncome { get; set; }

        public int? LoanCreditRatingId { get; set; }

        public string TotalCreditors { get; set; }

        public DateTime AddressStartDate { get; set; }

        public bool GetLoanGuarantor { get; set; }

        public bool BeenInDebt { get; set; }

        public string Occupation { get; set; }

        public string EmployerName { get; set; }

        public DateTime? EmployedSince { get; set; }

        public string PreviousAddress { get; set; }  /* TO DO NEW */

        public string PreviousCity { get; set; }     /* TO DO NEW */

        public string PreviousPostCode { get; set; }  /* TO DO NEW */

        public DateTime? PreviousAddressSince { get; set; }   /* TO DO NEW */

        public int SiteId { get; set; }

        public string Email { get; set; }

        public string QueryStr { get; set; }

        public string Source { get; set; }

        public string Keyword { get; set; }

        public string IpAddress { get; set; }

        public string Match { get; set; }

        public bool Opt { get; set; }

        public string GuarantorName { get; set; }

        public string GuarantorPhone { get; set; }

        public string GuarantorEmail { get; set; }
    }
}