using BlueEyez.Scheduler.Domain.Data.Dto;

namespace BlueEyez.Scheduler.Domain.Data.Services
{
    public interface IJobDetailService
    {
        JobDetail GetJobDetail(string jobName, string jobGroup);
        void UpdateJobDetail(JobDetail jobDetail, bool updateChangedOnly = false);
    }
}
