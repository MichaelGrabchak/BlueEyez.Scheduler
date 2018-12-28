using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Infrastructure.Dependencies.Configurations;
using BlueEyez.Scheduler.Logging.NLog.Loggers;

namespace BlueEyez.Scheduler.Logging.NLog
{
    public sealed class NLogLoggerDependencyConfigurations : LoggerDependencyConfigurations
    {
        protected override void RegisterLogger()
        {
            Container.RegisterType<ILogger, NLogLogger>(Constants.LoggerNames.DefaultLogger);
        }
    }
}
