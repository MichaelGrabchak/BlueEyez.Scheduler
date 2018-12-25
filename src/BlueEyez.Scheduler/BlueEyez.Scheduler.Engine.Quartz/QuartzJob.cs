using System;
using System.Threading.Tasks;

using BlueEyez.Scheduler.Dependencies;
using BlueEyez.Scheduler.Job;
using BlueEyez.Scheduler.Loader;

using Quartz;

namespace BlueEyez.Scheduler.Engine.Quartz
{
    public class QuartzJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            return Task.Run(() =>
            {
                try
                {
                    var typeFullName = context.JobDetail?.JobDataMap?.GetString("TypeFullName");

                    var jobType = AssemblyLoaderManager.GetType(typeFullName);

                    if (jobType != null)
                    {
                        var jobObj = Container.Resolve<BaseJob>(jobType);
                        jobObj.Execute();
                    }
                }
                catch (Exception ex)
                {
                    throw new JobExecutionException("An unexpected error has occurred during job execution", ex, false);
                }
            });
        }
    }
}
