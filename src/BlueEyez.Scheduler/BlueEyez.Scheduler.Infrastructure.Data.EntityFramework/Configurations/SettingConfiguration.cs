using System.Data.Entity.ModelConfiguration;

using BlueEyez.Scheduler.Domain.Data.BusinessEntities;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Configurations
{
    public class SettingConfiguration : EntityTypeConfiguration<Setting>
    {
        public SettingConfiguration()
        {
            HasKey(x => new { x.InstanceId, x.Key });

            Property(x => x.InstanceId).HasColumnName("InstanceId").IsRequired();
            Property(x => x.Key).HasColumnName("Key").IsRequired();
            Property(x => x.Value).HasColumnName("Value").IsOptional();

            HasRequired(x => x.Instance).WithMany().HasForeignKey(x => x.InstanceId);

            ToTable("Setting");
        }
    }
}
