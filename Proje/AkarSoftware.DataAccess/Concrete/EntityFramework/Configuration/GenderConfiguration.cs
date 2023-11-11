using AkarSoftware.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Name).IsRequired().HasMaxLength(255);
        }
    }
}
