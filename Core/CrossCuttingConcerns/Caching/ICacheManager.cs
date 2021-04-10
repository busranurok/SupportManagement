using System;
namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object data, int duration);
        bool IsAdd(string key);
        void Remove(string key);
        //get işle başlayan bütün cachleri sil gibi
        void RemoveByPattern(string pattern);
    }
}
