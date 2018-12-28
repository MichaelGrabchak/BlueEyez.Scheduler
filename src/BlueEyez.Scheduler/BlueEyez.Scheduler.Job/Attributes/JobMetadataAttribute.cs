using System;

namespace BlueEyez.Scheduler.Job.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class JobMetadataAttribute : Attribute
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string Logger { get; set; }
        public string Description { get; set; }
    }
}
