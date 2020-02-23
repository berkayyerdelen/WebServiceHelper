using System;
using System.Collections.Generic;
using Domain.Common.BaseEntites;

namespace Domain.Entities
{
    public class Project : FullAuditedEntity<int>
    {
        public string ProjectName { get; set; }
        public virtual ICollection<WebApps> Webapps { get; set; }
        public Project()
        {
            CreatedDate = DateTime.Now;
        }
    }
}