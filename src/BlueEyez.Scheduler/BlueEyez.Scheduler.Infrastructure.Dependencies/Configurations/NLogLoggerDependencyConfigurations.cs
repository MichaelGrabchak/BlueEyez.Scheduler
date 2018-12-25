using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Logging;
using BlueEyez.Scheduler.Logging.NLog.Loggers;

namespace BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations
{
    public sealed class NLogLoggerDependencyConfigurations : LoggerDependencyConfigurations
    {
        protected override void RegisterLogger()
        {
            Container.RegisterType<ILogger, NLogLogger>(Constants.LoggerNames.DefaultLogger);
        }
    }
}
