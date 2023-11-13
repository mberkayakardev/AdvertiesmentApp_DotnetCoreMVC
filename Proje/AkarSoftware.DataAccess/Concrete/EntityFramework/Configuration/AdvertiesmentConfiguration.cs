using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class AdvertiesmentConfiguration : IEntityTypeConfiguration<Advertiesment>
    {
        public void Configure(EntityTypeBuilder<Advertiesment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(500).IsRequired(); 
            builder.Property(x => x.Description).HasColumnType("ntext").IsRequired(); // Uzun ilan için geçerli
            builder.Property(x=> x.CreatedDate).HasDefaultValue(DateTime.Now);
        }
    }
}
