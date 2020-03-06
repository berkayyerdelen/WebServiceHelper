using Core.Common.CacheManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class Cache : Attribute
    {
        private CacheRepository tet = new CacheRepository();
        
        public int Duration { get; set; }
        public string CacheKey { get; set; }
        public Cache(int duration, string cacheKey)
        {
            this.Duration = duration;
            this.CacheKey = cacheKey;
            
        }
       
        
        


    }
}
