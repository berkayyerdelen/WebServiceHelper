﻿using AutoMapper;
using Core.Domain.Project.Queries;
using Core.Domain.Project.Queries.Project;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Project.Queries.Project.ProjectDetails;
using Core.Domain.Project.Queries.Project.ProjectDetails.Dto;
using Core.Domain.Project.Queries.Project.ProjectNames;
using Core.Domain.Project.Queries.WebApps;
using Core.Domain.Project.Queries.WebApps.Dto;


namespace Core.Common.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //ProjectDetails
            CreateMap<Project, ProjectDto>();
            CreateMap<WebApps, WebAppDto>();
            CreateMap<WebAppDetails, WebbAppDetailsDto>();


            CreateMap<Project, ProjectsDto>().ForMember(x => x.ProjectId, c => c.MapFrom(v => v.Id)).ForMember(x => x.ProjectName, c => c.MapFrom(v => v.ProjectName));
            //CreateMap<WebApps, ProjectsWebAppsDto>();

            CreateMap<WebApps, WebAppDropDownDto>().ForMember(x => x.WebAppId, c => c.MapFrom(v => v.Id))
                .ForMember(x => x.WebAppName, c => c.MapFrom(v => v.WebAppUrl));
        }
    }
}
