using System;
using System.Data.Linq.Mapping;

namespace Pioneer.Accident.Service.Data
{
    [Table(Name = "dbo.Lead")]
    public class Lead
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.OnInsert)]
        public int Id { get; set; }

        [Column]
        public DateTime GeneratedDate { get; set; }

        [Column]
        public string Status { get; set; }

        [Column]
        public bool SingleOwnership { get; set; }

        [Column]
        public int Amount { get; set; }

        [Column]
        public int Age { get; set; }

        [Column]
        public int Period { get; set; }

        [Column]
        public bool CriticalIllness { get; set; }

        [Column]
        public int InsuranceTypeId { get; set; }

        [Column]
        public int PremiumTypeId { get; set; }

        [Column]
        public string Title { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        [Column]
        public string Address1 { get; set; }

        [Column]
        public string City { get; set; }

        [Column]
        public string PostCode { get; set; }

        [Column]
        public string HomePhone { get; set; }

        [Column]
        public string WorkPhone { get; set; }

        [Column]
        public DateTime Dob { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public bool Smoker { get; set; }

        [Column]
        public int SiteId { get; set; }

        [Column]
        public int? MortgageTypeId { get; set; }

        [Column]
        public int? MortgageRateId { get; set; }

        [Column]
        public int? MortgageRepaymentId { get; set; }

        [Column]
        public int? MortgagePropertyLocationId { get; set; }

        [Column]
        public int? MortgagePropertyTypeId { get; set; }

        [Column]
        public int? MortgageCreditHistoryId { get; set; }

        [Column]
        public int? MortgagePropertyValue { get; set; }

        [Column]
        public int? MortgageCurrentDebt { get; set; }

        [Column]
        public int? MortgageAnnualIncome { get; set; }

        [Column]
        public bool MortgageMissedLoan { get; set; }

        [Column]
        public bool HadBankruptcy { get; set; }

        [Column]
        public bool AppliedIva { get; set; }

        [Column]
        public bool HadCcj { get; set; }

        [Column]
        public int? MortgageLoanValue { get; set; }

        [Column]
        public int? LoanPurposeId { get; set; }

        [Column]
        public bool? HomeOwner { get; set; }

        [Column]
        public int? MortgageBalance { get; set; }

        [Column]
        public int? EmploymentStatusId { get; set; }

        [Column]
        public int? LoanMaritalStatusId { get; set; }

        [Column]
        public int? LoanCountryOfResidenceId { get; set; }

        [Column]
        public int? LoanAnnualIncome { get; set; }

        [Column]
        public int? LoanCreditRatingId { get; set; }

        [Column]
        public string TotalCreditors { get; set; }

        [Column]
        public DateTime AddressStartDate { get; set; }

        [Column]
        public bool LoanGuarantor { get; set; }

        [Column]
        public bool BeenInDebt { get; set; }

        [Column]
        public string Occupation { get; set; }

        [Column]
        public string EmployerName { get; set; }

        [Column]
        public DateTime? EmployedSince { get; set; }

        [Column]
        public string PreviousAddress { get; set; }  /* TO DO NEW */

        [Column]
        public string PreviousCity { get; set; }     /* TO DO NEW */

        [Column]
        public string PreviousPostCode { get; set; }  /* TO DO NEW */

        [Column]
        public DateTime? PreviousAddressSince { get; set; }   /* TO DO NEW */

        [Column]
        public string QueryStr { get; set; }

        [Column]
        public string Source { get; set; }

        [Column]
        public string Keyword { get; set; }

        [Column]
        public string IpAddress { get; set; }

        [Column]
        public string Match { get; set; }

        [Column]
        public string AdditionalInformation { get; set; }

        [Column]
        public bool Opt { get; set; }

        [Column]
        public string GuarantorName { get; set; }

        [Column]
        public string GuarantorPhone { get; set; }

        [Column]
        public string GuarantorEmail { get; set; }
    }
}