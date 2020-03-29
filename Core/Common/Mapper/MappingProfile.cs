using AutoMapper;
using Core.Domain.Project.Queries;
using Core.Domain.Project.Queries.Project;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Project.Queries.Project.ProjectDetails;
using Core.Domain.Project.Queries.Project.ProjectNames;


namespace Core.Common.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Project, GetProjectDetailDto>();
            CreateMap<WebApps, WebAppsDto>();
            CreateMap<WebAppDetails, WebbAppDetailsDto>();


            CreateMap<Project, ProjectsDto>().ForMember(x=>x.ProjectId, c=>c.MapFrom(v=>v.Id)).ForMember(x=>x.ProjectName,c=>c.MapFrom(v=>v.ProjectName));
            //CreateMap<WebApps, ProjectsWebAppsDto>();

        }
    }
}
