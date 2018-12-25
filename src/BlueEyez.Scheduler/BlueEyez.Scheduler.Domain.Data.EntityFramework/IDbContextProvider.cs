using System.Data.Entity;

namespace BlueEyez.Scheduler.Domain.Data.EntityFramework
{
    public interface IDbContextProvider
    {
        DbContext DbContext { get; }
    }
}
