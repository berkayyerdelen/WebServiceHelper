using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.Domains;

namespace WebServiceHelper.ViewModel
{
    public class HomeViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public  ICollection<WebApps> WebServices { get; set; }
        public  ICollection<WebAppDetails> WebAppDetails { get; set; }


    }
}
