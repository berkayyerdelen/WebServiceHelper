using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.Domains;

namespace WebServiceHelper.Context
{
    public class AppContext:DbContext, IAppContext
    {
        
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {

        }
        public DbSet<Project> Project{ get; set; }
        public DbSet<WebServices> WebServices{ get; set; }
        public DbSet<WebServiceDetails> WebServiceDetails { get; set; }

    }
}
