using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(x=> x.RoleName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(2000).IsRequired();
        }
    }
}
