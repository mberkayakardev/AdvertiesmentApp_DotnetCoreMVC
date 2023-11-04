using AkarSoftware.Core.Entities.Concrete;
using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts
{
    public class MyDbContexts : DbContext
    {
        public MyDbContexts(DbContextOptions<MyDbContexts> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region Tables
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRole {  get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Advertiesment> Advertiesments { get; set; }
        public DbSet<AdvertiesmentUser> AdvertiesmentStatuses { get; set; }
        public DbSet<AdvertiesmentUserApplyStatus> AdvertiesmentUserApplyStatuses { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatuses { get; set; }
        public DbSet<Genders> Genders { get; set; }
        #endregion

    }
}
