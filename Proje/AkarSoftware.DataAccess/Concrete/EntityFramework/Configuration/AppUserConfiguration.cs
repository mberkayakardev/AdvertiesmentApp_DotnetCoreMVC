using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasIndex(x=> x.UserName).IsUnique();
            builder.Property(x => x.UserName).HasConversion( x=> x.ToUpper().Trim().Replace("İ", "I").Replace("Ü", "U").Replace("Ö", "O"), x=> x.ToUpper().Trim().Replace("İ","I").Replace("Ü","U").Replace("Ö","O")); // iki yönlü olarak Büyük harf şeklinde kaydedilmesini sağlar 
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.OptionalName);
            builder.Property(x => x.Email).HasMaxLength(1000);
            builder.HasIndex(x=> x.Email).IsUnique();
            builder.HasIndex(x => x.PhoneNumber).IsUnique();
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.HasOne(x=> x.Genders).WithMany(x=> x.AppUsers).HasForeignKey(x=>x.GendersId);
        }
    }
}
