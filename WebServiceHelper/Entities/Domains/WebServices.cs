using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.BaseEntities;

namespace WebServiceHelper.Entities.Domains
{
    public class WebServices : FullAuditedEntity<int>
    {
        public string WebServiceName { get; set; }
        public int ProjectId { get; set; }

        public WebServices()
        {
            CreatedDate = DateTime.Now;
        }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public virtual ICollection<WebServiceDetails> WebServiceDetails { get; set; }
    }
}
