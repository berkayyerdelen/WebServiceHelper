using System.Collections;
using System.Collections.Generic;
using AutoMapper;


namespace Core.Domain.Project.Queries
{
    public class GetProjectDetailsViewModel:Profile
    {
        public List<GetProjectDetailDto> GetProjectDetailModels { get; set; }

        public GetProjectDetailsViewModel()
        {
            CreateMap<List<global::Domain.Entities.Project>, GetProjectDetailsViewModel>();
        }
        
    }
}