using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Domain.Data.Repositories;
using BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Repositories;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public sealed class RepositoryDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            Container.RegisterType<IJobDetailRepository, JobDetailRepository>();
            Container.RegisterType<IInstanceRepository, InstanceRepository>();
            Container.RegisterType<ISettingRepository, SettingRepository>();
        }
    }
}
