using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Caching
{
    /// <summary>
    /// Cache Manager interface
    /// </summary>
    public interface ICacheManager : IDisposable
    {
        /// <summary>
        /// 根据指定的key获取对应的缓存值
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="cacheKey">缓存key</param>
        /// <returns>与key对应的缓存值</returns>
        T Get<T>(string cacheKey);

        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="cacheKey">缓存的key</param>
        /// <param name="cacheData">缓存的数据</param>
        /// <param name="cacheTime">缓存时间</param>
        void Set(string cacheKey, object cacheData, int cacheTime);

        /// <summary>
        /// 判断key对应的缓存值是否已经缓存
        /// </summary>
        /// <param name="cacheKey">缓存值</param>
        /// <returns>true表示已经缓存，false表示未缓存</returns>
        bool IsSet(string cacheKey);

        /// <summary>
        /// 移除缓存key对应的缓存值
        /// </summary>
        /// <param name="cacheKey">缓存值</param>
        void Remove(string cacheKey);
        /// <summary>
        /// 清除缓存
        /// </summary>
        void Clear();
        /// <summary>
        /// 根据某种规矩删除缓存（如删除以WJCY.Product开头的所有缓存key对应的缓存值）
        /// </summary>
        /// <param name="pattern">缓存key的规律</param>
        void RemoveByPattern(string pattern);


    }
}
