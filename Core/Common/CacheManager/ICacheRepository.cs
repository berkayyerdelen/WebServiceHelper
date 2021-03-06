﻿using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Common.CacheManager
{
    interface ICacheRepository:IDisposable
    {
        bool TryGetValue(object key, out object value);
        ICacheEntry CreateEntry(object key);
        void Remove(object key);
    }
}
