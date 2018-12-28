using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies
{
    public abstract class DependencyManager
    {
        public void RegisterDependencies()
        {
            RegisterAllDependencies();
        }

        protected virtual void RegisterAllDependencies()
        {
            RegisterBasicDependencyConfig();
            RegisterCacheDependencyConfig();
            RegisterLoggerDependencyConfig();
            RegisterDataServiceDependencyConfig();
            RegisterDbDependencyConfig();
            RegisterServiceDependencyConfig();
            RegisterEngineDependencyConfig();
        }

        protected void RegisterBasicDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<BasicDependencyConfigurations>();
        }

        protected virtual void RegisterCacheDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<CacheDependencyConfigurations>();
        }

        protected virtual void RegisterLoggerDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<LoggerDependencyConfigurations>();
        }

        protected virtual void RegisterDataServiceDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<DataServiceDependencyConfigurations>();
        }

        protected void RegisterDbDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<DbDependencyConfigurations>();
        }

        protected virtual void RegisterServiceDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<ServiceDependencyConfigurations>();
        }

        protected virtual void RegisterEngineDependencyConfig()
        {
            DependencyConfigurationManager.AddConfiguration<EngineDependencyConfigurations>();
        }
    }
}
