using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using BlueEyez.Scheduler.Domain.Data.BusinessEntities;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Configurations
{
    public class InstanceConfiguration : EntityTypeConfiguration<Instance>
    {
        public InstanceConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            ToTable("Instance");
        }
    }
}
