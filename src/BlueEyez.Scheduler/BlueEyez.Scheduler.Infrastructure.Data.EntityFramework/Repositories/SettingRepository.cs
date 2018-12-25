using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using BlueEyez.Scheduler.Core.Contexts;
using BlueEyez.Scheduler.Domain.Data.BusinessEntities;
using BlueEyez.Scheduler.Domain.Data.EntityFramework;
using BlueEyez.Scheduler.Domain.Data.Repositories;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Repositories
{
    public class SettingRepository : BaseRepository<Setting, int>, ISettingRepository
    {
        public SettingRepository(IDbContextProvider dbContextProvider, IApplicationContext schedulerContext)
            : base(dbContextProvider, schedulerContext)
        {

        }

        public IList<Setting> GetInstanceSettings()
        {
            return DbSet
                   .Include(x => x.Instance)
                   .Where(x => x.InstanceId == SchedulerContext.InstanceId)
                   .ToList();
        }
    }
}
