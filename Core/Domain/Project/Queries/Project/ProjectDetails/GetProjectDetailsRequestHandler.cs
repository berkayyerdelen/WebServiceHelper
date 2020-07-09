using System;
using System.Collections.Generic;
using System.Linq;
using Core.Interface.EntityFramework;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

using Core.Domain.Project.Queries.Project.ProjectDetails.Dto;
using Microsoft.EntityFrameworkCore;

namespace Core.Domain.Project.Queries.Project.ProjectDetails
{
    public class GetProjectDetailsRequestHandler : IRequestHandler<GetProjectDetailsRequest, List<ProjectDto>>

    {

        public readonly IApplicationDbContext _context;
        public readonly IMapper _mapper;

        public GetProjectDetailsRequestHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProjectDto>> Handle(GetProjectDetailsRequest request, CancellationToken cancellationToken)
        {

            var source = await _context.Set<global::Domain.Entities.Project>().
                Include(x => x.Webapps).ThenInclude(c => c.WebAppDetails)
                .Select(x => _mapper.Map<ProjectDto>(x))
                .ToListAsync(cancellationToken);
            return source;


        }


    }
}