using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Caching
{
    public partial class MemoryCacheManager : ICacheManager
    {
        /// <summary>
        /// 缓存对象
        /// </summary>
        protected ObjectCache Cache
        {
            get { return MemoryCache.Default; }
        }

        /// <summary>
        /// 清除缓存
        /// </summary>
        public virtual void Clear()
        {
            foreach (var item in Cache)
            {
                Remove(item.Key);
            }
        }

        public virtual void Dispose()
        {
        }

        /// <summary>
        /// 根据指定的key获取对应的缓存值
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="cacheKey">缓存key</param>
        /// <returns>与key对应的缓存值</returns>
        public virtual T Get<T>(string cacheKey)
        {
            return (T)Cache[cacheKey];
        }

        /// <summary>
        /// 判断key对应的缓存值是否已经缓存
        /// </summary>
        /// <param name="cacheKey">缓存值</param>
        /// <returns>true表示已经缓存，false表示未缓存</returns>
        public virtual bool IsSet(string cacheKey)
        {
            return Cache.Contains(cacheKey);
        }

        /// <summary>
        /// 移除缓存key对应的缓存值
        /// </summary>
        /// <param name="cacheKey">缓存值</param>
        public virtual void Remove(string cacheKey)
        {
            Cache.Remove(cacheKey);
        }

        /// <summary>
        /// 根据某种规矩删除缓存（如删除以WJCY.Product开头的所有缓存key对应的缓存值）
        /// </summary>
        /// <param name="pattern">缓存key的规律</param>
        public virtual void RemoveByPattern(string pattern)
        {
            this.RemoveByPattern(pattern, Cache.Select(p => p.Key));
        }

        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="cacheKey">缓存的key</param>
        /// <param name="cacheData">缓存的数据</param>
        /// <param name="cacheTime">缓存时间</param>
        public virtual void Set(string cacheKey, object cacheData, int cacheTime)
        {
            if (cacheData == null)
                return;

            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            var cacheItem = new CacheItem(cacheKey, cacheData);
            Cache.Set(cacheItem, policy);
        }
    }
}
