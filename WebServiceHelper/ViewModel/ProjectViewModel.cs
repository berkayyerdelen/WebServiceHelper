using Core.Domain.Project.Queries.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.Project.Queries.Project.ProjectDetails;
using Core.Domain.Project.Queries.Project.ProjectDetails.Dto;
using Core.Domain.Project.Queries.Project.ProjectNames;

namespace WebServiceHelper.ViewModel
{
    public class ProjectViewModel
    {
        public List<ProjectDto> projectViewModel { get; set; }
    }
}
