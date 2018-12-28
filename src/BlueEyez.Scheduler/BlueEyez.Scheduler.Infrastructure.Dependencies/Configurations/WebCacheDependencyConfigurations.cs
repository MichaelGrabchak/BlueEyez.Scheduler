using BlueEyez.Scheduler.Caching;
using BlueEyez.Scheduler.Caching.Web;
using BlueEyez.Scheduler.Dependencies;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public sealed class WebCacheDependencyConfigurations : CacheDependencyConfigurations
    {
        protected override void RegisterCacheContainer()
        {
            Container.RegisterType<ICache, WebCache>();
        }
    }
}
