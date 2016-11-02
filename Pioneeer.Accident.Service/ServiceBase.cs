using Pioneer.Accident.Service.Model;

namespace Pioneer.Accident.Service
{
    public class ServiceBase
    {
        protected IRepository repository = null;

        protected ServiceBase()
        {
        }

        protected ServiceBase(IRepository repository)
        {
            this.repository = repository;
        }

        protected static T Create<T>(IRepository repository)
            where T : ServiceBase, new()
        {
            var newInstance = new T();
            newInstance.repository = repository;
            return newInstance;
        }

        protected static T Create<T>(string connectionString)
            where T : ServiceBase, new()
        {
            var newInstance = new T();
            newInstance.repository = new Repository(connectionString);
            return newInstance;
        }
    }
}