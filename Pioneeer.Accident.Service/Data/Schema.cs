using Pioneer.Accident.Service.Data;
using System.Data.Linq;

namespace Pioneer.Accident.Service.Data
{
    internal class Schema : DataContext
    {
        public Schema(string connectionString)
            : base(connectionString)
        {
        }

        public Table<Lead> Lead { get { return this.GetTable<Lead>(); } }
    }
}