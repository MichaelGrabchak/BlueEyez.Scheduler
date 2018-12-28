using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Domain.Services;
using BlueEyez.Scheduler.Infrastructure.Services;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class ServiceDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterSchedulerManagerService();
        }

        protected virtual void RegisterSchedulerManagerService()
        {
            Container.RegisterType<ISchedulerManagerService, SchedulerManagerService>();
        }
    }
}
