using System;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common.BaseEntites;

namespace Domain.Entities
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