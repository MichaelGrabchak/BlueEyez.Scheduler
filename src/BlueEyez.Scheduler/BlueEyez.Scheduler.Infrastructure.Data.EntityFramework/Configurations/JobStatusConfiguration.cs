using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using BlueEyez.Scheduler.Domain.Data.BusinessEntities;

namespace BlueEyez.Scheduler.Infrastructure.Data.EntityFramework.Configurations
{
    public class JobStatusConfiguration : EntityTypeConfiguration<JobStatus>
    {
        public JobStatusConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.Name).HasColumnName("Name").IsRequired();

            ToTable("JobStatus");
        }
    }
}
