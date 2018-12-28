using System;

using BlueEyez.Scheduler.Core.Configurations;
using BlueEyez.Scheduler.Core.Contexts;
using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Domain.Data.Services;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public sealed class BasicDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterConfiguration();
            RegisterContext();
        }

        private void RegisterConfiguration()
        {
            Func<ApplicationConfiguration> configurationFactory = () => Container.Resolve<ISettingsService>().GetSettings<ApplicationConfiguration>();
            Container.RegisterFactory<IEngineConfiguration>(configurationFactory);
            Container.RegisterFactory<IApplicationConfiguration>(configurationFactory);
        }

        private void RegisterContext()
        {
            Container.RegisterType<IApplicationContext, ApplicationContext>();
            Container.RegisterType<IDataWarehouseContext, DataWarehouseContext>();
        }
    }
}
