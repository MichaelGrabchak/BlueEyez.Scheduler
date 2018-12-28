using System;
using System.Collections.Generic;

using BlueEyez.Scheduler.Engine.Jobs;
using BlueEyez.Scheduler.Job;

namespace BlueEyez.Scheduler.Engine
{
    public interface ISchedulerEngine : IDisposable
    {
        void Discover();

        void Start();

        void Pause();

        void Stop();

        void ScheduleJob(BaseJob scheduleJob);

        void ScheduleJobs(IEnumerable<BaseJob> jobsToSchedule);

        void UnscheduleJob(BaseJob job);

        void UnscheduleJob(string jobName, string jobGroup);

        void TriggerJob(string jobName, string jobGroup);

        void PauseJob(string jobName, string jobGroup);

        void ResumeJob(string jobName, string jobGroup);

        IEnumerable<JobInfo> GetAllJobs();

        EngineInfo GetEngineInfo();
    }
}
