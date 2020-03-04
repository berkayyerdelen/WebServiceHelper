using AutoMapper;
using Core.Domain.Project.Queries;
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
            CreateMap<List<Project>, List<GetProjectDetailDto>>();
            //CreateMap<GetProjectDetailsViewModel, Project>();
        }
    }
}
