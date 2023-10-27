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

        #region DbSets


        #endregion

    }
}
