using System;

using BlueEyez.Scheduler.Core.Contexts;
using BlueEyez.Scheduler.Domain.Data.BusinessEntities;
using BlueEyez.Scheduler.Domain.Data.EntityFramework;
using BlueEyez.Scheduler.Domain.Data.Repositories;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Repositories
{
    public class InstanceRepository : BaseRepository<Instance, Guid>, IInstanceRepository
    {
        public InstanceRepository(IDbContextProvider dbContextProvider, IApplicationContext schedulerContext)
            : base(dbContextProvider, schedulerContext)
        {

        }
    }
}
