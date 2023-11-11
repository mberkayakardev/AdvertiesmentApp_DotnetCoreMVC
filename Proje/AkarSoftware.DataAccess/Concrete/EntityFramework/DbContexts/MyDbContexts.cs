using AkarSoftware.Core.Entities.Concrete;
using AkarSoftware.DataAccess.Concrete.EntityFramework.Configuration;
using AkarSoftware.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AkarSoftware.DataAccess.Concrete.EntityFramework.DbContexts
{
    /// <summary>
    /// Advertiesment App için kullanılacak olan DbContext örneği sınıftır. 
    /// </summary>
    public class MyDbContexts : DbContext
    {
        /// <summary>
        ///  AddDbcontext service ini kaydettiğimiz yerden alacağız.
        /// </summary>
        public MyDbContexts(DbContextOptions<MyDbContexts> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region Tables
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles {  get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Advertiesment> Advertiesments { get; set; }
        public DbSet<AdvertiesmentUser> AdvertiesmentStatuses { get; set; }
        public DbSet<AdvertiesmentUserApplyStatus> AdvertiesmentUserApplyStatuses { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatuses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<ProviderServices> ProviderServices { get; set; }
        #endregion
        
    }
}
