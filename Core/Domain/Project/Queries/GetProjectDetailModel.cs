using System.Collections.Generic;
using Domain.Entities;

namespace Core.Domain.Project.Queries
{
    public class GetProjectDetailModel
    {
        public string ProjectName { get; set; }
        public virtual ICollection<> Webapps { get; set; }
    }
}