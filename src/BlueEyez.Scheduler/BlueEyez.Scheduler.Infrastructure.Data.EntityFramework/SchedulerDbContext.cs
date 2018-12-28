using System.Data.Entity;

using BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Configurations;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework
{
    public class SchedulerDbContext : DbContext
    {
        public SchedulerDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<SchedulerDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new JobStatusConfiguration());
            modelBuilder.Configurations.Add(new JobDetailConfiguration());
            modelBuilder.Configurations.Add(new InstanceConfiguration());
            modelBuilder.Configurations.Add(new SettingConfiguration());
        }
    }
}
