using BlueEyez.Scheduler.Domain.Data.BusinessEntities;
using System.Collections.Generic;

namespace BlueEyez.Scheduler.Domain.Data.Repositories
{
    public interface ISettingRepository : IRepository<Setting, int>
    {
        IList<Setting> GetInstanceSettings();
    }
}
