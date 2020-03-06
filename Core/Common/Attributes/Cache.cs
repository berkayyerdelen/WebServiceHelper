using Core.Common.CacheManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class Cache : Attribute
    {

        
        public int Duration { get; set; }
        public string CacheKey { get; set; }
        public Cache(int duration, string cacheKey)
        {
            this.Duration = duration;
            this.CacheKey = cacheKey;
            
        }
       
        
        


    }
}
