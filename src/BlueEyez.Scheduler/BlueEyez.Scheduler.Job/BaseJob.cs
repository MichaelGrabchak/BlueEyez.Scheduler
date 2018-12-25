using BlueEyez.Scheduler.Job.Extensions;
using BlueEyez.Scheduler.Logging;
using BlueEyez.Scheduler.Logging.Loggers;

namespace BlueEyez.Scheduler.Job
{
    public abstract class BaseJob
    {
        private readonly ILogger _logger;

        protected BaseJob()
        {
            _logger = LogManager.GetLogger(this.GetLogger());
        }

        public abstract string Schedule { get; }

        public void Execute()
        {
            _logger.Info($"Starting {this.GetGroup()}.{this.GetName()} job...");

            ExecuteJob();

            _logger.Info("Finishing execution of the job.");
        }

        public abstract void ExecuteJob();
    }
}
