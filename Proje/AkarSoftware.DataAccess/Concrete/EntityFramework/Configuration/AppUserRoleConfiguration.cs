using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasIndex(x => new { x.AppUserId, x.BaseRoleId });
            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.BaseRole).WithMany(x => x.AppUserRoles).HasForeignKey(x => x.BaseRoleId);

        }

    }
}
