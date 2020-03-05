using System;
using System.Collections.Generic;
using System.Linq;
using Core.Interface.EntityFramework;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Project.Queries
{
    public class GetProjectDetailsQuery:IRequest<List<GetProjectDetailDto>>
    {
        public class Handler : IRequestHandler<GetProjectDetailsQuery, List<GetProjectDetailDto>>
        {
            public readonly IApplicationDbContext _context;
            public readonly IMapper _mapper;
            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<GetProjectDetailDto>> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
            {

                var projectDetails = await _context.Set<global::Domain.Entities.Project>().
                Include(x => x.Webapps).ThenInclude(c=>c.WebAppDetails)
                .Select(x=>_mapper.Map<GetProjectDetailDto>(x))
                .ToListAsync(cancellationToken);               
                return projectDetails;
                       
               
            }

           
        }
    }
}