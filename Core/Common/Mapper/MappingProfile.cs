using AutoMapper;
using Core.Domain.Project.Queries;
using Core.Domain.Project.Queries.Project;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Project, GetProjectDetailDto>();
            CreateMap<WebApps, WebAppsDto>();
            CreateMap<WebAppDetails, WebbAppDetailsDto>();
            //CreateMap<List<Project>, List<GetProjectDetailDto>>();
           
        }
    }
}
