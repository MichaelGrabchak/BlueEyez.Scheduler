namespace BlueEyez.Scheduler.Engine.Enums
{
    public enum JobActionState
    {
        None,

        Skipped,
        ToBeExecuted,
        Executing,

        Failed,
        Succeeded
    }
}
