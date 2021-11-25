using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TaskManager.Repository
{
    public interface IRepositoryBase<T>
    {
        List<T> GetAll(); 
        Task<List<T>> GetAllAsync();
        List<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        void Create(T entity);
        Task CreateAsync(T entity);
        void Update(T entity);
        Task UpdateAsync(T entity);
        void Delete(T entity);
        Task DeleteAsync(T entity);
        T GetById(object id);
    }
}
