using System;

namespace BlueEyez.Scheduler.Core.Contexts
{
    public interface IApplicationContext
    {
        Guid InstanceId { get; }
    }
}
