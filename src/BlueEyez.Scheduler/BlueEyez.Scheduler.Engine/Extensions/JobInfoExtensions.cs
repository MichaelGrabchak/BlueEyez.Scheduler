using System.Globalization;

using BlueEyez.Scheduler.Domain.Entities;
using BlueEyez.Scheduler.Engine.Enums;
using BlueEyez.Scheduler.Engine.Jobs;

namespace BlueEyez.Scheduler.Engine.Extensions
{
    public static class JobInfoExtensions
    {
        public static JobDetails ToJobDetails(this JobInfo jobInfo)
        {
            return new JobDetails
            {
               Name = jobInfo.Name,
               Group = jobInfo.Group,
               Description = jobInfo.Description,
               DescriptionSpecified = jobInfo.DescriptionSpecified,
               Schedule = jobInfo.Schedule,
               ScheduleSpecified = jobInfo.ScheduleSpecified,
               State = jobInfo.State,
               StateSpecified = jobInfo.StateSpecified,
               ActionState = jobInfo.ActionState,
               PreviousFireTime = jobInfo.PrevFireTimeUtc?.LocalDateTime.ToString(CultureInfo.InvariantCulture),
               PrevFireTimeSpecified = jobInfo.PrevFireTimeSpecified,
               NextFireTime = (jobInfo.State != JobState.Paused.ToString())
                                  ? jobInfo.NextFireTimeUtc?.LocalDateTime.ToString(CultureInfo.InvariantCulture)
                                  : string.Empty, // if the job is on hold - we don't want to show next execution time
               NextFireTimeSpecified = jobInfo.NextFireTimeSpecified
            };
        }
    }
}
