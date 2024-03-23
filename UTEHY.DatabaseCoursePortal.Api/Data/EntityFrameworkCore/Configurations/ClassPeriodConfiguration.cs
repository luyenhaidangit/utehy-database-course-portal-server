using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UTEHY.DatabaseCoursePortal.Api.Data.Entities;

namespace UTEHY.DatabaseCoursePortal.Api.Data.EntityFrameworkCore.Configurations
{
    public class ClassPeriodConfiguration : IEntityTypeConfiguration<ClassPeriod>
    {
        public void Configure(EntityTypeBuilder<ClassPeriod> builder)
        {
            builder.ToTable("ClassPeriods");

            builder.HasKey(x => x.Id);
        }
    }
}
