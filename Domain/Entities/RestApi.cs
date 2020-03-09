using Domain.Common.BaseEntites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class RestApi : FullAuditedEntity<int>
    {
        public string ApiURL { get; set; }
        public string Token { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public RestApi()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
