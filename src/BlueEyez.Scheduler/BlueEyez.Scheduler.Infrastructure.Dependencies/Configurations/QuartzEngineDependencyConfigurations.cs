using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Domain.Data.Services;
using BlueEyez.Scheduler.Engine;
using BlueEyez.Scheduler.Engine.Jobs;
using BlueEyez.Scheduler.Engine.Quartz;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class QuartzEngineDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterJobMetadata();
            RegisterEngine();
        }

        protected virtual void RegisterJobMetadata()
        {
            Container.RegisterType<JobMetadata, QuartzJobMetadata>();
        }

        protected virtual void RegisterEngine()
        {
            Container.RegisterSingleton<ISchedulerEngine, QuartzScheduler>(typeof(SchedulerSettings), typeof(JobMetadata), typeof(IJobDetailService));
        }
    }
}
