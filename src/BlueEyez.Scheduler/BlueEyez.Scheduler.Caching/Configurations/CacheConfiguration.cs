using System.Configuration;

using BlueEyez.Scheduler.Core.Extensions;

using CacheKey = BlueEyez.Scheduler.Caching.Constants.ConfigurationKeys;

namespace BlueEyez.Scheduler.Caching.Configurations
{
    public class CacheConfiguration : ICacheConfiguration
    {
        public int? CacheExpiration { get; }

        public CacheConfiguration()
        {
            CacheExpiration = ConfigurationManager.AppSettings[CacheKey.CacheExpirationKey].To<int?>();
        }
    }
}
