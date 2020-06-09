using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvMTabbed.Services
{
    public interface IDataStore<T>
    {
        // 添加
        Task<bool> AddItemAsync(T item);
        // 更新
        Task<bool> UpdataItemAsync(T item);
        // 删除
        Task<bool> DeleteItemAsync(string id);
        // 获取同步数据
        Task<T> GetItemAsync(string id);
        // 
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);

    }
}
