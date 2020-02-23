using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Common.BaseEntites;
using Domain.Enums;

namespace Domain.Entities
{
    public class WebApps : FullAuditedEntity<int>
    {
        public string WebAppUrl { get; set; }
        public int ProjectId { get; set; }

        public WebApps()
        {
            CreatedDate = DateTime.Now;
        }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
        public virtual ICollection<WebAppDetails> WebAppDetails { get; set; }
        public WebAppType WebAppType { get; set; }

    }
   
}