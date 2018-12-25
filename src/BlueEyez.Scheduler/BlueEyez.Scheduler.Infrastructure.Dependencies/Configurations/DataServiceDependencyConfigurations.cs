using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Domain.Data.Services;
using BlueEyez.Scheduler.Infrastructure.Data.Services;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class DataServiceDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterSettingsService();
            RegisterJobDetailService();
        }

        protected virtual void RegisterSettingsService()
        {
            Container.RegisterType<ISettingsService, SettingsService>();
        }

        protected virtual void RegisterJobDetailService()
        {
            Container.RegisterType<IJobDetailService, JobDetailService>();
        }
    }
}
