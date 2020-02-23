using System.Threading;
using System.Threading.Tasks;
using Core.Interface.EntityFramework;
using Domain.Entities;
using Infrastructure.DataSeeder;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.ApplicationContext
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Project> Project { get; set; }
        public DbSet<WebApps> WebApps { get; set; }
        public DbSet<WebAppDetails> WebAppDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.Seed();

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
            => await base.SaveChangesAsync(cancellationToken);

    }
}