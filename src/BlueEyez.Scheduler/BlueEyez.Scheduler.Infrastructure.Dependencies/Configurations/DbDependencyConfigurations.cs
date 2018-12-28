using System;

using BlueEyez.Scheduler.Dependencies.Configurations;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class DbDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterDbBasic();
            RegisterRepositories();
        }

        protected virtual void RegisterDbBasic()
        {
            
        }

        protected virtual void RegisterRepositories()
        {
            throw new NotImplementedException("The repositories are not registered in IoC container");
        }
    }
}
