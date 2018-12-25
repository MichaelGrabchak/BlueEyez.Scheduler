using System;
using System.Globalization;

using BlueEyez.Scheduler.Domain.Entities;

namespace BlueEyez.Scheduler.Engine.Extensions
{
    public static class EngineInfoExtensions
    {
        public static EngineDetails ToEngineDetails(this EngineInfo engineDetails)
        {
            return new EngineDetails
            {
               RunningSince = (engineDetails.StartDate != DateTimeOffset.MinValue) ? engineDetails.StartDate.ToString(CultureInfo.InvariantCulture) : null,
               Version = engineDetails.Version,
               Engine = engineDetails.Name,
               State = engineDetails.State,
               InstanceId = engineDetails.InstanceId,
               InstanceName = engineDetails.InstanceName
            };
        }
    }
}
