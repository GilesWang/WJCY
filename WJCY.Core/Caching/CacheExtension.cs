using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WJCY.Core.Caching
{
    public static class CacheExtension
    {
        /// <summary>
        /// 获取缓存值，如果没有则加载然后加到缓存并返回
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="cacheManager">Cache Manager</param>
        /// <param name="cacheKey">缓存值</param>
        /// <param name="acquire">如果缓存中没有则用此方法加载数据</param>
        /// <returns></returns>
        public static T Get<T>(this ICacheManager cacheManager, string cacheKey, Func<T> acquire)
        {
            return cacheManager.Get(cacheKey, 60, acquire);
        }

        /// <summary>
        /// 获取缓存值，如果没有则加载然后加到缓存并返回
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="cacheManager">Cache Manager</param>
        /// <param name="cacheKey">缓存值</param>
        /// <param name="cacheTime">缓存时间</param>
        /// <param name="acquire">如果缓存中没有则用此方法加载数据</param>
        /// <returns></returns>
        public static T Get<T>(this ICacheManager cacheManager, string cacheKey, int cacheTime, Func<T> acquire)
        {
            if (cacheManager.IsSet(cacheKey))
            {
                return cacheManager.Get<T>(cacheKey);
            }

            var result = acquire();
            if (cacheTime > 0)
            {
                cacheManager.Set(cacheKey, result, cacheTime);
            }
            return result;

        }

        /// <summary>
        /// 根据模式删除缓存项
        /// </summary>
        /// <param name="cacheManager">Cache manager</param>
        /// <param name="pattern">缓存key模式</param>
        /// <param name="keys">缓存中所有的key</param>
        public static void RemoveByPattern(this ICacheManager cacheManager, string pattern, IEnumerable<string> keys)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var key in keys.Where(p => regex.IsMatch(p.ToString())).ToList())
                cacheManager.Remove(key);
        }
    }
}
