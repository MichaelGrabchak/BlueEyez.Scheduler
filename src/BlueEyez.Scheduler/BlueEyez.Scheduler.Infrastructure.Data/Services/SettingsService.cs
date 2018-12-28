using System.Collections.Generic;
using System.Linq;

using BlueEyez.Scheduler.Caching;
using BlueEyez.Scheduler.Core.Extensions;
using BlueEyez.Scheduler.Domain.Data.Repositories;
using BlueEyez.Scheduler.Domain.Data.Services;

using CacheKeys = BlueEyez.Scheduler.Core.Constants.Cache;

namespace BlueEyez.Scheduler.Infrastructure.Data.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly ICache _cache;
        private readonly ISettingRepository _schedulerInstanceSettingRepository;

        public SettingsService(ICache cache, ISettingRepository schedulerInstanceSettingRepository)
        {
            _cache = cache;
            _schedulerInstanceSettingRepository = schedulerInstanceSettingRepository;
        }

        // TODO: Implement storing of the data into data warehouse
        public void SetSettings<T>(T settings)
        {
            _cache.Set(CacheKeys.ApplicationSettingsKey, settings.AsKeyValuePairs());
        }

        public T GetSettings<T>() where T : new()
        {
            var result = new T();

            var kvps = new List<KeyValuePair<string, string>>();

            if (_cache.IsCached(CacheKeys.ApplicationSettingsKey))
            {
                kvps = _cache.Get<List<KeyValuePair<string, string>>>(CacheKeys.ApplicationSettingsKey);
            }

            if (!kvps.Any())
            {
                kvps = _schedulerInstanceSettingRepository
                       .GetInstanceSettings()
                       .Select(x => new KeyValuePair<string, string>(x.Key, x.Value))
                       .ToList();

                _cache.Set(CacheKeys.ApplicationSettingsKey, kvps);
            }

            result.SetObject(kvps);

            return result;
        }
    }
}
