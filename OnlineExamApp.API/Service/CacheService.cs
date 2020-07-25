using System;
using System.Threading;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Service
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<CacheService> _logger;

        public CacheService(IMemoryCache memoryCache, ILogger<CacheService> logger)
        {
            _memoryCache = memoryCache;
            _logger = logger;
        }

        public T Get<T>(string key) where T : class
        {
            return _memoryCache.Get<T>(key);
        }

        private static CancellationTokenSource  _cts;

        public static CancellationTokenSource GetGlobalCancellationTokenSource()
        {
            if(_cts == null)
            {
                _cts = new CancellationTokenSource();
            }
            return _cts;
        }

        public void Add<T>(string key, T data, double? expiration = null) where T : class
        {
            var entryOptions = new MemoryCacheEntryOptions();

            if(expiration != null)
            {
                entryOptions.AbsoluteExpiration = new DateTimeOffset(DateTime.Now.AddMinutes(expiration.Value));
            }
            else
            {
                var cts = GetGlobalCancellationTokenSource();
                entryOptions.AddExpirationToken(new CancellationChangeToken(cts.Token)); 
            }

            entryOptions.RegisterPostEvictionCallback((cacheKey, value, reason, substrate) => 
            {
                _logger.LogDebug($"{cacheKey} was evicted from cache. Reason {reason}");
            });

            _memoryCache.Set(key, data, entryOptions);
        }

        public void Remove(string cacheKey)
        {
            _memoryCache.Remove(cacheKey);
        }

        public void RemoveAllFromCache()
        {
            if(_cts == null) return;

            _cts.Cancel();

            _cts = null;

            _logger.LogInformation($"Cache resynced successfully");
        }
    }
}