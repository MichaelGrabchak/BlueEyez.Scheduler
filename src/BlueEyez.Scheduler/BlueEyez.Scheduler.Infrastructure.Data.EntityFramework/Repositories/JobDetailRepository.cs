using System.Linq;

using BlueEyez.Scheduler.Core.Contexts;
using BlueEyez.Scheduler.Domain.Data.BusinessEntities;
using BlueEyez.Scheduler.Domain.Data.EntityFramework;
using BlueEyez.Scheduler.Domain.Data.Repositories;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Repositories
{
    public class JobDetailRepository : BaseRepository<JobDetail, int>, IJobDetailRepository
    {
        public JobDetailRepository(IDbContextProvider dbContextProvider, IApplicationContext schedulerContext)
            : base(dbContextProvider, schedulerContext)
        {

        }

        public JobDetail GetJobDetail(string name, string group)
        {
            return DbSet
                .FirstOrDefault(
                    entity =>
                        entity.InstanceId == SchedulerContext.InstanceId &&
                        entity.JobName == name &&
                        entity.JobGroup == group);
        }

        protected override void AddEntity(JobDetail entity)
        {
            entity.InstanceId = SchedulerContext.InstanceId;
            base.AddEntity(entity);
        }
    }
}
