using BlueEyez.Scheduler.Caching;
using BlueEyez.Scheduler.Caching.Configurations;
using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class CacheDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterCacheConfig();
            RegisterCacheContainer();
        }

        protected virtual void RegisterCacheConfig()
        {
            Container.RegisterType<ICacheConfiguration, CacheConfiguration>();
        }

        protected virtual void RegisterCacheContainer()
        {
            Container.RegisterType<ICache, NoCache>();
        }
    }
}
