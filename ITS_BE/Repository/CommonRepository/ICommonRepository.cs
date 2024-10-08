﻿namespace ITS_BE.Repository.CommonRepository
{
    public interface ICommonRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> FindAsync(params object?[]? keyValues);
        Task AddAsync(T entity);
        Task AddAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteAsync(IEnumerable<T> entity);
        Task DeleteAsync(params object?[]? keyValues);
        Task<int> CountAsync();
    }
}
