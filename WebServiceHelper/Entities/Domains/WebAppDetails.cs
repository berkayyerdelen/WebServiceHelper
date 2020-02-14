using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.BaseEntities;

namespace WebServiceHelper.Entities.Domains
{
    public class WebAppDetails : FullAuditedEntity<int>
    {
        public string WebAppAltUrl { get; set; }
        public int WebAppId { get; set; }

        [ForeignKey("WebAppId")]
        public virtual WebApps WebServices { get; set; }
        
        public WebAppDetails()
        {
            CreatedDate = DateTime.Now;
        }

    }
   
}
