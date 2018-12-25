using System.Configuration;

namespace BlueEyez.Scheduler.Core.Contexts
{
    public class DataWarehouseContext : IDataWarehouseContext
    {
        public string ConnectionString { get; }

        public DataWarehouseContext()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[Constants.System.DataWarehouse.ConnectionStringKey].ConnectionString;
        }
    }
}
