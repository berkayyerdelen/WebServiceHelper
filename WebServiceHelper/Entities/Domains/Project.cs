using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.BaseEntities;

namespace WebServiceHelper.Entities.Domains
{
    public class Project:FullAuditedEntity<int>
    {
        public string ProjectName { get; set; }
        public virtual ICollection<WebServices> WebServices { get; set; }
        public Project()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
