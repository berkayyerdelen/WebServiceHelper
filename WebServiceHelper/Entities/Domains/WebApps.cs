using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.BaseEntities;

namespace WebServiceHelper.Entities.Domains
{
    public class WebApps : FullAuditedEntity<int>
    {
        public string WebAppUrl{ get; set; }
        public int ProjectId { get; set; }

        public WebApps()
        {
            CreatedDate = DateTime.Now;
        }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
        public virtual ICollection<WebAppDetails> WebAppDetails { get; set; }
        public WebAppType WebAppType { get; set; }

    }
    public enum WebAppType : byte
    {
        WebApi = 1,
        WebSite = 2
    }
}
