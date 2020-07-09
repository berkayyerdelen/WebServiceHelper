using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Core.Domain.Project.Queries.WebApps.Dto;
using Core.Interface.EntityFramework;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Project.Queries.WebApps
{
    public class GetWebAppQuery:IRequestHandler<WebAppRequest,List<WebAppDropDownDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWebAppQuery(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async  Task<List<WebAppDropDownDto>> Handle(WebAppRequest request, CancellationToken cancellationToken)
        {
            var source = await _context.Set<global::Domain.Entities.WebApps>()
                .Where(x => x.ProjectId == request.WebAppId).Select(p => _mapper.Map<WebAppDropDownDto>(p))
                .ToListAsync(cancellationToken);
            return source;
        }
    }
}
