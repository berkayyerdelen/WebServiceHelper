using Core.Interface.EntityFramework;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Project.Queries
{
    public class GetProjectDetailsQuery:IRequest<GetProjectDetailsViewModel>
    {
        public class Handler:IRequestHandler<GetProjectDetailsQuery,GetProjectDetailsViewModel>
        {
            public readonly IApplicationDbContext _context;
            public Handler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<GetProjectDetailsViewModel> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
            {
                var projectDetails = await _context.Set<global::Domain.Entities.Project>()
                    .ToListAsync(cancellationToken);
            }
        }
    }
}