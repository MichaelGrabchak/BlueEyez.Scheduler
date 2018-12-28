using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Domain.Data.EntityFramework;
using BlueEyez.Scheduler.Domain.Data.Repositories;
using BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Repositories;
using BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework
{
    public sealed class EntityFrameworkDbDependencyConfigurations : DbDependencyConfigurations
    {
        protected override void RegisterDbBasic()
        {
            Container.RegisterType<IDbContextProvider, SchedulerDbContextProvider>();
        }

        protected override void RegisterRepositories()
        {
            Container.RegisterType<IJobDetailRepository, JobDetailRepository>();
            Container.RegisterType<IInstanceRepository, InstanceRepository>();
            Container.RegisterType<ISettingRepository, SettingRepository>();
        }
    }
}
