namespace Pioneer.Accident.Service.Model
{
    public class Repository : IRepository
    {
        private Data.Schema schema = null;

        public Repository(string connectionString)
        {
            schema = new Data.Schema(connectionString);
        }

        public void InsertAccidentnLead(Lead leadData)
        {
            Data.Lead lead = new Data.Lead
            {
                Title = leadData.Title,
                FirstName = leadData.FirstName,
                LastName = leadData.LastName,
                Address1 = leadData.Address1,
                City = leadData.City,
                PostCode = leadData.PostCode,
                Email = leadData.Email,
                WorkPhone = leadData.WorkPhone,
                HomePhone = leadData.HomePhone,
                Age = leadData.Age,
                Dob = leadData.Dob,
                AddressStartDate = leadData.AddressStartDate,
                SingleOwnership = leadData.SingleOwnership,
                Period = leadData.Period,
                PremiumTypeId = 1,
                CriticalIllness = leadData.CriticalIllness,
                InsuranceTypeId = 1,
                Amount = leadData.Amount,
                GeneratedDate = leadData.GeneratedDate,
                Status = leadData.Status,
                SiteId = leadData.SiteId,
                QueryStr = leadData.QueryStr,
                Source = leadData.Source,
                Keyword = leadData.Keyword,
                Match = leadData.Match,
                IpAddress = leadData.IpAddress,
                MortgageTypeId = leadData.MortgageTypeId,
                MortgageLoanValue = leadData.MortgageLoanValue,
                LoanPurposeId = leadData.LoanPurposeId,
                MortgagePropertyValue = leadData.MortgagePropertyValue,
                EmploymentStatusId = leadData.EmploymentStatusId,
                HomeOwner = leadData.HomeOwner,
                MortgageBalance = leadData.MortgageBalance,
                LoanMaritalStatusId = leadData.LoanMaritalStatusId,
                LoanCountryOfResidenceId = leadData.LoanCountryOfResidenceId,
                LoanAnnualIncome = leadData.LoanAnnualIncome,
                LoanCreditRatingId = leadData.LoanCreditRatingId,
                TotalCreditors = leadData.TotalCreditors,
                HadBankruptcy = leadData.HadBankruptcy,
                LoanGuarantor = leadData.GetLoanGuarantor,
                BeenInDebt = leadData.BeenInDebt,
                Occupation = leadData.Occupation,
                EmployerName = leadData.EmployerName,
                EmployedSince = leadData.EmployedSince,
                /* TO DO NEW */
                PreviousAddress = leadData.PreviousAddress,/* TO DO NEW */
                PreviousCity = leadData.PreviousCity,/* TO DO NEW */
                PreviousPostCode = leadData.PreviousPostCode,/* TO DO NEW */
                PreviousAddressSince = leadData.PreviousAddressSince,/* TO DO NEW */
                Opt = leadData.Opt,
                GuarantorName = leadData.GuarantorName,
                GuarantorPhone = leadData.GuarantorPhone,
                GuarantorEmail = leadData.GuarantorEmail,
            };

            schema.Lead.InsertOnSubmit(lead);

            schema.SubmitChanges();
        }

    }
}