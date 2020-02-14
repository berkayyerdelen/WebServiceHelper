using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebServiceHelper.Entities.Domains;

namespace WebServiceHelper.Context
{
    public class AppDbContext:DbContext, IAppContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Project> Project{ get; set; }
        public DbSet<WebApps> WebApps{ get; set; }
        public DbSet<WebAppDetails> WebAppDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            
            var result = await base.SaveChangesAsync(cancellationToken);
           
            return result;
        }
    }
}
