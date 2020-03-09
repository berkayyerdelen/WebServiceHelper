using Core.Domain.Project.Queries.RestApi.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Domain.Project.Queries.RestApi
{
    public class RestApiQueryHandler : IRequest<RestApiRequestDto>
    {
        //public class Handler : IRequestHandler<RestApiQueryHandler, RestApiResponseDto>
        //{
        //    public Task<RestApiResponseDto> Handle(RestApiQueryHandler request, CancellationToken cancellationToken)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
