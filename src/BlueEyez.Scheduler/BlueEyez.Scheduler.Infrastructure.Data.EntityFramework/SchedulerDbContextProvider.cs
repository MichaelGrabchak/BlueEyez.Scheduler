using System.Data.Entity;

using BlueEyez.Scheduler.Core.Contexts;
using BlueEyez.Scheduler.Domain.Data.EntityFramework;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework
{
    public class SchedulerDbContextProvider : IDbContextProvider
    {
        public DbContext DbContext { get; }

        public SchedulerDbContextProvider(IDataWarehouseContext dwhContext)
        {
            DbContext = new SchedulerDbContext(dwhContext.ConnectionString);
        }
    }
}
