using Pioneer.Accident.Service.Model;

namespace Pioneer.Accident.Service
{
    public class AccidentService : ServiceBase
    {
        public void InsertLoanLead(Lead leadData)
        {
            repository.InsertAccidentnLead(leadData);
        }

        public static AccidentService Create(string connectionString)
        {
            return ServiceBase.Create<AccidentService>(connectionString);
        }

        public static AccidentService Create(IRepository repository)
        {
            return ServiceBase.Create<AccidentService>(repository);
        }
    }
}