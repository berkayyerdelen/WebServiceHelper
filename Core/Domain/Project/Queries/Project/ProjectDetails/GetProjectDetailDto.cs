using System.Collections.Generic;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;

namespace Core.Domain.Project.Queries.Project.ProjectDetails
{
    public class GetProjectDetailDto 
    {
        
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public virtual ICollection<WebAppsDto> Webapps { get; set; }

      
    }

    public class WebAppsDto
    {
        public int Id { get; set; }
        public string WebAppUrl { get; set; }
        public int ProjectId { get; set; }
        public WebAppType WebAppType { get; set; }
        public virtual GetProjectDetailDto Project { get; set; }
        public virtual ICollection<WebbAppDetailsDto> WebAppDetails { get; set; }
    }

    public class WebbAppDetailsDto
    {
        public int Id { get; set; }
        public string WebAppAltUrl { get; set; }
        public int WebAppId { get; set; }
        public virtual WebAppsDto WebApps { get; set; }
    }
}