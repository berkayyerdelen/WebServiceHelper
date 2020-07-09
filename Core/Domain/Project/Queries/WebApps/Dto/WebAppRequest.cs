using System.Collections.Generic;
using MediatR;

namespace Core.Domain.Project.Queries.WebApps.Dto
{
    public class WebAppRequest:IRequest<List<WebAppDropDownDto>>
    {
        public int WebAppId { get; set; }
    }
}