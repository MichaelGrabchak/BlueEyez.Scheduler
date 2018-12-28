using System;

namespace BlueEyez.Scheduler.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class KeyAttribute : Attribute
    {
        public string Name { get; }

        public KeyAttribute(string name)
        {
            Name = name;
        }
    }
}
