using System.Collections.Generic;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Core.Domain.Project.Queries.Project.ProjectDetails.Dto
{

    public class GetProjectDetailsRequest:IRequest<List<ProjectDto>>
    {

    }

    public class ProjectDto
    {

        public int Id { get; set; }
        public string ProjectName { get; set; }
        public virtual ICollection<WebAppDto> Webapps { get; set; }


    }

    public class WebAppDto
    {
        public int Id { get; set; }
        public string WebAppUrl { get; set; }
        public int ProjectId { get; set; }
        public WebAppType WebAppType { get; set; }
        public virtual ProjectDto Project { get; set; }
        public virtual ICollection<WebbAppDetailsDto> WebAppDetails { get; set; }
    }

    public class WebbAppDetailsDto
    {
        public int Id { get; set; }
        public string WebAppAltUrl { get; set; }
        public int WebAppId { get; set; }
        public virtual WebAppDto WebApps { get; set; }
    }
}