using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Common.Helper
{
    public class CacheHelper
    {
        public static async Task<T> GetOrCreateAsync<T>(
           IMemoryCache cache,
           string cacheKey,
           Func<Task<T>> factory,
           double slidingMinutes = 10,
           double absoluteHours = 1)
        {
            try
            {
                if (cache.TryGetValue(cacheKey, out T cachedData))
                {

                    return cachedData;

                }
                else
                {
                    T data = await factory();

                    cache.Set(cacheKey, data, new MemoryCacheEntryOptions
                    {
                        SlidingExpiration = TimeSpan.FromMinutes(slidingMinutes),
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(absoluteHours),
                        Priority = CacheItemPriority.High
                    });

                    return data;
                }

            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
