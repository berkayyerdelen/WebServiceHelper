using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebServiceHelper.Context
{
    public interface IAppContext
    {
        DbSet<T> Set<T>() where T : class;      
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
