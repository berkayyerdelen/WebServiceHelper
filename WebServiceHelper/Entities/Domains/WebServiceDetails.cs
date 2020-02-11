using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.BaseEntities;

namespace WebServiceHelper.Entities.Domains
{
    public class WebServiceDetails:AuditedEntity<int>
    {
        public string Url { get; set; }
        public int WebServiceId { get; set; }
        [ForeignKey("WebServiceId")]
        public WebServices WebServices{ get; set; }
    }
}
