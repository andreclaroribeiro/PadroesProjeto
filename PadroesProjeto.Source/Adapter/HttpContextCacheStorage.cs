using System;
//using System.Web;

namespace PadroesProjeto.Source.Adapter
{
    public class HttpContextCacheStorage : ICacheStorage
    {
        public void Remove(string key)
        {
            //HttpContext.Current.Cache.Remove(key);
        }

        public T Retrieve<T>(string key)
        {
            //T itemsStored = (T)HttpContext.Current.Cache.Get(key);
            //if (itemsStored == null)
            //{
            //    itemsStored = default(T);
            //}

            //return itemsStored;

            return default(T);
        }

        public void Store(string key, object data)
        {
            //HttpContext.Current.Cache.Insert(key, data);
        }
    }
}