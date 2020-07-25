

namespace OnlineExamApp.API.Interfaces
{
    public interface ICacheService
    {
        T Get<T>(string key) where T : class;
        void Add<T>(string key, T data, double? expiration = null) where T : class;
        void Remove(string cacheKey);
        void RemoveAllFromCache();
    }
}