using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interface.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Project.Queries.Project.ProjectNames
{
    public class GetProjectsQuery : IRequest<List<ProjectsDto>>
    {
        public class Handler : IRequestHandler<GetProjectsQuery, List<ProjectsDto>>
        {
            public readonly IApplicationDbContext _context;
            public readonly IMapper _mapper;
            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }
            public async Task<List<ProjectsDto>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
            {
                var source = await _context.Set<global::Domain.Entities.Project>().
                    Select(x => _mapper.Map<ProjectsDto>(x)).ToListAsync(cancellationToken);
                return source;
            }
        }
    }
}