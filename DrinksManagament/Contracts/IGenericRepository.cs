﻿namespace DrinksManagament.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task<bool> ExistById(int id);
        Task DeleteByIdAsync(int id);
        Task UpdateAsync(T entity);
    }
}
