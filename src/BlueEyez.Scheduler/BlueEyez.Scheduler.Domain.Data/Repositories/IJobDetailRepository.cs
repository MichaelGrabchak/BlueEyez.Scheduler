using BlueEyez.Scheduler.Domain.Data.BusinessEntities;

namespace BlueEyez.Scheduler.Domain.Data.Repositories
{
    public interface IJobDetailRepository : IRepository<JobDetail, int>
    {
        JobDetail GetJobDetail(string name, string group);
    }
}
