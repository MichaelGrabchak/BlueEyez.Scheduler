using BlueEyez.Scheduler.Domain.Data.Services;
using BlueEyez.Scheduler.Engine.Jobs;

using Quartz;

namespace BlueEyez.Scheduler.Engine.Quartz
{
    public class QuartzJobMetadata : JobMetadata
    {
        public QuartzJobMetadata(IJobDetailService jobDetailService) : base(jobDetailService)
        {

        }

        protected override bool IsScheduleExpressionValid(string schedule)
        {
            return CronExpression.IsValidExpression(schedule);
        }
    }
}
