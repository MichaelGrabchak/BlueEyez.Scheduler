using System;
using System.Configuration;

namespace BlueEyez.Scheduler.Core.Contexts
{
    public class ApplicationContext : IApplicationContext
    {
        public Guid InstanceId { get; }

        public ApplicationContext()
        {
            InstanceId = new Guid(ConfigurationManager.AppSettings.Get(Constants.System.InstanceIdKey));
        }
    }
}
