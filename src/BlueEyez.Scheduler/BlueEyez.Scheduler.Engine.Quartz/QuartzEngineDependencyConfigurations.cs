using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Domain.Data.Services;
using BlueEyez.Scheduler.Engine.Jobs;
using BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations;

namespace BlueEyez.Scheduler.Engine.Quartz
{
    public class QuartzEngineDependencyConfigurations : EngineDependencyConfigurations
    {
        protected override void RegisterSchedulerEngine()
        {
            Container.RegisterType<JobMetadata, QuartzJobMetadata>();
            Container.RegisterSingleton<ISchedulerEngine, QuartzScheduler>(typeof(SchedulerSettings), typeof(JobMetadata), typeof(IJobDetailService));
        }
    }
}
