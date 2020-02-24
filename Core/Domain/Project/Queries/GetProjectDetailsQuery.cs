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
    public class GetProjectDetailsQuery:IRequest<GetProjectDetailsViewModel>
    {
        public class Handler:IRequestHandler<GetProjectDetailsQuery,GetProjectDetailsViewModel>
        {
            public readonly IApplicationDbContext _context;
            public readonly IMapper _mapper;
            public Handler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<GetProjectDetailsViewModel> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
            {
                var projectDetails = await _context.Set<global::Domain.Entities.Project>().ToListAsync(cancellationToken);

                //var a = _mapper.Map<GetProjectDetailsViewModel>(projectDetails);
                var a = new GetProjectDetailsViewModel()
                {
                    
                };
                



                return a;
            }
        }
    }
}