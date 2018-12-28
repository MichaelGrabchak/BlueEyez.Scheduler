using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Dependencies.Configurations;
using BlueEyez.Scheduler.Logging;
using BlueEyez.Scheduler.Logging.Loggers;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public class LoggerDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterLogger();
            RegisterProvider();
        }

        protected virtual void RegisterLogger()
        {
            Container.RegisterType<ILogger, NoLogger>(Constants.LoggerNames.DefaultLogger);
        }

        protected virtual void RegisterProvider()
        {
            Container.RegisterType<ILoggerProvider, LoggerProvider>();
        }
    }
}
