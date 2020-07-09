using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interface.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Project.Queries.WebApps
{
    public class GetWebAppQuery:IRequest<List<WebAppsDropdownDto>>
    {
        public int webAppId { get; set; }

        public GetWebAppQuery(int webAppId)
        {
            this.webAppId = webAppId;
        }
        public class Handler : IRequestHandler<GetWebAppQuery, List<WebAppsDropdownDto>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;
            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async  Task<List<WebAppsDropdownDto>> Handle(GetWebAppQuery request, CancellationToken cancellationToken)
            {
                var source = await _context.Set<global::Domain.Entities.WebApps>().Where(x => x.ProjectId == request.webAppId).Select(p=>_mapper.Map<WebAppsDropdownDto>(p))
                    .ToListAsync(cancellationToken);
                return source;
            }
        }
    }
}
