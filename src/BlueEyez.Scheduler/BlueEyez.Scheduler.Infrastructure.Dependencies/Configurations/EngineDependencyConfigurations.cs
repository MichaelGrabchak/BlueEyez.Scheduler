using System;

using BlueEyez.Scheduler.Dependencies.Configurations;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class EngineDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            
        }

        protected virtual void RegisterSchedulerEngine()
        {
            throw new NotImplementedException("The scheduler's engine is not registered in IoC container");
        }
    }
}
